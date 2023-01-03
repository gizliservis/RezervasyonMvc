using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class HizliSatis
    {
        [Key]
        public int Id { get; set; }
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public int GrupId { get; set; }
    }
}
