using ASP.Net_Core_Proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Proje.ViewComponents
{
	public class CommentList : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id= 1,
					UserName="Kübra"
				},
				new UserComment
				{
					Id= 2,
					UserName="a.yşe"
				},
				new UserComment
				{
					Id= 3,
					UserName="şener"
				},


			};
			return View(commentvalues);
		}
	}
}
