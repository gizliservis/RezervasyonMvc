using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.DataAccess.Mappings
{
    public class KasaHareketMap : IEntityTypeConfiguration<KasaHareket>
    {
        public void Configure(EntityTypeBuilder<KasaHareket> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.Hareket).HasMaxLength(10);
            builder.Property(p => p.Tutar).HasPrecision(12, 2);
            builder.Property(p => p.Aciklama).HasMaxLength(200);


            builder.ToTable("KasaHareketleri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.Hareket).HasColumnName("Hareket");
            builder.Property(p => p.KasaId).HasColumnName("KasaId");
            builder.Property(p => p.OdemeTuruId).HasColumnName("OdemeTuruId");
            builder.Property(p => p.CariId).HasColumnName("CariId");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.Tutar).HasColumnName("Tutar");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");

            builder.HasOne(c => c.Kasa).WithMany(c => c.KasaHareket).HasForeignKey(c => c.KasaId);
            builder.HasOne(c => c.OdemeTuru).WithMany(c => c.KasaHareket).HasForeignKey(c => c.OdemeTuruId);
            builder.HasOne(c => c.Cari).WithMany(c => c.KasaHareket).HasForeignKey(c => c.CariId);
        }
    }
}
