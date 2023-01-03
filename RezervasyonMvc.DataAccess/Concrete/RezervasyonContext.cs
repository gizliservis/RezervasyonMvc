using Microsoft.EntityFrameworkCore;
using RezervasyonMvc.DataAccess.Mappings;
using RezervasyonMvc.DataAccess.ValidationRules;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.DataAccess.Concrete
{
    public class RezervasyonContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SLOIL0F;Database=IsbaSatisDb;User Id=sa;Password=17421742;");
        }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> hizliSatisGruplari { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod> Kodlar { get; set; }
        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<BankaHareket> BankaHareketleri { get; set; }
        public DbSet<SirketBilgi> SirketBilgileri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StokMap());
            modelBuilder.ApplyConfiguration(new CariMap());
            modelBuilder.ApplyConfiguration(new FisMap());
            modelBuilder.ApplyConfiguration(new StokHareketMap());
            modelBuilder.ApplyConfiguration(new KasaHareketMap());
            modelBuilder.ApplyConfiguration(new DepoMap());
            modelBuilder.ApplyConfiguration(new KasaMap());
            modelBuilder.ApplyConfiguration(new OdemeTuruMap());
            modelBuilder.ApplyConfiguration(new TanimMap());
            modelBuilder.ApplyConfiguration(new PersonelMap());
            modelBuilder.ApplyConfiguration(new PersonelHareketMap());
            modelBuilder.ApplyConfiguration(new IndirimMap());
            modelBuilder.ApplyConfiguration(new HizliSatisMap());
            modelBuilder.ApplyConfiguration(new HizliSatisGrupMap());
            modelBuilder.ApplyConfiguration(new KullaniciMap());
            modelBuilder.ApplyConfiguration(new KullaniciRolMap());
            modelBuilder.ApplyConfiguration(new KodMap());
            modelBuilder.ApplyConfiguration(new BankaMap());
            modelBuilder.ApplyConfiguration(new BankaHareketMap());
            modelBuilder.ApplyConfiguration(new SirketBilgiMap());
            

        }
    }
}
