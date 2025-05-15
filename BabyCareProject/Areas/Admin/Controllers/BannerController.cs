using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Services.BannerServices;
using BabyCareProject.Services.ImageServices;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService, IImageService _imageService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto model)
        {
            if (model.ImageFile != null)
            {
                model.ImageUrl = await _imageService.UploadImageAsync(model.ImageFile);
            }
            await _bannerService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _bannerService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _bannerService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto dto)
        {
            if (dto.ImageFile != null)
            {
                dto.ImageUrl = await _imageService.UploadImageAsync(dto.ImageFile);
            }
            await _bannerService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }

    }
}
