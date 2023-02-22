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
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _config;


        public HomeController(ILogger<HomeController> logger , IConfiguration config)
        {
            _logger = logger;
            _config = config;
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
       
        public async Task<IActionResult> CatGallery(string CatResponse)
        { 
            //HttpClient should be instantiated once and not be disposed 
            HttpClient client = new HttpClient();

            // Api credentials 
            var values = new Dictionary<string, string>
        {
            { "grant_type", "client_credentials" },
            { "client_id", _config["PetFinder:ApiKey"] },
            { "client_secret", _config["PetFinder:Secret"] }
            
        };
            
            // FormUrlEncodedContent transforms values to UTF encoding to be read by the server
            var content = new FormUrlEncodedContent(values);

            // AuthResponse gets information about the accepted OAuth connection
            AuthResponse authInfo = new AuthResponse();

            //POST the object to the specified URI 

            var response = await client.PostAsync("https://api.petfinder.com/v2/oauth2/token", content);

            if (response.IsSuccessStatusCode)
            {
                // responseString holds bearer key information
                var responseString = await response.Content.ReadAsStringAsync();
                // Converting bearer key information into AuthResponse objects
                authInfo = JsonConvert.DeserializeObject<AuthResponse>(responseString);
                Console.WriteLine("Success");
            }


            string catInfo = "";
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authInfo.access_token);
           
              // HttpResponseMessage Res = await client.GetAsync("https://api.petfinder.com/v2/animals?type=cat");


              var Res = await client.GetAsync("https://api.petfinder.com/v2/animals?type=cat");


            if (Res.IsSuccessStatusCode)
                {
                catInfo = Res.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("Success");
            }

            Cat cats = JsonConvert.DeserializeObject<Cat>(catInfo);
            /*for (int i = 0; i <= cats.AnimalsList.Count; i++)
            {
                if (cats.AnimalsList.Count != null)
                ViewBag.id = cats.AnimalsList[i].Id.ToString();
                ViewBag.name = cats.AnimalsList[i].Name.ToString();
               // ViewBag.description = cats.AnimalsList[i].Description.ToString();
                ViewBag.photos = cats.AnimalsList[i].PhotosList.ToString();
            } */

            //call the variable outside of the foreach statemetn so it can be used in viewbag.
            List<string> images = new List<string>();
            //Loop through the animal list to find property you are looking for
            foreach (var cat in cats.AnimalsList)
            {

                //to make sure it doesn't break from being null
                if (cat.PhotosList.Count > 0)
                {
                    // ViewBag.CatImageLink = cats?.AnimalsList[0]?.PhotosList[0]?.Small?.ToString() ?? string.Empty;

                    //the exact properties you are using will go here.
                    images.Add(cat.PhotosList[0].Medium.ToString());
                    
                   
                }
               
            }
            //to be able to pull the api into the view
            ViewBag.CatImageLink = images;
            return View(cats);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}