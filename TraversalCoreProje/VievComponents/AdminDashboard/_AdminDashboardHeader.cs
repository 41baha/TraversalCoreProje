using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.AdminDashboard
{
    public class _AdminDashboardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
