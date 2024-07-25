using Microsoft.AspNetCore.Mvc;

namespace ButceTakipWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
