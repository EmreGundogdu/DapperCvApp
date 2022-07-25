using DTO.DTOs.ExperienceDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class ExperienceAddDtoValidator : AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama tarihi boş bırakılamaz");

        }
    }
}
