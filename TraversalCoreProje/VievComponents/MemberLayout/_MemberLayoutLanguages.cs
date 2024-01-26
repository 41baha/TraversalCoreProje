using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.MemberLayout
{
	public class _MemberLayoutLanguages:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
