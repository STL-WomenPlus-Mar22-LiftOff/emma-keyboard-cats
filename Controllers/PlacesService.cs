using Google.Apis.Services;

namespace VetFinder.Controllers
{
    internal class PlacesService
    {
        private BaseClientService.Initializer initializer;

        public PlacesService(BaseClientService.Initializer initializer)
        {
            this.initializer = initializer;
        }
    }
}