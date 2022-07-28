using DTO.DTOs.SkillDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
        }
    }
}
