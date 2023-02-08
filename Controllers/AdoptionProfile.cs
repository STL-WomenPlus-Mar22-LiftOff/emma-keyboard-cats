using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        //method for saving favorited cats to user database?

        /*public IActionResult AddFavorite()
        {
            Favorites.Add(new Cat());

            return View();
        }*/
    }
}
