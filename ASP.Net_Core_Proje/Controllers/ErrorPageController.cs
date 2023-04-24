using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
