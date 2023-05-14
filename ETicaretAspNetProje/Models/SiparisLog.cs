using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class SiparisLog
    {
        [Key, StringLength(10)]
        public string SiparisLogID { get; set; }

        [Required]
        public string MusteriID { get; set; }

        [Required]
        public string SiparisNumarasi { get; set; }

        [Required]
        public string TedarikciID { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        [Required]
        public double IslemTutari { get; set; }

        public string Aciklama { get; set; }

        public DateTime KayitTarihi { get; set; }
    }
}
