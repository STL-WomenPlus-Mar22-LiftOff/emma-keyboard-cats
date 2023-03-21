using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Keyboard_Cats.Data;
using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Controllers
{
    public class HomeController : Controller
    {
        private Keyboard_CatsContext context;
        public HomeController(Keyboard_CatsContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Route("/Guest")]
        public IActionResult Guest()
        {
            return View();
        }
        [Route("/CatVideoGenerator")]
        public IActionResult CatVideoGenerator()
        {
            return View();
        }

        [Route("/CatGallery")]
        public IActionResult CatGallery()
        {
            List<Cat.CatEntity> cats = context.Cats.ToList();
            return View(cats);
        }
    }
}


