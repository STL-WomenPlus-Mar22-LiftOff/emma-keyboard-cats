using Microsoft.AspNetCore.Mvc;

namespace Keyboard_Cats.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
