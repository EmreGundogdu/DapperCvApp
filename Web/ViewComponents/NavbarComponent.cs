using AutoMapper;
using Business.Interfaces;
using DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class NavbarComponent : ViewComponent
    {
        private readonly IAppUserService _appService;
        private readonly IMapper mapper;
        public NavbarComponent(IAppUserService appService, IMapper mapper)
        {
            _appService = appService;
            this.mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(mapper.Map<AppUserListDto>(_appService.GetById(1));
        }
    }
}
