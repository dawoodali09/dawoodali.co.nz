using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dawoodali.co.nz.Pages
{
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
