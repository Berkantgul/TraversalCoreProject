using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;

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
