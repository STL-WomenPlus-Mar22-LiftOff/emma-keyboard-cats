using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public int Id { get; set; }

        public Cat Cat { get; set; }

        public AdoptionProfile()
        {
        }
        public AdoptionProfile(int id, Cat cat)
        {
            Id = id;
            Cat = cat;
        }
    }
}