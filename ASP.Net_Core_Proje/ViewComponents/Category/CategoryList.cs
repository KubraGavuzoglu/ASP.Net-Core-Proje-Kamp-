using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());


		public IViewComponentResult Invoke()
		{
			var values=cm.GetAllList();
			return View(values);	
		}

	}
}
