using FluentValidation;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Business.ValidationRules
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(p => p.MusteriAdi).NotEmpty().WithMessage("Müşteri Adı Alanı Boş Geçilemez.").MaximumLength(50).WithMessage("Adı Alanı En Fazla 50 Karekter olamalıdır");
            RuleFor(p => p.MusteriSoyadi).NotEmpty().WithMessage("Müşteri SoyAdı Alanı Boş Geçilemez.");
            RuleFor(p => p.TcNo).NotEmpty().WithMessage("Tc No Alanı Boş Geçilemez.");
        }
    }
}
