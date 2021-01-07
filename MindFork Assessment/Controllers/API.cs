using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MindFork_Assessment.Gateway;
using MindFork_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindFork_Assessment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class API : ControllerBase
    {
        [Route("getusers")]
        [HttpGet]
        public IActionResult GetUser()
        {
            var users = new APIGateway().GetUsers();
            
            return Ok(users);
        }

        [Route("getfeedback/{index}/{count}")]
        [HttpGet]
        public IActionResult GetFeedback(int index, int count)
        {
            var feedbacks = new APIGateway().GetBlogFeedBack(index, count);

            var feedbackGroupedByBlog = feedbacks
                .GroupBy(
                        b => b.BlogTitle,
                        (key, g) => new BlogFeedback()
                        {
                            BlogTitle = g.FirstOrDefault().BlogTitle,
                            WrittenBy = g.FirstOrDefault().BlogWrittenBy,
                            WrittenOn = g.FirstOrDefault().WrittenDate,
                            TotalComments = g.ToList().Count,
                            Comments = g
                                .Select(c => new BlogComment()
                                {
                                    Comment = c.Comment,
                                    CommentedBy = c.CommentedBy,
                                    CommentedOn = c.CommentedOn,
                                    Likes = c.Like,
                                    Dislikes = c.Dislike
                                }
                            ).ToList()
                        }
                        );


            return Ok(feedbackGroupedByBlog);
        }

    }
}
