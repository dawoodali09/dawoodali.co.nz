using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;

namespace dawoodali.co.nz.Pages
{
    [OutputCache(Duration = 3600)] // Cache for 1 hour
    public class SkillsModel : PageModel
    {
        private readonly ILogger<SkillsModel> _logger;

        public SkillsModel(ILogger<SkillsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
