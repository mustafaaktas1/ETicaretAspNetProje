using ETicaretAspNetProje.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace ETicaretAspNetProje.Controllers
{
    public class LoginController : Controller
    {
        ETicaretContext ctx = new ETicaretContext();
        string qrtext = "";

        [HttpGet]
        public IActionResult LoginIndex ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginIndex (Musteri musteri, string md5metin)
        {
            md5metin = MD5Sifreleme(musteri.Sifre);
            var data = ctx.Musteriler.FirstOrDefault(m => m.EMail == musteri.EMail && m.Sifre == md5metin && m.Durum == "Aktif");
            if (data != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,musteri.EMail)
                };
                var useridentiyty = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentiyty);
                await HttpContext.SignInAsync(principal);
                //ViewData["login-hide"] = "login-hide";
                //ViewData["account-show"] = "";

                return RedirectToAction("Privacy", "Home");
            }
            else if (data == null)
            {
                ViewData["Hata"] = "E-Posta veya Şifreyi Kontrol Edin!";
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout ()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("AnaSayfa", "Home");
        }



        [HttpGet]
        public IActionResult SignupIndex ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignupIndex (Musteri musteri)
        {
            bool varmi = ctx.Musteriler.Any(m => m.EMail == musteri.EMail);

            ///////// sql identity//////
            var id = ctx.Musteriler.Count();
            id = id + 1;
            ///////// sql identity//////

            if (varmi)
            {
                ViewData["Hata"] = "Bu E-Posta Kayıtlı. Lütfen Farklı Bir E-Posta Deneyin!";
            }
            else if (varmi == false)
            {
                musteri.MusteriID = "M" + id;
                musteri.KayitTarihi = DateTime.Now;
                musteri.Sifre = MD5Sifreleme(musteri.Sifre);
                musteri.Durum = "Aktif";

                ctx.Musteriler.Add(musteri);
                ctx.SaveChanges();
                return RedirectToAction("LoginIndex", "Login");
            }

            return View();
        }



        [HttpGet]
        public IActionResult SifremiUnuttum (SifreSifirla sifreSifirla)
        {
            Random random = new Random();
            qrtext = random.Next(100000, 1000000).ToString();
            
            ViewData["text"] = qrtext;
            sifreSifirla.DogrulamaKodu = int.Parse(qrtext);
            

            // QR kodunu HTML sayfasında görüntüleme
            ViewBag.qrcode = QROlusturma(qrtext);
            
            return View();
        }

        [HttpPost]
        public IActionResult SifremiUnuttum (Musteri musteri, SifreSifirla sifreSifirla)
        {
            var data = ctx.Musteriler.FirstOrDefault(m => m.EMail == sifreSifirla.Email);
            if (data != null)
            {//doğrulma kodu kontrolü
                if (sifreSifirla.DogrulamaKodu == sifreSifirla.GirilenKod)
                {
                    return RedirectToAction("SifremiSifirla", "Login");
                }
                else if (sifreSifirla.DogrulamaKodu !=sifreSifirla.GirilenKod)
                {
                   
                    ViewData["Hata2"] = "Doğrulama Kodu Yanlış!";
                    ViewBag.qrcode = QROlusturma(qrtext);
                    ViewData["text"] = qrtext; 
                    return RedirectToAction("SifremiSifirla", "Login");//doğrulamayı atlamak için
                }
                else
                {
                    ViewData["Hata2"] = "Else düştü!";
                    ViewBag.qrcode = QROlusturma(qrtext);
                    ViewData["text"] = qrtext;
                }
                
            }
            else if (data == null)
            {
                ViewData["Hata"] = "Girilen E-Postaya Kayıtlı Hesap Bulunamadı!";
                ViewBag.qrcode = QROlusturma(qrtext);
                ViewData["text"] = qrtext;
            }
            return View(); 

        }


        [HttpGet]
        public IActionResult SifremiSifirla ()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SifremiSifirla (SifreSifirla sifreSifirla, Musteri musteri, string md5metin)
        {
           
            if (sifreSifirla.YeniSifre != "" && sifreSifirla.YeniSifreTekrar != "")
            {
                if (sifreSifirla.YeniSifre == sifreSifirla.YeniSifreTekrar)
                { md5metin = MD5Sifreleme(sifreSifirla.YeniSifre);
                    //şifre güncelleme
                    var deger = ctx.Musteriler.FirstOrDefault(m=>m.EMail== sifreSifirla.Email);

                    deger.Sifre = md5metin;
                   
                    
                    ctx.SaveChanges();
                    return RedirectToAction("AnaSayfa", "Home");
                }
                else
                {
                    ViewData["Hata"] = "Girilen Şifreler Uyuşmuyor!";
                }
            }

            return View();
        }


        static string MD5Sifreleme (string metin)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] metinBytes = Encoding.UTF8.GetBytes(metin);
                byte[] sifreliMetinBytes = md5.ComputeHash(metinBytes);

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < sifreliMetinBytes.Length; i++)
                {
                    sb.Append(sifreliMetinBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
        static string QROlusturma (string qrtext)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrtext, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);


            MemoryStream memoryStream = new MemoryStream();
            qrCodeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageBytes = memoryStream.ToArray();
            string base64String = Convert.ToBase64String(imageBytes);
            string imageUrl = $"data:image/png;base64,{base64String}";
            return imageUrl;
        }

    }
}


////////////////şife sıfırlama mail gönderme////////////////////////



//using System;
//using System.Net;
//using System.Net.Mail;

//public class EmailSender
//{
//    public void SendEmail (string recipient, string subject, string body)
//    {
//        try
//        {
//            // E-posta göndermek için kullanılacak SMTP istemcisi oluşturulur
//            SmtpClient client = new SmtpClient("smtp.example.com", 587);
//            client.UseDefaultCredentials = false;
//            client.Credentials = new NetworkCredential("username", "password"); // E-posta sağlayıcınız tarafından sağlanan kimlik bilgilerini kullanın
//            client.EnableSsl = true;

//            // Gönderen e-posta adresi ve alıcı e-posta adresi belirlenir
//            MailAddress from = new MailAddress("sender@example.com", "Sender Name");
//            MailAddress to = new MailAddress(recipient);

//            // E-posta mesajı oluşturulur
//            MailMessage message = new MailMessage(from, to);
//            message.Subject = subject;
//            message.Body = body;

//            // E-posta gönderilir
//            client.Send(message);

//            Console.WriteLine("E-posta gönderildi.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("E-posta gönderirken bir hata oluştu: " + ex.Message);
//        }
//    }
//}
