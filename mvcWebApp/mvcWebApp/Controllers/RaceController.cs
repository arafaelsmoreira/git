using Microsoft.AspNetCore.Mvc;

namespace mvcWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
