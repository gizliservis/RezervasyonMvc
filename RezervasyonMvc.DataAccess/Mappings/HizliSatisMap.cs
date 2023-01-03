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
    public class HizliSatisMap : IEntityTypeConfiguration<HizliSatis>
    {
        public void Configure(EntityTypeBuilder<HizliSatis> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Barkod).HasMaxLength(150);
            builder.Property(p => p.UrunAdi).HasMaxLength(150);


            builder.ToTable("HizliSatislar");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Barkod).HasColumnName("Barkod");
            builder.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
