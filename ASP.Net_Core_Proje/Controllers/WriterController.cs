using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.Controllers
{
   
    public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult WriterProfile()
        {
            return View();
        }

      
        public IActionResult WriterMail()
        {
            return View();
        }

		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}

        [AllowAnonymous]
        public PartialViewResult WriterNavBarPartial()
		{
			return PartialView();
		}

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
    }
}
