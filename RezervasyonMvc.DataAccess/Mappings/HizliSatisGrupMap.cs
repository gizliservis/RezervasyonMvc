using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class HizliSatisGrupMap : IEntityTypeConfiguration<HizliSatisGrup>
    {
        public void Configure(EntityTypeBuilder<HizliSatisGrup> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.GrupAdi).HasMaxLength(30);
            builder.Property(p => p.Aciklama).HasMaxLength(200);


            builder.ToTable("HizliSatislarGruplari");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.GrupAdi).HasColumnName("GrupAdi");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
