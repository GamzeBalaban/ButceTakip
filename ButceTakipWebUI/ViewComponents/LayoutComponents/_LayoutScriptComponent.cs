using Microsoft.AspNetCore.Mvc;

namespace ButceTakipWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
