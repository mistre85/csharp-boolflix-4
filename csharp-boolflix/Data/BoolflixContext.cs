using csharp_boolflix.Data.Models;
using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Data
{
    public class BoolflixContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Features> Features { get; set; }


        public BoolflixContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=csharp_boolflix_4;Integrated Security=True");
        }
    }
}
