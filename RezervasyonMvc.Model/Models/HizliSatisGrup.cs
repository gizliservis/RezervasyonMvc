﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Model.Models
{
    public class HizliSatisGrup
    {
        [Key]
        public int Id { get; set; }
        public string GrupAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
