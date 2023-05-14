using Microsoft.EntityFrameworkCore;

namespace ETicaretAspNetProje.Models
{
    public class ETicaretContext: DbContext
    {
        public DbSet<Degerlendirme> Degerlendirmeler { get; set; }
        public DbSet<Kampanya> Kampanyalar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriLog> MusteriLoglar { get; set; }
        public DbSet<Nakliyeci> Nakliyeciler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public DbSet<SiparisLog> SiparisLoglar { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<TedarikciLog> TedarikciLoglar { get; set; }
        public DbSet<Urun> Urunler { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // azurenin verdiği string// optionsBuilder.UseSqlServer("Server=tcp:eticaretdb.database.windows.net,1433;Initial Catalog=ETicaretTiklaAlDB;Persist Security Info=False;User ID=mustafaaktas;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
             optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=ETicaretTiklaAlDB; Integrated Security=true;");
           // optionsBuilder.UseSqlServer("Server=eticaretdb.database.windows.net,1433; Database=ETicaretTiklaAlDB; User ID=mustafaaktas;Password=m2.u4.stafa; Trusted_Connection=False; Encrypt=True;");
        }
    }
}
