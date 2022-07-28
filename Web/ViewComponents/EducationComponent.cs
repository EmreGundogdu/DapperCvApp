using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.EducationDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genService;
        private readonly IMapper _mapper;

        public EducationComponent(IGenericService<Education> genService, IMapper mapper)
        {
            _genService = genService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_genService.GetAll()));
        }
    }
}
