using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Other.HelperClasses;
using System.Threading.Tasks;

namespace PersonalWebsite.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public NavbarViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(NavbarConstants.NavbarValues);
        }

    }
}
