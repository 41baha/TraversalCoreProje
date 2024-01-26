using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.VievComponents.Comment
{
    public class _CommentList : ViewComponent
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context= new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.TGetListCommentWithoutDestinationAndUser(id);
            return View(values);
        }
    }
}
