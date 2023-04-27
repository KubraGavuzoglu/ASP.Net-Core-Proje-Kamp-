using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
