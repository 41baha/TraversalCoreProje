using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.MemberLayout
{
	public class _MemberLayoutSidebar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
