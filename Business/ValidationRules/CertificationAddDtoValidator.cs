using DTO.DTOs.CertificationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CertificationAddDtoValidator : AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
