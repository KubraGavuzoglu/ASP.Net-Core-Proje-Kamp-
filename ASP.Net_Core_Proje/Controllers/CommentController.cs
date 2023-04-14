using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		public PartialViewResult PartialAdComment()
		{

			return PartialView();
		}

		public PartialViewResult CommentListByBlog()
		{

			return PartialView();
		}
	}
}
