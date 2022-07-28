using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.ExperienceDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class ExperienceComponent : ViewComponent
    {
        private readonly IGenericService<Experiences> _genService;
        private readonly IMapper _mapper;
        public ExperienceComponent(IGenericService<Experiences> genService, IMapper mapper)
        {
            _genService = genService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_genService.GetAll()));
        }
    }
}
