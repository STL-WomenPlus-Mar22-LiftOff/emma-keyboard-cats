using static Keyboard_Cats.Models.Cat;
using System;

namespace Keyboard_Cats.Models
{
    public class AdoptionProfile { 
 
     public int Id { get; set; }

     public Cat? Cat { get; set; }

    public int CatId { get; set; }  

    public AdoptionProfile()
        {
        }
    public AdoptionProfile(int id, Cat cat)
        {
            Id = id;
            Cat = cat;
    
    }
}