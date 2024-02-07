using Microsoft.EntityFrameworkCore;

namespace MyMvcApp.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MyMvcApp.Models.Movie> Movie { get; set; }
    }
}
