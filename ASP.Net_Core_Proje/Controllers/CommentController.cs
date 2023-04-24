using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

		[HttpGet]
		public PartialViewResult PartialAdComment()
		{

			return PartialView();
		}

		[HttpPost]
		public PartialViewResult PartialAdComment(Comment p)
		{
			p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogId = 5;
			cm.CommentAdd(p);

			return PartialView();
		}






		public PartialViewResult CommentListByBlog(int id)
		{

			var values=cm.GetList(id);
			return PartialView(values);
		}
	}
}
