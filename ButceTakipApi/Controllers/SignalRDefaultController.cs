using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
