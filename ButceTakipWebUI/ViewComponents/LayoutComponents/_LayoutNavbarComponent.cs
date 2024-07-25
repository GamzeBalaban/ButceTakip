using Microsoft.AspNetCore.Mvc;

namespace ButceTakipWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
