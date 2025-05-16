using BabyCareProject.Dtos.SubscribeDtos;
using BabyCareProject.Services.SubscribeServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class UILayoutController(ISubscribeService _subscribeService) : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSubscriber(CreateSubscribeDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { success = false, message = "Lütfen geçerli bir e-posta adresi girin." });
            }
            try
            {
                await _subscribeService.CreateAsync(model);
                return Ok(new { success = true, message = "Abonelik isteğiniz alındı!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = "Abonelik sırasında bir hata oluştu. Lütfen daha sonra tekrar deneyin." });
            }
        }
    }
}
