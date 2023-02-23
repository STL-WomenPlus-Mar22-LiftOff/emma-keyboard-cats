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
        private CatDbContext context;

        public AdoptionProfileController(CatDbContext dbContext)
        {
            context = dbContext;
        }

        //display information for each cat profile
        [HttpGet]
        [Route("/adoptionprofile/")]
        public IActionResult Index(int id)
        {
            Cat cat = context.Cats
                .Include(c => c.name)
                .Include(c => c.Description)
                .Single(context => context.Id == id);
            return View(cat);
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