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
    public class RezervasyonMap : IEntityTypeConfiguration<Rezervasyon>
    {
        public void Configure(EntityTypeBuilder<Rezervasyon> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.RezToplamTutar).HasPrecision(12, 2);

            builder.ToTable("Rezervasyonşar");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.MusteriId).HasColumnName("MusteriId");
            builder.Property(c => c.GrisTarihi).HasColumnName("GrisTarihi");
            builder.Property(c => c.CikisTarihi).HasColumnName("CikisTarihi");
            builder.Property(c => c.OdaSayisi).HasColumnName("OdaSayisi");
            builder.Property(c => c.KişiSayisi).HasColumnName("KişiSayisi");
            builder.Property(c => c.RezToplamTutar).HasColumnName("RezToplamTutar");

            builder.HasOne(c => c.Musteri).WithMany(c => c.Rezervasyonlar).HasForeignKey(c => c.MusteriId);
        }
    }
}
