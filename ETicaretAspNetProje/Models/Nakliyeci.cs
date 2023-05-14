using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Nakliyeci
    {
        [Key, StringLength(10)]
        public string NakliyeciID { get; set; }

        [Required]
        public string FirmaAdi { get; set; }

        [Required]
        public long TelNo { get; set; }

        public long Faks { get; set; }

        [Required]
        public string EMail { get; set; }

        public DateTime KayitTarihi { get; set; }

    }
}
