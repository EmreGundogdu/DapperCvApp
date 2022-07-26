﻿using Business.Interfaces;
using DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
            TempData["active"] = "Bilgilerim";
            var user = _appUserService.FindByName(User.Identity.Name);
            var appUserUpdateModel = new AppUserUpdateModel
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
            return View(appUserUpdateModel);
        }
        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "Bilgilerim";
            var updateAppUser = _appUserService.GetById(model.Id);
            if (model.Picture != null)
            {
                var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;
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
            TempData["message"] = "İşleminiz başarıyla gerçekleşti.";
            return RedirectToAction("Index");
        }
        public IActionResult ChangePassword()
        {
            var user = _appUserService.FindByName(User.Identity.Name);
            TempData["active"] = "Sifre";
            return View(new AppUserPasswordDto
            {
                Id = user.Id
            });
        }
        [HttpPost]
        public IActionResult ChangePassword(AppUserPasswordDto model)
        {
            TempData["active"] = "Sifre";
            if (ModelState.IsValid)
            {
                var updatedUser = _appUserService.FindByName(User.Identity.Name);
                updatedUser.Password = model.Password;
                _appUserService.Update(updatedUser);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return View(model);
        }
    }
}
