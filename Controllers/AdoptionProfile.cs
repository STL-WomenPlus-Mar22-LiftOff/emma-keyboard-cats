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

        //display information for each cat profile
        [HttpGet]
        [Route("/adoptionprofile/")]
        public IActionResult Index(int id)
        {
            AdoptionProfile adoptionProfile = context.Cats.FirstOrDefault(c => c.Id == id);
            if (adoptionProfile == null)
            {
                return NotFound();
            }
                return View(adoptionProfile);
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