using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.AdminDashboard
{
	public class _DashboardBanner:ViewComponent
	{
        public IViewComponentResult Invoke()
        {           
            return View();
        }
    }
}
