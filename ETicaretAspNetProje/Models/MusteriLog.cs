using System;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class MusteriLog
    {
        [Key, StringLength(10)]
        public string MusteriLogID { get; set; }

        [Required]
        public string MusteriID { get; set; }

        [Required]
        public DateTime IslemTarihi { get; set; }

        [Required]
        public string YapilanIslem { get; set; }

        [Required]
        public string IsleminYapildigiIP { get; set; }
    }
}
