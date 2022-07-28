using Business.Concrete;
using Business.Interfaces;
using Business.ValidationRules;
using DataAccess.Concrete.Dapper;
using DataAccess.Interfaces;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.EducationDtos;
using DTO.DTOs.ExperienceDtos;
using DTO.DTOs.InterestDtos;
using DTO.DTOs.SkillDtos;
using DTO.DTOs.SocailMediaIconDtos;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Business.IOC.Microsoft
{
    public static class CustomDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("SqlConnection")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();
            services.AddScoped<IDpSocialMediaRepository, DpSocialMediaRepository>();

            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, AppuserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconsAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconsUpdateDto>, SocialMediaIconUpdateDtoValidator>();

        }
    }
}
