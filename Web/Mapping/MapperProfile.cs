using AutoMapper;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using Entities.Concrete;

namespace Web.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>().ReverseMap();
            CreateMap<Certification, CertificationListDto>().ReverseMap();
        }
    }
}
