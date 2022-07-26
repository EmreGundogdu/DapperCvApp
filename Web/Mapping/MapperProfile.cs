using AutoMapper;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.EducationDtos;
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
        }
    }
}
