using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Presentation.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
