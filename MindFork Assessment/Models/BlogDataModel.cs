using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Models
{
    public class BlogDataModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public int WrittenBy { get; set; }
        public DateTime WrittenDate { get; set; }
    }
}
