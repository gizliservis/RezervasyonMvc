using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class RezervasyonHareket
    {
        [Key]
        public int Id { get; set; }
        public int RezervasyonId { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public int OdaId { get; set; }
        public virtual Oda Oda { get; set; }
        public int YatakSayisi { get; set; }
        public int GunSayisi { get; set; }
        public int KisiSayisi { get; set; }
        
        public decimal ToplamOdaFiyati { get; set; }


    }
}
