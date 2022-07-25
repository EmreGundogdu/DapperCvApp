using Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IAppUserService _appUserService;

        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var user = _appUserService.FindByName(User.Identity.Name);
            var appUserListDto = new AppUserUpdateModel
            {
                FirstName = user.FirstName,
                Email = user.Email,
                Address = user.Address,
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
            };
            return View(appUserListDto);
        }
        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                var updateAppUser = _appUserService.GetById(model.Id);
                if (model.Picture != null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img" + imgName;
                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updateAppUser.ImageUrl = imgName;
                };
                updateAppUser.LastName = model.LastName;
                updateAppUser.FirstName = model.FirstName;
                updateAppUser.PhoneNumber = model.PhoneNumber;
                updateAppUser.ShortDescription = model.ShortDescription;
                updateAppUser.Address = model.Address;
                updateAppUser.Email = model.Email;
                _appUserService.Update(updateAppUser);
            };
            return View(model);
        }
    }
}
