using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.MemberLayout
{
	public class _MemberLayoutHead:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
