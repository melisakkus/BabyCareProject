using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "ProductViewComponent")]
    public class ProductViewComponent(IProductService _productService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllAsync();
            return View(values);
        }

    }
}
