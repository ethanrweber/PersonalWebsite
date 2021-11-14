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

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<IViewComponentResult> InvokeAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return View(NavbarConstants.NavbarValues);
        }

    }
}
