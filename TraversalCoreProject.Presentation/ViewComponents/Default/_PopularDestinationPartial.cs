using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;

namespace TraversalCoreProject.Presentation.ViewComponents.Default
{
    public class _PopularDestinationPartial : ViewComponent
    {
        private readonly IDestinationService _destinationManager;

        public _PopularDestinationPartial(IDestinationService destinationManager)
        {
            _destinationManager = destinationManager;
        }

        public IViewComponentResult Invoke()
        {
            var result = _destinationManager.GetList();
            return View(result);
        }
    }
}
