using Keyboard_Cats.Data;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Keyboard_Cats.Models.Cat;

namespace Keyboard_Cats.Controllers
{
    public class AdoptionProfileController : Controller
    {
        private Keyboard_CatsContext context;

        public AdoptionProfileController(Keyboard_CatsContext dbContext)
        {
            context = dbContext;
        }

        //display information for each cat profile
        [HttpGet]
        [Route("/adoptionprofile/")]
        public IActionResult Details(int id)
        {
            
            AdoptionProfile profile = context.Animals.
                Where(a => a.Id == id)
                .Include(context=> context.Animals)
                .FirstOrDefault();
            
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