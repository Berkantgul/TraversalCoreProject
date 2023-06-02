using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _FeatureDestinationsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
