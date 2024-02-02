using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopAEXM.View.Model
{
	public class Navbar : ViewComponent
	{

		public Navbar()
		{
			
		}
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
