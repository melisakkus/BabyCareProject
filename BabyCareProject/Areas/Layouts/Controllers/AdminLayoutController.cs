using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class AdminLayoutController() : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
