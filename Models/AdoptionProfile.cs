using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public int Id { get; set; }
        public Cat Cat { get; set; }
        public Cat.Animals Name { get; set; }
        public Cat.Animals.Attributes Attributes{ get; set; }


        public AdoptionProfile()
        {
        }
        public AdoptionProfile(int id, Cat cat, )
        {
            Id = id;
            this.Cat = cat;
            

        }
    }