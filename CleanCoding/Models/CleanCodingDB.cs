using System.Data.Entity;

namespace CleanCoding.Models
{
    public class CleanCodingDB : DbContext
    {
        public CleanCodingDB() : base("name=DefaultConnection")
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}