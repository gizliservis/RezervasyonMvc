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
    public class PersonelMap : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Unvani).HasMaxLength(15);
            builder.Property(p => p.PersonelKodu).HasMaxLength(12);
            builder.Property(p => p.PersonelAdi).HasMaxLength(50);
            builder.Property(p => p.TcKimlikNo).HasMaxLength(11);
            builder.Property(p => p.CepTelefonu).HasMaxLength(20);
            builder.Property(p => p.Telefon).HasMaxLength(20);
            builder.Property(p => p.Fax).HasMaxLength(20);
            builder.Property(p => p.EMail).HasMaxLength(50);
            builder.Property(p => p.Web).HasMaxLength(50);
            builder.Property(p => p.Il).HasMaxLength(20);
            builder.Property(p => p.Ilce).HasMaxLength(20);
            builder.Property(p => p.Semt).HasMaxLength(20);
            builder.Property(p => p.Adres).HasMaxLength(100);
            builder.Property(p => p.VergiDairesi).HasMaxLength(30);
            builder.Property(p => p.VergiNo).HasMaxLength(15);
            builder.Property(p => p.PrimOrani).HasPrecision(5, 2);
            builder.Property(p => p.AylikMaasi).HasPrecision(12, 2);
            builder.Property(p => p.Aciklama).HasMaxLength(200);

            builder.ToTable("Personeller");
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Calisiyor).HasColumnName("Calisiyor");
            builder.Property(p => p.Unvani).HasColumnName("Unvani");
            builder.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            builder.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            builder.Property(p => p.TcKimlikNo).HasColumnName("TcKimlikNo");
            builder.Property(p => p.IseGirisTarihi).HasColumnName("IseGirisTarihi");
            builder.Property(p => p.IstenCikisTarihi).HasColumnName("IstenCikisTarihi");
            builder.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            builder.Property(p => p.Telefon).HasColumnName("Telefon");
            builder.Property(p => p.Fax).HasColumnName("Fax");
            builder.Property(p => p.EMail).HasColumnName("EMail");
            builder.Property(p => p.Web).HasColumnName("Web");
            builder.Property(p => p.Il).HasColumnName("Il");
            builder.Property(p => p.Ilce).HasColumnName("Ilce");
            builder.Property(p => p.Semt).HasColumnName("Semt");
            builder.Property(p => p.Adres).HasColumnName("Adres");
            builder.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            builder.Property(p => p.VergiNo).HasColumnName("VergiNo");
            builder.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            builder.Property(p => p.AylikMaasi).HasColumnName("AylikMaasi");
            builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
