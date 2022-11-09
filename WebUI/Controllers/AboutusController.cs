using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
