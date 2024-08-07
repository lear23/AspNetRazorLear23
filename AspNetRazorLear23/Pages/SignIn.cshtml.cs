using AspNetRazorLear23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRazorLear23.Pages
{
    public class SignInModel : PageModel
    {

        [BindProperty]
        public SignInViewModel FormIn { get; set; } = new SignInViewModel();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                 return Page();
            }
            return RedirectToPage("/index");
        }
    }
}
