using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class SiparisDetay
    {
        [Key, StringLength(10)]
        public string SiparisDetayID { get; set; }

        [Required]
        public string SiparisNumarasi { get; set; }

        [Required]
        public string UrunID { get; set; }

        [Required]
        public double BirimMiktar { get; set; }

        [Required]
        public double BirimFiyat { get; set; }

        [Required]
        public double KDVMiktar { get; set; }

        [Required]
        public string Ebat { get; set; }

        [Required] 
        public double Agırlık { get; set; }

        [Required]
        public long KartNo { get; set; }

        [Required]
        public string KartIsim { get; set; }

        [Required]
        public int KartAy { get; set; }

        [Required]
        public int KartYil { get; set; }

        [Required]
        public double IslemTutari { get; set; }

        [Required]
        public double KDVTutari { get; set; }
    }
}
