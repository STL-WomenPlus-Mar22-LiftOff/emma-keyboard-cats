using Google.Apis.Services;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Mvc;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Places.Request;
using GoogleMapsApi.Entities.PlaceAutocomplete.Request;
using GooglePlacesApi.Models;
using GoogleMapsApi.Entities.Places.Response;

namespace VetFinder.Controllers
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

            var request = new PlacesRequest
            {
                Keyword = query,
                Type = "veterinary_care",
                RankBy = RankBy.Distance,
                Location = new Location(37.7749, -122.4194) // San Francisco, CA
            };

            PlacesResponse response = await service.Search.QueryAsync(request);

            var viewModel = new VetFinderSearchViewModel
            {
                Query = query,
                Results = (GoogleMapsApi.Entities.PlacesFind.Response.PlacesFindResponse)response.Results
            };

            return View(viewModel);
        }
    }
}


//namespace Keyboard_Cats.Controllers
//{
//    public class VetFinderController : Controller
//    {
//        [Route("/Index")]
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public async Task<IActionResult> Search(string query)
//        {
//            var service = new PlacesService(new BaseClientService.Initializer
//            {
//                ApiKey = "AIzaSyAl4UbaqqJVgTzAHGRWwGr3sbFvVqqYQ98"
//            });

//            var request = new PlacesSearchRequest
//            {
//                Keyword = query,
//                Type = "veterinary_care",
//                Rankby = "distance",
//                Location = new Location(37.7749, -122.4194) // San Francisco, CA
//            };

//            var response = await service.Search.QueryAsync(request);

//            var viewModel = new VetFinderSearchViewModel
//            {
//                Query = query,
//                Results = response.Results
//            };

//            return View(viewModel);
//        }

//    };

//}
