using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCoreProject.Entity.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentIsActive { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
