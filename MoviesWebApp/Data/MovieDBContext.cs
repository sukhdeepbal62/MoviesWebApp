using Microsoft.EntityFrameworkCore;
using MoviesWebApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Data
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}
