using AutoMapper;
using Business.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ExperienceController : Controller
    {
        private readonly IGenericService<Experiences> _genericService;
        private readonly IMapper _mapper;
        public ExperienceController(IGenericService<Experiences> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "deneyim";
            return View();
        }
    }
}
