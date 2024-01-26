using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.VievComponents.AdminDashboard
{
	public class _Cards1Statistic:ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = c.Destinations.Count();
			ViewBag.v2 = c.Users.Count();
			return View();
		}
	}
}
