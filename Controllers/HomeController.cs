using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.DotNet.MSIdentity.Shared;
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


        [Route("/Guest")]
        public IActionResult Guest()
        {
            return View();
        }

        [Route("/CatGallery")]
        
        public async Task<IActionResult> CatGallery(string CatResponse)
        { 
            //HttpClient should be instantiated once and not be disposed 
            HttpClient client = new HttpClient();

            // Api credientials 
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
            
                List<Cat> catInfo = new List<Cat>();

             
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authInfo.access_token);


           
               HttpResponseMessage Res = await client.GetAsync("https://api.petfinder.com/v2/animals?type=cat");
                if (Res.IsSuccessStatusCode)
                {

                
                _ = Res.Content.ReadAsStringAsync().Result;
             
                   
                    Console.WriteLine("Success");

                } 
                Console.WriteLine(catInfo); 


       

            return View(catInfo);
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}