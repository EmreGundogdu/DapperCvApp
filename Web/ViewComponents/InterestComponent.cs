using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class InterestComponent : ViewComponent
    {
        private readonly IGenericService<Interest> _genService;
        private readonly IMapper _mapper;

        public InterestComponent(IGenericService<Interest> genService, IMapper mapper)
        {
            _genService = genService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<Interest>>(_genService.GetAll()));
        }
    }
}
