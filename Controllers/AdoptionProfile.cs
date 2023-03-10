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
        public IActionResult Details(int id)
        {
            AdoptionProfile adoptionProfile = new AdoptionProfile();
            if (ModelState.IsValid)
            {
                
            }

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