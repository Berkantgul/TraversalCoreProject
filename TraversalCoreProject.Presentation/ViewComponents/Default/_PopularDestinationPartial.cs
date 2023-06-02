using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _PopularDestinationPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var result = destinationManager.GetList();
            return View(result);
        }
    }
}
