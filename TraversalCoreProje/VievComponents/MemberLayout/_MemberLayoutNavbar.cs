using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.MemberLayout
{
	public class _MemberLayoutNavbar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
