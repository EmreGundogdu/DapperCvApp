using DTO.DTOs.SocailMediaIconDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconsUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş bırakılamaz");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Ikon boş bırakılamaz");
        }
    }
}
