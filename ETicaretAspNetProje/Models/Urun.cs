using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Urun
    {
        [Key, StringLength(10)]
        public string UrunID { get; set; }

        [Required]
        public string TedarikciID { get; set; }

        [Required]
        public string UrunAdi { get; set; }

        [Required]
        public string UrunMarkasi { get; set; }

        public string UrunAciklamasi { get; set; }

        public double BirimMiktar { get; set; }

        [Required]
        public double BirimFiyat { get; set; }

        public double KdvMiktari { get; set; }

        public string Ebat { get; set; }

        public string Renk { get; set;}
        
        [Required]
        public string KategoriID { get; set; }

        [Required]
        public string StokDurumu { get; set; }

        [Required]
        public string StokMiktari { get; set; }

        public string Resim { get; set; }////resim tipi olacak

        public string Aciklama { get; set; }

        public DateTime EklenmeTarihi { get; set; }
    }
}
