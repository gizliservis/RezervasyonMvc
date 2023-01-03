using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RezervasyonMvc.DataAccess.Migrations
{
    public partial class TableDuzenleMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bankalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HesapKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    HesapIsmi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bankasi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Sube = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IbanNo = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true),
                    HesapNo = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YetkiliTelefonu = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cariler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    CariTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CariKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CariAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FaturaUnvani = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CepTelefonu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Web = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CariGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CariAltGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IskontoOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    RiskLimiti = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisOzelFiyati = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SatisOzelFiyati = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cariler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    DepoAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    YetkiliKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizliSatislar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UrunAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    GrupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliSatislar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizliSatislarGruplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliSatislarGruplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Indirimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Barkod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StokAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndirimTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IndirimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indirimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasaKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    KasaAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    YetkiliKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    YetkiliAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kodlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tablo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    OnEki = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    SonDeger = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kodlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Gorevi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Parola = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    HatirlatmaSorusu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cevap = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SonGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRolleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RootId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FormAdi = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    KontrolAdi = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Yetki = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRolleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdemeTurleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdemeTuruKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    OdemeTuruAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemeTurleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PersonelKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    PersonelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Donemi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    ToplamSatis = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    AylikMaasi = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelHareketleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calisiyor = table.Column<bool>(type: "bit", nullable: false),
                    Unvani = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PersonelKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    PersonelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TcKimlikNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    IseGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CepTelefonu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Web = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    AylikMaasi = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SirketBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    SirketKisaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SirketUnvani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Ulkesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ili = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Ilcesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SirketTelNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Web = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    YetkiliKisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SirketBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durumu = table.Column<bool>(type: "bit", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    StokAdi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Barkod = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BarkodTuru = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Birimi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    StokGrubu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StokAltGrubu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Modeli = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OzelKod4 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GarantiSüresi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UreticiKodu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlisKdv = table.Column<int>(type: "int", nullable: false),
                    SatisKdv = table.Column<int>(type: "int", nullable: false),
                    AlisFiyati1 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati1 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SatisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    MinStokMiktari = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    MaxStokMiktari = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turu = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Tanimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankaHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Hareket = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BankaId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankaHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankaHareketleri_Bankalar_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Bankalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankaHareketleri_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KasaHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Hareket = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    KasaId = table.Column<int>(type: "int", nullable: false),
                    OdemeTuruId = table.Column<int>(type: "int", nullable: false),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KasaHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_Kasalar_KasaId",
                        column: x => x.KasaId,
                        principalTable: "Kasalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KasaHareketleri_OdemeTurleri_OdemeTuruId",
                        column: x => x.OdemeTuruId,
                        principalTable: "OdemeTurleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    FisTuru = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CariTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    FaturaUnvani = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CepTelefonu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BelgeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlasiyerId = table.Column<int>(type: "int", nullable: true),
                    IskontoOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    IskontoTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Alacak = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Borc = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    ToplamTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FisBaglantiKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    DepoIrsaliye = table.Column<bool>(type: "bit", nullable: false),
                    DepoAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BankaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fisler_Bankalar_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Bankalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fisler_Cariler_CariId",
                        column: x => x.CariId,
                        principalTable: "Cariler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fisler_Personeller_PlasiyerId",
                        column: x => x.PlasiyerId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StokHareketleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FisKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    FisBaglantiKodu = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Hareket = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(12,3)", precision: 12, scale: 3, nullable: true),
                    Kdv = table.Column<int>(type: "int", nullable: false),
                    BirimFiyati = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati2 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    AlisFiyati3 = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    IndirimOrani = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ToplamTutar = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    MevcutStok = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    SayimMiktari = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Siparis = table.Column<bool>(type: "bit", nullable: false),
                    Irsaliye = table.Column<bool>(type: "bit", nullable: false),
                    Teklif = table.Column<bool>(type: "bit", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHareketleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokHareketleri_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StokHareketleri_Stoklar_StokId",
                        column: x => x.StokId,
                        principalTable: "Stoklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankaHareketleri_BankaId",
                table: "BankaHareketleri",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_BankaHareketleri_CariId",
                table: "BankaHareketleri",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_BankaId",
                table: "Fisler",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_CariId",
                table: "Fisler",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_Fisler_PlasiyerId",
                table: "Fisler",
                column: "PlasiyerId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_CariId",
                table: "KasaHareketleri",
                column: "CariId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_KasaId",
                table: "KasaHareketleri",
                column: "KasaId");

            migrationBuilder.CreateIndex(
                name: "IX_KasaHareketleri_OdemeTuruId",
                table: "KasaHareketleri",
                column: "OdemeTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketleri_DepoId",
                table: "StokHareketleri",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_StokHareketleri_StokId",
                table: "StokHareketleri",
                column: "StokId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankaHareketleri");

            migrationBuilder.DropTable(
                name: "Fisler");

            migrationBuilder.DropTable(
                name: "HizliSatislar");

            migrationBuilder.DropTable(
                name: "HizliSatislarGruplari");

            migrationBuilder.DropTable(
                name: "Indirimler");

            migrationBuilder.DropTable(
                name: "KasaHareketleri");

            migrationBuilder.DropTable(
                name: "Kodlar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "KullaniciRolleri");

            migrationBuilder.DropTable(
                name: "PersonelHareketleri");

            migrationBuilder.DropTable(
                name: "SirketBilgileri");

            migrationBuilder.DropTable(
                name: "StokHareketleri");

            migrationBuilder.DropTable(
                name: "Tanimlar");

            migrationBuilder.DropTable(
                name: "Bankalar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Cariler");

            migrationBuilder.DropTable(
                name: "Kasalar");

            migrationBuilder.DropTable(
                name: "OdemeTurleri");

            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "Stoklar");
        }
    }
}
