using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimaniolService _testimaniolService;

        public _TestimonialPartial(ITestimaniolService testimaniolService)
        {
            _testimaniolService = testimaniolService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _testimaniolService.GetList();
            return View(result);
        }
    }
}
