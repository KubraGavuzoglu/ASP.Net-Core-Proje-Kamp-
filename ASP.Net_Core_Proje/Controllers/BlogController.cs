using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {

            var values = bm.GetAllList();
            return View(values);
        }
    }
}
