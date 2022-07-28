using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.SkillDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class SkillComponent : ViewComponent
    {
        IMapper _mapper;
        IGenericService<Skill> _genservice;

        public SkillComponent(IMapper mapper, IGenericService<Skill> genservice)
        {
            _mapper = mapper;
            _genservice = genservice;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_genservice.GetAll()));
        }
    }
}
