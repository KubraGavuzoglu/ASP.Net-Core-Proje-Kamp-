using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
