using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages; 
using Newtonsoft.Json;
using System.Collections.Generic;
 



namespace dawoodali.co.nz.Pages
{
    public class ProjectsAndCaseStudiesModel : PageModel
    {

        public List<Dictionary<string, object>> Projects { get; private set; }

        public void OnGet()
        {
            // Path to your JSON file
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/Files", "projects.json");

            // Check if the file exists and read the data
            if (System.IO.File.Exists(jsonFilePath))
            {
                var jsonData = System.IO.File.ReadAllText(jsonFilePath);
                Projects = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonData);
            }
        }
    }
}
