using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public int Id { get; set; }



        public AdoptionProfile()
        {
        }
        public AdoptionProfile(int id)
        {
            Id = id;

        }
    }
}