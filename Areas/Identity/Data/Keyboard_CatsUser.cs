using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Keyboard_Cats.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Keyboard_CatsUser class
public class Keyboard_CatsUser : IdentityUser
{  /* public string Username { get; set; }*/
    //public string Email { get; set; }
    //public string Password { get; set; }
    
}
public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    [Required]
    public int Zipcode { get; set; }
    public string? Address { get; set; }
}

//Add public list of user's favorited adoptable cats
//public List<Cat> Favorites { get; set; }