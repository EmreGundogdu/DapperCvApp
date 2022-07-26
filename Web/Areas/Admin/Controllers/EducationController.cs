using AutoMapper;
using DataAccess.Interfaces;
using DTO.DTOs.EducationDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class EducationController : Controller
    {
        private readonly IGenericRepository<Education> _educationGenericService;
        private readonly IMapper _mapper;
        public EducationController(IGenericRepository<Education> educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }
        [Area("Admin")]
        [Authorize]
        public IActionResult Index()
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<List<EducationListDto>>(_educationGenericService.GetAll()));
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "egitim";
            var deletedEntity = _educationGenericService.GetById(id);
            _educationGenericService.Delete(deletedEntity);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            TempData["active"] = "egitim";
            return View(new EducationAddDto());
        }
        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "egitim";
            if (ModelState.IsValid)
            {
                _educationGenericService.Insert(_mapper.Map<Education>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "egitim";
            return View(_mapper.Map<Education>(_educationGenericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var data = _educationGenericService.GetById(model.Id);
                data.StartDate = model.StartDate;
                data.EndDate = model.EndDate;
                data.Title = model.Title;
                data.SubTitle = model.SubTitle;
                data.Description = model.Description;
                _educationGenericService.Update(data);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
