using Keyboard_Cats.Models;
using Keyboard_Cats.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Keyboard_Cats.Controllers
{
    public class AdoptionProfileController : Controller
    {
        private readonly Keyboard_CatsContext context;

        public AdoptionProfileController(Keyboard_CatsContext dbContext)
        {
            context = dbContext;
        }

        //display profile for each cat
        [HttpGet]
        [Route("/adoptionprofile/{id}")]
        public IActionResult Index(int id)
        {
            Cat cat = (Cat)context.Cats.Where(c => c.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            AdoptionProfile adoptionProfile = new AdoptionProfile()
            {
                Id = Cat.Id
            };
            

            return View(adoptionProfile);
        }
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