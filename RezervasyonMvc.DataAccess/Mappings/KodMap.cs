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
    public class KodMap : IEntityTypeConfiguration<Kod>
    {
        public void Configure(EntityTypeBuilder<Kod> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OnEki).HasMaxLength(6);
            builder.Property(p => p.Tablo).HasMaxLength(15);


            builder.ToTable("Kodlar");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.OnEki).HasColumnName("OnEki");
            builder.Property(p => p.Tablo).HasColumnName("Tablo");
            builder.Property(p => p.SonDeger).HasColumnName("SonDeger");
        }
    }
}
