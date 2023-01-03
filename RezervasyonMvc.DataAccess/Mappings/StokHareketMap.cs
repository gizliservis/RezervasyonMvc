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
    public class StokHareketMap : IEntityTypeConfiguration<StokHareket>
    {
        public void Configure(EntityTypeBuilder<StokHareket> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FisKodu).HasMaxLength(14);
            builder.Property(p => p.FisBaglantiKodu).HasMaxLength(14);
            builder.Property(p => p.Hareket).HasMaxLength(10);
            builder.Property(p => p.Miktar).HasPrecision(12, 3);
            builder.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            builder.Property(p => p.AlisFiyati).HasPrecision(12, 2);
            builder.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            builder.Property(p => p.AlisFiyati3).HasPrecision(12, 2);
            builder.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            builder.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            builder.Property(p => p.SayimMiktari).HasPrecision(12, 2);
            builder.Property(p => p.MevcutStok).HasPrecision(12, 2);
            builder.Property(p => p.SeriNo).HasMaxLength(200);
            builder.Property(p => p.Aciklama).HasMaxLength(200);



            builder.ToTable("StokHareketleri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.FisBaglantiKodu).HasColumnName("FisBaglantiKodu");
            builder.Property(p => p.Hareket).HasColumnName("Hareket");
            builder.Property(p => p.StokId).HasColumnName("StokId");
            builder.Property(p => p.Kdv).HasColumnName("Kdv");
            builder.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            builder.Property(p => p.AlisFiyati).HasColumnName("AlisFiyati");
            builder.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            builder.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            builder.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            builder.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            builder.Property(p => p.SayimMiktari).HasColumnName("SayimMiktari");
            builder.Property(p => p.MevcutStok).HasColumnName("MevcutStok");
            builder.Property(p => p.DepoId).HasColumnName("DepoId");
            builder.Property(p => p.SeriNo).HasColumnName("SeriNo");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");

            builder.HasOne(c => c.Stok).WithMany(c => c.StokHareket).HasForeignKey(c => c.StokId);
            builder.HasOne(c => c.Depo).WithMany(c => c.StokHareket).HasForeignKey(c => c.DepoId);
        }
    }
}
