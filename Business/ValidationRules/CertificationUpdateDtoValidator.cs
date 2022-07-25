using DTO.DTOs.CertificationDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CertificationUpdateDtoValidator : AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
