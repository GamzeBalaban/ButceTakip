using Microsoft.AspNetCore.Mvc;

namespace ButceTakipWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
