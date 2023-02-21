using Google.Apis.Services;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlacesFind.Request;

namespace Keyboard_Cats.Controllers
{
    public class VetFinderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Search(string query)
        {
            var service = new PlacesService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyAl4UbaqqJVgTzAHGRWwGr3sbFvVqqYQ98"
            });

            var request = new PlacesSearchRequest
            {
                Keyword = query,
                Type = "veterinary_care",
                Rankby = "distance",
                Location = new Location(38.6270, -90.1994) // Saint Louis, MO
            };

            var response = await service.Search.QueryAsync(request);

            var viewModel = new VetFinderSearchViewModel
            {
                Query = query,
                Results = response.Results
            };

            return View(viewModel);
        }

    };

}
