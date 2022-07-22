using DTO.DTOs.SocailMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconsUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
            RuleFor(x => x.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("AppUserId alanı boş bırakılamaz");
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş bırakılamaz");
        }
    }
}
