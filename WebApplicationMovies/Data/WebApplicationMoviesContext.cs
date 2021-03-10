using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMovies.Models;

namespace WebApplicationMovies.Data
{
    public class WebApplicationMoviesContext : DbContext
    {
        public WebApplicationMoviesContext (DbContextOptions<WebApplicationMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationMovies.Models.Movie> Movie { get; set; }
    }
}
