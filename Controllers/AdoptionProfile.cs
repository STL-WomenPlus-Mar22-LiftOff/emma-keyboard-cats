using Keyboard_Cats.Models;
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
            AdoptionProfile profile = new AdoptionProfile();

            // foreach cat(img) in cat gallery, display adoption profile view model?
            foreach (var cat in ViewBag.CatImageLink)
            {
                
            }
                
            return View(profile);
        }
        /*
        


        //method for saving favorited cats to user database

        public IActionResult AddFavorite()
        {
            Favorites.Add(new Cat());

            return View();
        }*/
    }
}