using System;

namespace CleanCoding.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ArticleID { get; set; }
        public String Message { get; set; }
    }
}