using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.InterestDtos;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class InterestController : Controller
    {
        private readonly IGenericService<Interest> _genericService;
        private readonly IMapper _mapper;

        public InterestController(IGenericService<Interest> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["active"] = "hobi";
            return View(_mapper.Map<InterestListDto>(_genericService.GetAll()));
        }
        public IActionResult Add()
        {
            TempData["active"] = "hobi";
            return View(new InterestAddDto());
        }
        [HttpPost]
        public IActionResult Add(InterestAddDto model)
        {
            TempData["active"] = "hobi";
            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Interest>(model));
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
            TempData["active"] = "sertifika";
            return View(_mapper.Map<InterestUpdateDto>(_genericService.GetById(id)));
        }
        [HttpPost]
        public IActionResult Update(InterestUpdateDto model)
        {
            TempData["active"] = "hobi";
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
