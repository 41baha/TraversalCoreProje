using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.MemberLayout
{
	public class _MemberLayoutHeaderContent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
