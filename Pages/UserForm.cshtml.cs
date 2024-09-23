using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web_.NET_AT_Exerc05.Models;

namespace Web_.NET_AT_Exerc05.Pages
{
    public class UserFormModel : PageModel
    {
        [BindProperty]
        public UserModel User { get; set; }

        public string Message { get; private set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Message = "Dados enviados com sucesso!";
            return Page();
        }
    }
}