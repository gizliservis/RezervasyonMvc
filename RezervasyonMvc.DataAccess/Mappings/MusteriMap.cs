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
    public class MusteriMap : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.MusteriAdi).HasMaxLength(25);
            builder.Property(p => p.MusteriSoyadi).HasMaxLength(25);
            builder.Property(p => p.TcNo).HasMaxLength(11);
            builder.Property(p => p.Adresi).HasMaxLength(250);

            builder.ToTable("Musteriler");
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.MusteriAdi).HasColumnName("MusteriAdi");
            builder.Property(c => c.MusteriSoyadi).HasColumnName("MusteriSoyadi");
            builder.Property(c => c.TcNo).HasColumnName("TcNo");
            builder.Property(c => c.Adresi).HasColumnName("Adresi");
        }
    }
}
