using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;

namespace dawoodali.co.nz.Pages
{
    [OutputCache(Duration = 3600)] // Cache for 1 hour
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
