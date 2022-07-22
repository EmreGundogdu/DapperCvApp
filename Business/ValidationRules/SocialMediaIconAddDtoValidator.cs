using DTO.DTOs.SocailMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconsAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(x => x.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId alanı boş bırakılamaz");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("Ikon boş bırakılamaz");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Ikon boş bırakılamaz");
        }
    }
}
