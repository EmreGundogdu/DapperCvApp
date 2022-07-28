using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class SkillComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
