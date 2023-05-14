using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ETicaretAspNetProje.Models
{
    public class Kategori
    {
        [Key,StringLength(10)]
        public string KategoriId { get; set; }
        [Required]
        public string AnaKategoriAdi { get; set; }
        public string AraKategoriAdi { get;set; }
        public string AltKategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public string Resim { get; set; } ///resim Tipi olacak

        [Required]
        public string Durum { get; set; }
    }
}
