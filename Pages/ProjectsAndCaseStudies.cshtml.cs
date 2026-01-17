using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dawoodali.co.nz.Pages
{
    [OutputCache(Duration = 3600)] // Cache for 1 hour
    public class ProjectsAndCaseStudiesModel : PageModel
    {
        private readonly IMemoryCache _cache;
        private readonly IWebHostEnvironment _environment;
        private const string ProjectsCacheKey = "ProjectsData";

        public List<Dictionary<string, object>>? Projects { get; private set; }

        public ProjectsAndCaseStudiesModel(IMemoryCache cache, IWebHostEnvironment environment)
        {
            _cache = cache;
            _environment = environment;
        }

        public async Task OnGetAsync()
        {
            // Try to get projects from cache
            if (!_cache.TryGetValue(ProjectsCacheKey, out List<Dictionary<string, object>>? cachedProjects))
            {
                // Path to your JSON file
                var jsonFilePath = Path.Combine(_environment.WebRootPath, "assets/Files", "projects.json");

                // Check if the file exists and read the data
                if (System.IO.File.Exists(jsonFilePath))
                {
                    var jsonData = await System.IO.File.ReadAllTextAsync(jsonFilePath);
                    cachedProjects = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonData);

                    // Cache the data for 1 hour
                    var cacheOptions = new MemoryCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromHours(1));

                    _cache.Set(ProjectsCacheKey, cachedProjects, cacheOptions);
                }
            }

            Projects = cachedProjects;
        }
    }
}
