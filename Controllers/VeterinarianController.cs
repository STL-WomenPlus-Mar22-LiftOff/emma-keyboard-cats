using Microsoft.AspNetCore.Mvc;

namespace Keyboard_Cats.Controllers
{
    public class VeterinarianController : Controller
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
                Location = new Location(37.7749, -122.4194) // San Francisco, CA
            };

            var response = await service.Search.QueryAsync(request);

            var viewModel = new VeterinarianSearchViewModel
            {
                Query = query,
                Results = response.Results
            };

            return View(viewModel);
        }

    };

}
