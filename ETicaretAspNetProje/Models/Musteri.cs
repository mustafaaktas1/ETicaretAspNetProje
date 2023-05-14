using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Musteri
    {

        [Key, StringLength(10)]
        public string MusteriID { get; set; }

        [Required]
        public string MusteriAdi { get; set; }

        [Required]
        public string MusteriSoyadi { get; set; }

        [Required]
        public long TCNo { get; set; }


        public string Adres { get; set; }

        public string Sehir { get; set; }

        public string Ilce { get; set; }

        public string Mahalle { get; set; }

        public int PostaKodu { get; set; }

        [Required]
        public long Telno { get; set; }

        [Required]
        public string EMail { get; set; }

        [Required,StringLength(32)]
        public string Sifre { get; set; }

        public long KartNo { get; set; }

        public string KartIsim { get; set; }

        public int KartAy { get; set; }

        public int KartYil { get; set; }

        public string KartTuru { get; set; }

        public string FaturaAdresi { get; set; }

        public string FaturaSehri { get; set; }

        public int FaturaPostaKodu { get; set; }

        [StringLength(200)]
        public string Durum { get; set; }

        public DateTime KayitTarihi { get; set; }

    }
}
