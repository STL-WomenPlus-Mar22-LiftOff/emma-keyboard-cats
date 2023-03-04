using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace Keyboard_Cats.Controllers
{
    public class HomeController : Controller
    {
        

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
            return View();
        }
        }
    }


