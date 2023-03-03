using System;
using Keyboard_Cats.Models;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile
    {
        public int Id { get; set; }
        public Cat Cat { get; set; }
        public Cat Name { get; set; }
        public Cat Description { get; set; }    
        public Cat Attributes{ get; set; }
        public Cat Contact { get; set; }    
        public Cat Environment { get; set; }
        
        public Cat.Animals Photos Medium { get; set; }


        public AdoptionProfile()
        {
        }
        public AdoptionProfile(int id, Cat cat, )
        {
            Id = id;
            this.Cat = cat;
            

        }
    }