using DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AppuserPasswordDtoValidator : AbstractValidator<AppUserPasswordDto>
    {
        public AppuserPasswordDtoValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parola tekrarı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Parole ve parola tekrarı alanları uyuşmuyor");
        }
    }
}
