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
    public class IndirimMap : IEntityTypeConfiguration<Indirim>
    {
        public void Configure(EntityTypeBuilder<Indirim> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.StokKodu).HasMaxLength(12);
            builder.Property(p => p.StokAdi).HasMaxLength(50);
            builder.Property(p => p.Barkod).HasMaxLength(20);
            builder.Property(p => p.IndirimTuru).HasMaxLength(15);
            builder.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("Indirimler");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Durumu).HasColumnName("Durumu");
            builder.Property(p => p.StokKodu).HasColumnName("StokKodu");
            builder.Property(p => p.StokAdi).HasColumnName("StokAdi");
            builder.Property(p => p.Barkod).HasColumnName("Barkod");
            builder.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            builder.Property(p => p.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            builder.Property(p => p.BitisTarihi).HasColumnName("BitisTarihi");
            builder.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
