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
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.KullaniciAdi).HasMaxLength(20);
            builder.Property(p => p.Adi).HasMaxLength(20);
            builder.Property(p => p.Soyadi).HasMaxLength(20);
            builder.Property(p => p.Gorevi).HasMaxLength(20);
            builder.Property(p => p.HatirlatmaSorusu).HasMaxLength(50);
            builder.Property(p => p.Cevap).HasMaxLength(20);
            builder.Property(p => p.Parola).HasMaxLength(32);


            builder.ToTable("Kullanicilar");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            builder.Property(p => p.Adi).HasColumnName("Adi");
            builder.Property(p => p.Soyadi).HasColumnName("Soyadi");
            builder.Property(p => p.Gorevi).HasColumnName("Gorevi");
            builder.Property(p => p.HatirlatmaSorusu).HasColumnName("HatirlatmaSorusu");
            builder.Property(p => p.Cevap).HasColumnName("Cevap");
            builder.Property(p => p.Parola).HasColumnName("Parola");
            builder.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            builder.Property(p => p.SonGirisTarihi).HasColumnName("SonGirisTarihi");
        }
    }
}
