using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
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
            await _bannerService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }

    }
}
