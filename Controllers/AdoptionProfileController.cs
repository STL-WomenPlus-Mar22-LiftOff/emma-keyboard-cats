using Microsoft.AspNetCore.Mvc;

namespace Keyboard_Cats.Controllers
{
    public class AdoptionProfileController : Controller
    {
        [HttpGet]
        [Route("/adoptionprofile/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
