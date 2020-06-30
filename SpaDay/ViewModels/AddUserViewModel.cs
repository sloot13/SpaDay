using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "username must be 5 to 15 characters.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "password must be 6 to 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "verify password is required.")]
        [Compare("Password", ErrorMessage = "passwords don't match")] //BONUS
        public string VerifyPassword { get; set; }
    }
}
