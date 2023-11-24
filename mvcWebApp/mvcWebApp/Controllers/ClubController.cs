using Microsoft.AspNetCore.Mvc;

namespace mvcWebApp.Controllers
{
    public class ClubController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
