using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.SocailMediaIconDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialMediaIconController : Controller
    {
        private readonly IAppUserService _service;
        private readonly ISocialMediaIconService _smiservice;
        private readonly IMapper _mapper;
        public SocialMediaIconController(IAppUserService service, ISocialMediaIconService smiservice, IMapper mapper)
        {
            _service = service;
            _smiservice = smiservice;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "ikon";
            var user = _service.FindByName(User.Identity.Name);
            return View(_mapper.Map<SocialMediaIcon>(_smiservice.GetByUserId(user.Id)));
        }
        public IActionResult Add()
        {
            return View(new SocialMediaIconsAddDto());
        }
        [HttpPost]
        public IActionResult Add(SocialMediaIconsAddDto model)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _service.FindByName(User.Identity.Name);
                model.AppUserId = user.Id;
                _smiservice.Insert(_mapper.Map<SocialMediaIcon>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "ikon";
            return View(_mapper.Map<SocialMediaIconsUpdateDto>(_smiservice.GetById(id)));
        }
        [HttpPost]
        public IActionResult Updat(SocialMediaIconsUpdateDto model)
        {
            TempData["active"] = "ikon";
            if (ModelState.IsValid)
            {
                var user = _service.FindByName(User.Identity.Name);
                var data = _smiservice.GetById(user.Id);
                data.AppUserId = model.Id;
                data.Icon = model.Icon;
                data.Link = model.Link;
                _smiservice.Update(data);
                TempData["message"] = "Güncelleme işlemi başarılı"
            }
            return View(model);
        }
    }
}
