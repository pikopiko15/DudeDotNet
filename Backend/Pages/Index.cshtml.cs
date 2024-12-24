using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Backend.Pages
{
    public class IndexModel : PageModel
    {
        public RedirectResult OnGet()
        {
            return Redirect("/Home");
        }
    }
}
