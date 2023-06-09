using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Presentation.ViewComponents.Comment
{
    public class _CommentLeavePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
