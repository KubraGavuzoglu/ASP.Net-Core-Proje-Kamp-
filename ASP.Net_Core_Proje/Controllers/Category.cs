using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {

            var values = cm.GetAllList();

            return View(values);
        }
    }
}
