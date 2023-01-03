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
    public class SirketBilgiMap : IEntityTypeConfiguration<SirketBilgi>
    {
        public void Configure(EntityTypeBuilder<SirketBilgi> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SirketKodu).HasMaxLength(12);
            builder.Property(p => p.SirketKisaAdi).HasMaxLength(50);
            builder.Property(p => p.SirketUnvani).HasMaxLength(150);
            builder.Property(p => p.Ili).HasMaxLength(30);
            builder.Property(p => p.Ilcesi).HasMaxLength(30);
            builder.Property(p => p.Semt).HasMaxLength(30);
            builder.Property(p => p.SirketTelNo).HasMaxLength(11);
            builder.Property(p => p.Ulkesi).HasMaxLength(30);
            builder.Property(p => p.VergiDairesi).HasMaxLength(30);
            builder.Property(p => p.VergiNo).HasMaxLength(11);
            builder.Property(p => p.Web).HasMaxLength(100);
            builder.Property(p => p.YetkiliKisi).HasMaxLength(50);
            builder.Property(p => p.Fax).HasMaxLength(30);
            builder.Property(p => p.EMail).HasMaxLength(50);
            builder.Property(p => p.Adres).HasMaxLength(250);
            builder.Property(p => p.Aciklama).HasMaxLength(200);


            builder.ToTable("SirketBilgileri");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.SirketKodu).HasColumnName("SirketKodu");
            builder.Property(p => p.SirketKisaAdi).HasColumnName("SirketKisaAdi");
            builder.Property(p => p.SirketUnvani).HasColumnName("SirketUnvani");
            builder.Property(p => p.Ili).HasColumnName("Ili");
            builder.Property(p => p.Ilcesi).HasColumnName("Ilcesi");
            builder.Property(p => p.Semt).HasColumnName("Semt");
            builder.Property(p => p.SirketTelNo).HasColumnName("SirketTelNo");
            builder.Property(p => p.Ulkesi).HasColumnName("Ulkesi");
            builder.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            builder.Property(p => p.VergiNo).HasColumnName("VergiNo");
            builder.Property(p => p.Web).HasColumnName("Web");
            builder.Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            builder.Property(p => p.Fax).HasColumnName("Fax");
            builder.Property(p => p.EMail).HasColumnName("EMail");
            builder.Property(p => p.Adres).HasColumnName("Adres");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");

        }
    }
}
