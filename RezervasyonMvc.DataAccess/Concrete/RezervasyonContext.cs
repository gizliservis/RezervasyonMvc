using Microsoft.EntityFrameworkCore;
using RezervasyonMvc.DataAccess.Mappings;
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
            optionsBuilder.UseSqlServer("Server=DESKTOP-SLOIL0F;Database=dbezervasyon;User Id=sa;Password=17421742;");
        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OdaMap());
            modelBuilder.ApplyConfiguration(new MusteriMap());
            modelBuilder.ApplyConfiguration(new RezervasyonMap());

        }
    }
}
