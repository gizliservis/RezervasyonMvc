using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.DataAccess.Mappings
{
    public class RezervasyonHareketMap : IEntityTypeConfiguration<RezervasyonHareket>
    {
        public void Configure(EntityTypeBuilder<RezervasyonHareket> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ToplamOdaFiyati).HasPrecision(12, 2);

            builder.ToTable("RezervasyonHareketleri");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.RezervasyonId).HasColumnName("RezervasyonId");
            builder.Property(c => c.OdaId).HasColumnName("OdaId");
            builder.Property(c => c.YatakSayisi).HasColumnName("YatakSayisi");
            builder.Property(c => c.GunSayisi).HasColumnName("GunSayisi");
            builder.Property(c => c.KisiSayisi).HasColumnName("KisiSayisi");
            builder.Property(c => c.ToplamOdaFiyati).HasColumnName("ToplamOdaFiyati");

            builder.HasOne(c => c.Rezervasyon).WithMany(c => c.RezervasyonHareketleri).HasForeignKey(c => c.RezervasyonId);
            builder.HasOne(c => c.Oda).WithMany(c => c.RezervasyonHareketleri).HasForeignKey(c => c.OdaId);
        }
    }
}
