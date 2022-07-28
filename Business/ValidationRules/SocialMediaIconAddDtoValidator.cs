using DTO.DTOs.SocailMediaIconDtos;
using FluentValidation;

namespace Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconsAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Ikon boş bırakılamaz");
        }
    }
}
