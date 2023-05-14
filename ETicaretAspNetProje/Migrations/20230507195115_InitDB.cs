using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaretAspNetProje.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Degerlendirmeler",
                columns: table => new
                {
                    DegerlendirmeID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UrunID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TedarikciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Puan = table.Column<double>(type: "float", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degerlendirmeler", x => x.DegerlendirmeID);
                });

            migrationBuilder.CreateTable(
                name: "Kampanyalar",
                columns: table => new
                {
                    KampanyaID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UrunID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndirimOrani = table.Column<double>(type: "float", nullable: false),
                    KuponKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KampanyaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampanyalar", x => x.KampanyaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AnaKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AraKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TCNo = table.Column<long>(type: "bigint", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostaKodu = table.Column<int>(type: "int", nullable: true),
                    Telno = table.Column<long>(type: "bigint", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    KartNo = table.Column<long>(type: "bigint", nullable: true),
                    KartIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KartAy = table.Column<int>(type: "int", nullable: true),
                    KartYil = table.Column<int>(type: "int", nullable: true),
                    KartTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaSehri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaPostaKodu = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "MusteriLoglar",
                columns: table => new
                {
                    MusteriLogID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MusteriID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YapilanIslem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsleminYapildigiIP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriLoglar", x => x.MusteriLogID);
                });

            migrationBuilder.CreateTable(
                name: "Nakliyeciler",
                columns: table => new
                {
                    NakliyeciID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<long>(type: "bigint", nullable: false),
                    Faks = table.Column<long>(type: "bigint", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nakliyeciler", x => x.NakliyeciID);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    SehirID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostaKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.SehirID);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylar",
                columns: table => new
                {
                    SiparisDetayID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SiparisNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirimMiktar = table.Column<double>(type: "float", nullable: false),
                    BirimFiyat = table.Column<double>(type: "float", nullable: false),
                    KDVMiktar = table.Column<double>(type: "float", nullable: false),
                    Ebat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agırlık = table.Column<double>(type: "float", nullable: false),
                    KartNo = table.Column<long>(type: "bigint", nullable: false),
                    KartIsim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KartAy = table.Column<int>(type: "int", nullable: false),
                    KartYil = table.Column<int>(type: "int", nullable: false),
                    IslemTutari = table.Column<double>(type: "float", nullable: false),
                    KDVTutari = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylar", x => x.SiparisDetayID);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MusteriID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisNumarasi = table.Column<int>(type: "int", nullable: false),
                    NakliyeciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TedarikciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<int>(type: "int", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeslimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisID);
                });

            migrationBuilder.CreateTable(
                name: "SiparisLoglar",
                columns: table => new
                {
                    SiparisLogID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MusteriID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TedarikciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IslemTutari = table.Column<double>(type: "float", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisLoglar", x => x.SiparisLogID);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    TedarikçiID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaYetkilisi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostaKodu = table.Column<int>(type: "int", nullable: true),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<long>(type: "bigint", nullable: true),
                    Faks = table.Column<long>(type: "bigint", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebSitesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaturaAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaSehri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaturaIlcesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdemeMetodlari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Kayittarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.TedarikçiID);
                });

            migrationBuilder.CreateTable(
                name: "TedarikciLoglar",
                columns: table => new
                {
                    TedarikciLogID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TedarikciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IslemTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YapilanIslem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsleminYapildigiIP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TedarikciLoglar", x => x.TedarikciLogID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TedarikciID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunMarkasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimMiktar = table.Column<double>(type: "float", nullable: false),
                    BirimFiyat = table.Column<double>(type: "float", nullable: false),
                    KdvMiktari = table.Column<double>(type: "float", nullable: false),
                    Ebat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokDurumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StokMiktari = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Degerlendirmeler");

            migrationBuilder.DropTable(
                name: "Kampanyalar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "MusteriLoglar");

            migrationBuilder.DropTable(
                name: "Nakliyeciler");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "SiparisDetaylar");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "SiparisLoglar");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "TedarikciLoglar");

            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
