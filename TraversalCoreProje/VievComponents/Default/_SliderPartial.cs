using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.VievComponents.Default
{
    public class _SliderPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
