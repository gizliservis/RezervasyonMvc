using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class Oda
    {
        [Key]
        public int Id { get; set; }
        public string OdaNo { get; set; }
        public int OdaKapasite { get; set; }
        public int YatakSayısı { get; set; }
        public ICollection<RezervasyonHareket> RezervasyonHareketleri { get; set; }
        public decimal OdaFiyat { get; set; }
        public bool Rezerve { get; set; }

    }
}
