using System;
using Lab233.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Lab233.Data

{
    public class MovieDbContext:DbContext
    {
        
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
