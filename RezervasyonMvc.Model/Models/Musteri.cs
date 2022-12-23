using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string TcNo { get; set; }
        public string Adresi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }
    }
}
