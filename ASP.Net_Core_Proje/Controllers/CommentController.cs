using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}


		public PartialViewResult PartialAdComment()
		{

			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id)
		{

			var values=cm.GetList(id);
			return PartialView(values);
		}
	}
}
