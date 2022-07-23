using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
