using Keyboard_Cats.Data;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keyboard_Cats.Controllers
{
    public class AdoptionProfileController : Controller
    {
        private CatDbContext context;

        public AdoptionProfileController(CatDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        [Route("/adoptionprofile/")]
        public IActionResult Index(Cat Id)
        {
            Cat cat = context.Cats
                .include
            return View();
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