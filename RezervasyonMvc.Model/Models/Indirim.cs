using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class Indirim
    {
        [Key]
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string Barkod { get; set; }
        public string StokAdi { get; set; }
        public string IndirimTuru { get; set; }
        public Nullable<DateTime> BaslangicTarihi { get; set; }
        public Nullable<DateTime> BitisTarihi { get; set; }
        public decimal IndirimOrani { get; set; }
        public string Aciklama { get; set; }
    }
}
