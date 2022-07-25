using DTO.DTOs.SkillDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDo>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
        }
    }
}
