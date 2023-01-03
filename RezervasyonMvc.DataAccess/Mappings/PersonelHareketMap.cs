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
    public class PersonelHareketMap : IEntityTypeConfiguration<PersonelHareket>
    {
        public void Configure(EntityTypeBuilder<PersonelHareket> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.Unvani).HasMaxLength(15);
            builder.Property(p => p.PersonelKodu).HasMaxLength(12);
            builder.Property(p => p.PersonelAdi).HasMaxLength(50);
            builder.Property(p => p.TcKimlikNo).HasMaxLength(11);
            builder.Property(p => p.PrimOrani).HasPrecision(5, 2);
            builder.Property(p => p.ToplamSatis).HasPrecision(12, 2);
            builder.Property(p => p.AylikMaasi).HasPrecision(12, 2);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("PersonelHareketleri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.Unvani).HasColumnName("Unvani");
            builder.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            builder.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            builder.Property(p => p.TcKimlikNo).HasColumnName("TcKimlikNo");
            builder.Property(p => p.Donemi).HasColumnName("Donemi");
            builder.Property(p => p.ToplamSatis).HasColumnName("ToplamSatis");
            builder.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            builder.Property(p => p.AylikMaasi).HasColumnName("AylikMaasi");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
