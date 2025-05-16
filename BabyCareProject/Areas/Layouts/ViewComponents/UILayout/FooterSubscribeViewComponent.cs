using BabyCareProject.Services.SubscribeServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterSubscribeViewComponent")]

    public class FooterSubscribeViewComponent(ISubscribeService _subscribeService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
