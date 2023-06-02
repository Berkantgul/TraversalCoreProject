using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _FeatureDestinationsPartial : ViewComponent
    {
        private readonly IFirstFeatureService _firstFeatureManager;

        public _FeatureDestinationsPartial(IFirstFeatureService firstFeatureManager)
        {
            _firstFeatureManager = firstFeatureManager;
        }

        public IViewComponentResult Invoke()
        {
            var result = _firstFeatureManager.GetList();
            return View(result);
        }
    }
}
