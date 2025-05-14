using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.SubscribeDtos;
using BabyCareProject.Services.SubscribeServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SubscribeController(ISubscribeService _subscribeService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _subscribeService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSubscribeDto model)
        {
            await _subscribeService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _subscribeService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _subscribeService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateSubscribeDto dto)
        {
            await _subscribeService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
