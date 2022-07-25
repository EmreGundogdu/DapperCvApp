using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.CertificationDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _certificationGenericService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> certificationGenericService, IMapper mapper)
        {
            _certificationGenericService = certificationGenericService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["active"] = "sertifika";
            return View(_mapper.Map<List<CertificationListDto>>(_certificationGenericService.GetAll()));
        }
    }
}
