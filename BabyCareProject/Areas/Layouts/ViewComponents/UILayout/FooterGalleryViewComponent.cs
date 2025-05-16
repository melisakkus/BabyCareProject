using BabyCareProject.Services.GalleryServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "FooterGalleryViewComponent")]

    public class FooterGalleryViewComponent(IGalleryService _galleryService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _galleryService.GetAllAsync();
            return View(values);
        }
    }
}
