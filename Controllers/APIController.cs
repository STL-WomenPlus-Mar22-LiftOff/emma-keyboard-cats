using Keyboard_Cats.Data;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace Keyboard_Cats.Controllers
{
    public class APIController : ControllerBase

    {
        private Keyboard_CatsContext context;
        public APIController(Keyboard_CatsContext dbContext)
        {
            context = dbContext;
        }

        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _config;


        public APIController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }
        public async Task<IActionResult> Index(string CatResponse)
        {
            HttpClient client = new HttpClient();

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

            var Res = await client.GetAsync("https://api.petfinder.com/v2/animals?type=cat");

            if (Res.IsSuccessStatusCode)
            {
                catInfo = Res.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Success");
            }

            Cat cats = JsonConvert.DeserializeObject<Cat>(catInfo);

            //save cats to database
            var db = new Keyboard_CatsContext();
            List<Cat.CatEntity> catEntities = cats.Animals;
            db.Cats.AddRange(catEntities);
            db.SaveChanges();
            return (IActionResult)cats;
        }
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // not returning a view.... iactionresult?

    }
}
