using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;

namespace TraversalCoreProject.Presentation.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var result = _destinationService.GetList();
            return View(result);
        }

        public IActionResult DestinationDetail(int id)
        {
            ViewBag.id = id;
            var result = _destinationService.GetById(id);
            return View(result);
        }
    }
}
