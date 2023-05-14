using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Sehir
    {
        [Key]
        public int SehirID { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }
        public string Mahalle { get; set; }

        public int PostaKodu { get; set; }

    }
}
