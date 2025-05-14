using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ServiceController(IServiceService _serviceService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _serviceService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceDto model)
        {
            await _serviceService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _serviceService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _serviceService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateServiceDto dto)
        {
            await _serviceService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
