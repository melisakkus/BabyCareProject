using BabyCareProject.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "BannerViewComponent")]
    public class BannerViewComponent(IBannerService _bannerService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetAllAsync();
            return View(values);
        }
    }
}
