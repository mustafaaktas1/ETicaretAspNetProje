using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Tedarikci
    {
        [Key, StringLength(10)]
        public string TedarikçiID { get; set; }

        [Required]
        public string FirmaAdi { get; set; }

        [Required]
        public string FirmaYetkilisi { get; set; }

        [Required]
        public string Unvan { get; set; }

        [Required]
       
        public string Adres { get; set; }

        [Required]
        public string Sehir { get; set; }

        [Required]
        public string Ilce { get; set; }

        [Required]
        public string Mahalle { get;  set; }

        [Required]
        public int PostaKodu { get; set; }

        [Required]
        public string Durum { get; set; }

        [Required]
        public long TelNo { get; set; }
        public long Faks { get; set; }

        [Required]
        public string EMail { get; set; }

        public string WebSitesi { get; set; }

        [Required]
        public string FaturaAdresi { get; set; }

        [Required]
        public string FaturaSehri { get; set; }

        [Required]
        public string FaturaIlcesi { get; set; }

        [Required]
        public string OdemeMetodlari { get; set; }
        public string Aciklama { get; set; }
        public string Logo { get; set; } ////resim tipi olacak

        [Required,StringLength(32)]
        public string Sifre { get; set; }

        public DateTime Kayittarihi { get; set; }

    }
}
