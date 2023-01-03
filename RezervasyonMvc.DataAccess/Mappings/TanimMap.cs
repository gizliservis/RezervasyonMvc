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
    public class TanimMap : IEntityTypeConfiguration<Tanim>
    {
        public void Configure(EntityTypeBuilder<Tanim> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Turu).HasMaxLength(15);
            builder.Property(p => p.Tanimi).HasMaxLength(30);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

           builder.ToTable("Tanimlar");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Turu).HasColumnName("Turu");
            builder.Property(p => p.Tanimi).HasColumnName("Tanimi");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
