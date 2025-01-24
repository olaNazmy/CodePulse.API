using CodePulse.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Data
{
    public class ApplicationBbContext : DbContext
    {
        public ApplicationBbContext(DbContextOptions options) : base(options)
        {

        }

        //make properities of Models
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
