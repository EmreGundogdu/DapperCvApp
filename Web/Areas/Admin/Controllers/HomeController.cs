using Business.Interfaces;
using DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            var appUserListDto = new AppUserListDto
            {
                Email = user.Email,
                Address = user.Address,
                UserName = user.UserName,
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
            };
            return View(appUserListDto);
        }
    }
}
