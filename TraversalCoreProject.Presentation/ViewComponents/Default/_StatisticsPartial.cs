using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var result = _destinationManager.StatisticCount();
            ViewBag.DestinationCount = result.DestinationCount;
            ViewBag.GuideCount = result.GuideCount;
            return View();
        }
    }
}
