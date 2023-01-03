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
    public class BankaMap : IEntityTypeConfiguration<Banka>
    {
        public void Configure(EntityTypeBuilder<Banka> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.HesapKodu).HasMaxLength(12);
            builder.Property(p => p.HesapIsmi).HasMaxLength(50);
            builder.Property(p => p.Bankasi).HasMaxLength(30);
            builder.Property(p => p.Sube).HasMaxLength(50);
            builder.Property(p => p.IbanNo).HasMaxLength(24);
            builder.Property(p => p.HesapNo).HasMaxLength(14);
            builder.Property(p => p.YetkiliAdi).HasMaxLength(50);
            builder.Property(p => p.YetkiliTelefonu).HasMaxLength(11);

            builder.ToTable("Bankalar");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.HesapKodu).HasColumnName("HesapKodu");
            builder.Property(p => p.HesapIsmi).HasColumnName("HesapIsmi");
            builder.Property(p => p.Bankasi).HasColumnName("Bankasi");
            builder.Property(p => p.Sube).HasColumnName("Sube");
            builder.Property(p => p.IbanNo).HasColumnName("IbanNo");
            builder.Property(p => p.HesapNo).HasColumnName("HesapNo");
            builder.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            builder.Property(p => p.YetkiliTelefonu).HasColumnName("YetkiliTelefonu");
        }
    }
}
