using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public async IAsyncEnumerable<T> CatGallery()
        {
            string Baseurl = "api.petfinder.com/v2";
            List<Cat> catInfo = new List<Cat>();

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(Baseurl);
            httpClient.DefaultRequestHeaders.Clear();
            HttpResponseMessage Res = await httpClient.GetAsync("animals?type=cat?location=62208");
            if (Res.IsSuccessStatusCode)
            {
                var CatResponse = Res.Content.ReadAsStringAsync().Result;
                catInfo = JsonConvert.DeserializeObject<List<Cat>>(CatResponse);
            }

            Console.WriteLine(catInfo);
    
            return View();
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}