using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
