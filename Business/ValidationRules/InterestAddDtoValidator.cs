using DTO.DTOs.InterestDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class InterestAddDtoValidator : AbstractValidator<InterestUpdateDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

        }
    }
}
