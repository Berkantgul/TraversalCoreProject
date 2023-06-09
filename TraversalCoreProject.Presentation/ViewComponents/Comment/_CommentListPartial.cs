using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Business.Abstract;

namespace TraversalCoreProject.Presentation.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int destinationId)
        {
            var result = _commentService.GetByDestinationId(destinationId);
            return View(result);
        }
    }
}
