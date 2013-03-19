using System;
using System.Collections.Generic;

namespace CleanCoding.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public String Title { get; set; }
        public String Body { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}