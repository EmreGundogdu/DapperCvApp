using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.SkillDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class SkillController:Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericService<Skill> _genericService;
        public SkillController(IGenericService<Skill> genericService,IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        
            
        
        public IActionResult Index()
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<SkillListDto>(_genericService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["active"] = "yetenek";
            return View(new SkillAddDto());
        }
        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Skill>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            TempData["active"] = "hobi";
            var deletedEntity = _genericService.GetById(id);
            _genericService.Delete(deletedEntity);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            TempData["active"] = "yetenek";
            return View(_mapper.Map<SkillUpdateDto>(_genericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "yetenek";
            if (ModelState.IsValid)
            {
                var data = _genericService.GetById(model.Id);
                data.Description = model.Description;
                _genericService.Update(data);
                TempData["message"] = "Güncelleme işlemi başarılı.";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
