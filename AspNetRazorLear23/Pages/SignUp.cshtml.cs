
using AspNetRazorLear23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AspNetRazorLear23.Pages
{
    public class SignUpModel : PageModel
    {

        [BindProperty]
        public SignUpFormModel Form { get; set; } = new SignUpFormModel();


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
