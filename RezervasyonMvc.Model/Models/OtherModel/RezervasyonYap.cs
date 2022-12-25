using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models.OtherModel
{
    public class RezervasyonYap
    {
        public virtual Rezervasyon Rezervasyonlar { get; set; }
        public IEnumerable<RezervasyonHareket> RezervasyonHareketleri { get; set; }
        public virtual Musteri Musteriler { get; set; }
    }
}
