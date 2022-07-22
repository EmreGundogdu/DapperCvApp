using Business.Interfaces;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Skill> _skillManager;

        public HomeController(IGenericService<Skill> skillManager)
        {
            _skillManager = skillManager;
        }

        public IActionResult Index()
        {
            return View(_skillManager.GetAll());
        }
    }
}