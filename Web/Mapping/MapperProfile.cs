using AutoMapper;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.EducationDtos;
using DTO.DTOs.ExperienceDtos;
using DTO.DTOs.InterestDtos;
using DTO.DTOs.SkillDtos;
using DTO.DTOs.SocailMediaIconDtos;
using Entities.Concrete;

namespace Web.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>().ReverseMap();
            CreateMap<Certification, CertificationListDto>().ReverseMap();
            CreateMap<Certification, CertificationAddDto>().ReverseMap();
            CreateMap<Certification, CertificationUpdateDto>().ReverseMap();
            CreateMap<Education, EducationListDto>().ReverseMap();
            CreateMap<Education, EducationAddDto>().ReverseMap();
            CreateMap<Education, EducationUpdateDto>().ReverseMap();
            CreateMap<Experiences, ExperienceAddDto>().ReverseMap();
            CreateMap<Experiences, ExperienceListDto>().ReverseMap();
            CreateMap<Experiences, ExperienceUpdateDto>().ReverseMap();
            CreateMap<Skill, SkillAddDto>().ReverseMap();
            CreateMap<Skill, SkillUpdateDto>().ReverseMap();
            CreateMap<Skill, SkillListDto>().ReverseMap();
            CreateMap<Interest, InterestListDto>().ReverseMap();
            CreateMap<Interest, InterestAddDto>().ReverseMap();
            CreateMap<Interest, InterestUpdateDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconsUpdateDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconsListDto>().ReverseMap();
            CreateMap<SocialMediaIcon, SocialMediaIconsAddDto>().ReverseMap();
        }
    }
}
