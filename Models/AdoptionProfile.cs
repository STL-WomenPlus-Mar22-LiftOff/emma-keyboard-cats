using static Keyboard_Cats.Models.Cat;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public string Name { get; set; }



        public AdoptionProfile(Animals cat)
        {
            Name = cat.Name;
        }

        public AdoptionProfile()
        {
        }
    }
}
