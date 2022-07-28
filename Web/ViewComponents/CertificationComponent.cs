using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.CertificationDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class CertificationComponent:ViewComponent
    {
        private readonly IGenericService<Certification> _genService;
        private readonly IMapper _mapper;
        public CertificationComponent(IGenericService<Certification> appUserService, IMapper mapper)
        {
            _genService = appUserService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<CertificationListDto>(_genService.GetAll));
        }
    }
}
