using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Models
{
    public class BlogFeedback
    {
        public string BlogTitle { get; set; }
        public string WrittenBy { get; set; }
        public DateTime WrittenOn { get; set; }
        public int TotalComments { get; set; }

        public List<BlogComment> Comments { get; set; }
    }
    public class BlogComment
    {
        public string Comment { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CommentedOn { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
