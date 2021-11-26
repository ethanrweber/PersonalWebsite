using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalWebsite.Models;

namespace PersonalWebsite.Pages.Shared
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; }
        public void OnGet()
        {
            Projects = RealDatabase.Projects;

            ViewData["UseBackgroundColor"] = true;
            ViewData["BackgroundColor"] = "lightgray";
        }
    }
}
