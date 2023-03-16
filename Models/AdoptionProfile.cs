using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public int Id { get; set; }

        public Cat.CatEntity Cat { get; set; }


        public AdoptionProfile()
        {
        }
        public AdoptionProfile(int id, Cat.CatEntity cat)
        {
            Id = id;
            Cat = cat;
        }
        public override bool Equals(object obj) 
        {
            return obj is AdoptionProfile @adoptionProfile &&
                Id == adoptionProfile.Id;
        }
        /*public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }*/
    }
}