using BabyCareProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "AboutViewComponent")]
    public class AboutViewComponent(IAboutService _aboutService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAsync();
            return View(values);
        }
    }
}
