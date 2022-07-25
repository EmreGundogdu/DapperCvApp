using DTO.DTOs.CertificationDtos;
using FluentValidation;

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
