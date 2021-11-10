using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PersonalWebsite.Other.HelperClasses;

namespace PersonalWebsite.Pages
{
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CurrentPage"] = NavbarConstants.NavbarKeys.About;
        }
    }
}
