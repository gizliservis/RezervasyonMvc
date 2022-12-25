using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class Rezervasyon
    {
        [Key]
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
        public ICollection<RezervasyonHareket> RezervasyonHareketleri { get; set; }
        public DateTime GrisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int OdaSayisi { get; set; }
        public int KisiSayisi { get; set; }
        public decimal RezToplamTutar { get; set; }
    }
}
