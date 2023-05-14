using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class TedarikciLog
    {
        [Key, StringLength(10)]
        public string TedarikciLogID { get; set; }

        [Required]
        public string TedarikciID { get; set; }

        [Required]
        public string FirmaAdi { get; set; }

        [Required]
        public DateTime IslemTarihi { get; set; }

        [Required]
        public string YapilanIslem { get; set; }

        [Required]
        public string IsleminYapildigiIP { get; set; }
    }
}
