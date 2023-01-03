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
    public class CariMap : IEntityTypeConfiguration<Cari>
    {
        public void Configure(EntityTypeBuilder<Cari> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CariTuru).HasMaxLength(15);
            builder.Property(p => p.CariKodu).HasMaxLength(12);
            builder.Property(p => p.CariAdi).HasMaxLength(50);
            builder.Property(p => p.YetkiliKisi).HasMaxLength(50);
            builder.Property(p => p.FaturaUnvani).HasMaxLength(50);
            builder.Property(p => p.CepTelefonu).HasMaxLength(20);
            builder.Property(p => p.Telefon).HasMaxLength(20);
            builder.Property(p => p.Fax).HasMaxLength(20);
            builder.Property(p => p.EMail).HasMaxLength(50);
            builder.Property(p => p.Web).HasMaxLength(50);
            builder.Property(p => p.Il).HasMaxLength(20);
            builder.Property(p => p.Ilce).HasMaxLength(20);
            builder.Property(p => p.Semt).HasMaxLength(20);
            builder.Property(p => p.Adres).HasMaxLength(100);
            builder.Property(p => p.CariGrubu).HasMaxLength(30);
            builder.Property(p => p.CariAltGrubu).HasMaxLength(30);
            builder.Property(p => p.OzelKod1).HasMaxLength(30);
            builder.Property(p => p.OzelKod2).HasMaxLength(30);
            builder.Property(p => p.OzelKod3).HasMaxLength(30);
            builder.Property(p => p.OzelKod4).HasMaxLength(30);
            builder.Property(p => p.VergiDairesi).HasMaxLength(30);
            builder.Property(p => p.VergiNo).HasMaxLength(15);
            builder.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            builder.Property(p => p.RiskLimiti).HasPrecision(12, 2);
            builder.Property(p => p.AlisOzelFiyati).HasMaxLength(15);
            builder.Property(p => p.SatisOzelFiyati).HasMaxLength(15);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("Cariler");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Durumu).HasColumnName("Durumu");
            builder.Property(p => p.CariTuru).HasColumnName("CariTuru");
            builder.Property(p => p.CariKodu).HasColumnName("CariKodu");
            builder.Property(p => p.CariAdi).HasColumnName("CariAdi");
            builder.Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            builder.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            builder.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            builder.Property(p => p.Telefon).HasColumnName("Telefon");
            builder.Property(p => p.Fax).HasColumnName("Fax");
            builder.Property(p => p.EMail).HasColumnName("EMail");
            builder.Property(p => p.Il).HasColumnName("Il");
            builder.Property(p => p.Ilce).HasColumnName("Ilce");
            builder.Property(p => p.Semt).HasColumnName("Semt");
            builder.Property(p => p.Adres).HasColumnName("Adres");
            builder.Property(p => p.CariGrubu).HasColumnName("CariGrubu");
            builder.Property(p => p.CariAltGrubu).HasColumnName("CariAltGrubu");
            builder.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            builder.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            builder.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            builder.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            builder.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            builder.Property(p => p.VergiNo).HasColumnName("VergiNo");
            builder.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            builder.Property(p => p.RiskLimiti).HasColumnName("RiskLimiti");
            builder.Property(p => p.AlisOzelFiyati).HasColumnName("AlisOzelFiyati");
            builder.Property(p => p.SatisOzelFiyati).HasColumnName("SatisOzelFiyati");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
