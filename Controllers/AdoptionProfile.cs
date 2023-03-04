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
            //Cat catObj = context.Cats.Where(c => catObj)
            //Cat catList = catObj.AnimalsList.Find(Cat, catObj.id)

            //AdoptionProfile profile = context.Cats.animalsList
            //    .Find(cat => cat.Id == id)
                
            //    .FirstOrDefault();
            


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