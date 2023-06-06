using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Entity.Concrete;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _SubAboutPartial : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _SubAboutPartial(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _subAboutService.GetList();

            return View(result);
        }
    }
}
