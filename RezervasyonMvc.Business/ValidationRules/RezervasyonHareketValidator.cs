using FluentValidation;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Business.ValidationRules
{
    public class RezervasyonHareketValidator:AbstractValidator<RezervasyonHareket>
    {
        public RezervasyonHareketValidator()
        {

        }
    }
}
