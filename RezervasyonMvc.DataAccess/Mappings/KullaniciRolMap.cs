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
    public class KullaniciRolMap : IEntityTypeConfiguration<KullaniciRol>
    {
        public void Configure(EntityTypeBuilder<KullaniciRol> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.KullaniciAdi).HasMaxLength(20);
            builder.Property(p => p.FormAdi).HasMaxLength(35);
            builder.Property(p => p.KontrolAdi).HasMaxLength(35);

            builder.ToTable("KullaniciRolleri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            builder.Property(p => p.RootId).HasColumnName("RootId");
            builder.Property(p => p.ParentId).HasColumnName("ParentId");
            builder.Property(p => p.FormAdi).HasColumnName("FormAdi");
            builder.Property(p => p.KontrolAdi).HasColumnName("KontrolAdi");
            builder.Property(p => p.Yetki).HasColumnName("Yetki");
        }
    }
}
