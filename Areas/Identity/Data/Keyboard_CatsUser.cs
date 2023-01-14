using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Keyboard_Cats.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Keyboard_CatsUser class
public class Keyboard_CatsUser : IdentityUser
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

