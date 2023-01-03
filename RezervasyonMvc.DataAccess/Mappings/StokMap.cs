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
    public class StokMap : IEntityTypeConfiguration<Stok>
    {
        public void Configure(EntityTypeBuilder<Stok> builder)
        {
          
                builder.HasKey(p => p.Id);
                builder.Property(p => p.StokKodu).HasMaxLength(35);
                builder.Property(p => p.StokAdi).HasMaxLength(150);
                builder.Property(p => p.Barkod).HasMaxLength(150);
                builder.Property(p => p.BarkodTuru).HasMaxLength(15);
                builder.Property(p => p.Birimi).HasMaxLength(15);
                builder.Property(p => p.StokGrubu).HasMaxLength(50);
                builder.Property(p => p.StokAltGrubu).HasMaxLength(30);
                builder.Property(p => p.Marka).HasMaxLength(30);
                builder.Property(p => p.Modeli).HasMaxLength(30);
                builder.Property(p => p.OzelKod1).HasMaxLength(30);
                builder.Property(p => p.Gorsel).HasMaxLength(250);
                builder.Property(p => p.OzelKod2).HasMaxLength(30);
                builder.Property(p => p.OzelKod3).HasMaxLength(30);
                builder.Property(p => p.OzelKod4).HasMaxLength(30);
                builder.Property(p => p.GarantiSuresi).HasMaxLength(15);
                builder.Property(p => p.UreticiKodu).HasMaxLength(20);
                builder.Property(p => p.AlisFiyati1).HasPrecision(12, 2);
                builder.Property(p => p.AlisFiyati1).HasPrecision(12, 2);
                builder.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
                builder.Property(p => p.AlisFiyati3).HasPrecision(12, 2);
                builder.Property(p => p.SatisFiyati1).HasPrecision(12, 2);
                builder.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
                builder.Property(p => p.SatisFiyati3).HasPrecision(12, 2);
                builder.Property(p => p.MinStokMiktari).HasPrecision(12, 3);
                builder.Property(p => p.MaxStokMiktari).HasPrecision(12, 3);
                builder.Property(p => p.Aciklama).HasMaxLength(200);


                builder.ToTable("Stoklar");
                builder.Property(p => p.Id).HasColumnName("Id");
                builder.Property(p => p.Durumu).HasColumnName("Durumu");
                builder.Property(p => p.StokKodu).HasColumnName("StokKodu");
                builder.Property(p => p.StokAdi).HasColumnName("StokAdi");
                builder.Property(p => p.Barkod).HasColumnName("Barkod");
                builder.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
                builder.Property(p => p.Birimi).HasColumnName("Birimi");
                builder.Property(p => p.StokGrubu).HasColumnName("StokGrubu");
                builder.Property(p => p.StokAltGrubu).HasColumnName("StokAltGrubu");
                builder.Property(p => p.Marka).HasColumnName("Marka");
                builder.Property(p => p.Modeli).HasColumnName("Modeli");
                builder.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
                builder.Property(p => p.Gorsel).HasColumnName("Gorsel");
                builder.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
                builder.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
                builder.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
                builder.Property(p => p.GarantiSuresi).HasColumnName("GarantiSüresi");
                builder.Property(p => p.UreticiKodu).HasColumnName("UreticiKodu");
                builder.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
                builder.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
                builder.Property(p => p.AlisFiyati1).HasColumnName("AlisFiyati1");
                builder.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
                builder.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
                builder.Property(p => p.SatisFiyati1).HasColumnName("SatisFiyati1");
                builder.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
                builder.Property(p => p.SatisFiyati3).HasColumnName("SatisFiyati3");
                builder.Property(p => p.MinStokMiktari).HasColumnName("MinStokMiktari");
                builder.Property(p => p.MaxStokMiktari).HasColumnName("MaxStokMiktari");
                builder.Property(p => p.Aciklama).HasColumnName("Aciklama");
            
        }
    }
}
