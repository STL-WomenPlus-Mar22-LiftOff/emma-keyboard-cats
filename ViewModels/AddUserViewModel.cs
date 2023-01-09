using System.ComponentModel.DataAnnotations;

namespace Keyboard_Cats.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "User Name must be between 4 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be at between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please verify password.")]
        public string VerifyPassword { get; set; }

        
    }
}
