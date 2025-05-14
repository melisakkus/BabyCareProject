using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.InformationDtos;
using BabyCareProject.Services.InformationServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class InformationController(IInformationService _informationService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _informationService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInformationDto model)
        {
            await _informationService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _informationService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _informationService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateInformationDto dto)
        {
            await _informationService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
