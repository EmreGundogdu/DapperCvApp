using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.ExperienceDtos;
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
            return View(_mapper.Map<List<ExperienceListDto>>(_genericService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["message"] = "deneyim";
            return View(new ExperienceAddDto());
        }
        [HttpPost]
        public IActionResult Add(ExperienceAddDto model)
        {
            TempData["message"] = "deneyim";

            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Experiences>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "deneyim";
            return View(_mapper.Map<Experiences>(_genericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(ExperienceUpdateDto model)
        {
            TempData["active"] = "deneyim";

            if (ModelState.IsValid)
            {
                var data = _genericService.GetById(model.Id);
                data.StartDate = model.StartDate;
                data.EndDate = model.EndDate;
                data.Title = model.Title;
                data.SubTitle = model.SubTitle;
                data.Description = model.Description;
                _genericService.Update(data);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "deneyim";
            var deletedEntity = _genericService.GetById(id);
            _genericService.Delete(deletedEntity);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
    }
}
