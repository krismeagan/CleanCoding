using System;

namespace CleanCoding.Models
{
    public class ArticleListViewModel
    {
        public int ArticleID { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public int CommentCount { get; set; }
    }
}