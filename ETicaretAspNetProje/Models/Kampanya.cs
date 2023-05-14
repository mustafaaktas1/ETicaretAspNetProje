using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Kampanya
    {
        [Key,StringLength(10)]
        public string KampanyaID { get; set; }

        [Required]
        public string UrunID { get; set; }

        [Required]
        public double IndirimOrani { get; set; }

        [Required]
        public string KuponKodu { get; set; }

        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        public string KampanyaAciklama { get; set; }
        public string Resim { get; set; } ///Resim Tipi Olacak
    }
}
