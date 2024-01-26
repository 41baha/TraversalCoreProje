using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.AdminDashboard
{
    public class _AdminGuideList:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
