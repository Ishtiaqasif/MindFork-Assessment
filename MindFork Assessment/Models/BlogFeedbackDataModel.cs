using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Models
{
    public class BlogFeedbackDataModel
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CommentedOn { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public string BlogTitle { get; set; }
        public string BlogWrittenBy { get; set; }
        public DateTime WrittenDate { get; set; }


    }
}
