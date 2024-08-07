using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspNetRazorLear23.Models
{
    public class SignInViewModel
    {
        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [DisplayName("Password")]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; } = null!;

        [DisplayName("Remember me")]
        public bool RememberMe { get; set; } = false;
    }
}
