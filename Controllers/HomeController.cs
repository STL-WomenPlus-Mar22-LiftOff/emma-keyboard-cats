﻿using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Keyboard_Cats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [Route("/Guest")]
        public IActionResult Guest()
        {
            return View();
        }

        [Route("/CatGallery")]
        public IActionResult CatGallery()
        {
            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("/RegisteredUser")]
        public IActionResult RegisteredUser()
        {
            return View();
        }
    }
}