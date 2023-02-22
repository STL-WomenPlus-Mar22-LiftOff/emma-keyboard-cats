using GooglePlacesApi.Models;
using GoogleMapsApi.Entities.PlacesDetails.Response;
using GoogleMapsApi.Entities.PlacesFind.Response;

namespace Keyboard_Cats.Models
{
    public class VetFinderSearchViewModel
    {
        public string Query { get; set; }
        public PlacesDetailsResponse Result { get; set; }
        public PlacesFindResponse Results { get; set; }
    }
}


//namespace Keyboard_Cats.Models
//{
//    public class VetFinderSearchViewModel
//    {
//        public string Query { get; set; }
//        public List<Place> Results { get; set; }

//    }
//}
