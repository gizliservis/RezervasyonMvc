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
    internal class OdaMap : IEntityTypeConfiguration<Oda>
    {
        public void Configure(EntityTypeBuilder<Oda> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.OdaNo).HasMaxLength(20);
            builder.Property(p => p.OdaFiyat).HasPrecision(12, 2);

            builder.ToTable("Odalar");
            builder.Property(c=>c.Id).HasColumnName("Id");
            builder.Property(c=>c.OdaNo).HasColumnName("OdaNo");
            builder.Property(c=>c.OdaKapasite).HasColumnName("OdaKapasite");
            builder.Property(c=>c.YatakSayısı).HasColumnName("YatakSayısı");
            builder.Property(c=>c.OdaFiyat).HasColumnName("OdaFiyat");
        }
    }
}
