using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TECsite.Data;
using UniEncryption;

namespace TECsite.Pages.Accounts
{
    public class logoutModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        public void OnGet()
        {
            Console.WriteLine("logout"); 
        }

        public ActionResult OnPostLogout()
        {
            Response.Cookies.Delete("loggedIn");
            Console.WriteLine($"logged out");
            return RedirectToPage("../Index");
        }
    }
}
