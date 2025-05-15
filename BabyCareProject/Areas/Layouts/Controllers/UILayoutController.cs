using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class UILayoutController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
