using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Degerlendirme
    {
        [Key,StringLength(10)]
        public string DegerlendirmeID { get; set; }

        [Required]
        public string UrunID { get; set; }

        [Required]
        public string MusteriID { get; set; }

        [Required]
        public string TedarikciID { get; set; }

        [Required]
        public string Il { get; set; }

        [Required]
        public double Puan { get; set; }

        [StringLength(250)]
        public string Yorum { get; set; }

        public DateTime EklenmeTarihi { get; set; }

    }
}
