using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Siparis
    {
        [Key, StringLength(10)]
        public string SiparisID { get; set; }

        [Required]
        public string MusteriID { get; set; }

        [Required]
        public int SiparisNumarasi { get; set; }

        [Required]
        public string NakliyeciID { get; set; }
        
        [Required]
        public string TedarikciID { get; set; }

        [Required]
        public string Adres { get; set; }

        [Required]
        public string Il { get; set; }
        
        [Required]
        public string Ilce { get; set; }

        [Required]
        public string Mahalle { get; set; }

        [Required]
        public int PostaKodu { get; set; }

        [Required]
        public DateTime SiparisTarihi { get; set; }

        [Required]
        public string Durum { get; set; }

        [Required]
        public DateTime TeslimTarihi { get; set; }
    }
}
