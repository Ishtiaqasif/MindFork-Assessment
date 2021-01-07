using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Models
{
    public class CommentDataModel
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public int CommentedBy { get; set; }
        public DateTime CommentedOn { get; set; }
        public int BlogId { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
    }
}
