using BabyCareProject.Services.InformationServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterInformationViewComponent")]

    public class FooterInformationViewComponent(IInformationService _informationService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _informationService.GetAllAsync();
            return View(values);
        }
    }
}
