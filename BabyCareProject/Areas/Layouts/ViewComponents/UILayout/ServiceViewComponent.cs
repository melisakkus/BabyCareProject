using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "ServiceViewComponent")]
    public class ServiceViewComponent(IServiceService _serviceService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _serviceService.GetAllAsync();
            return View(values);
        }
    }
}
