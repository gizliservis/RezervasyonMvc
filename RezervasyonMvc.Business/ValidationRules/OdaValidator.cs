using FluentValidation;
using RezervasyonMvc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonMvc.Business.ValidationRules
{
    public class OdaValidator:AbstractValidator<Oda>
    {
        public OdaValidator()
        {
            RuleFor(p => p.OdaNo).NotEmpty().WithMessage("Müşteri Adı Alanı Boş Geçilemez.").MaximumLength(12).WithMessage("Adı Alanı En Fazla 50 Karekter olamalıdır");
        }
    }
}
