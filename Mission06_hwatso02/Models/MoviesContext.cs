using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_hwatso02.Models
{
    //inherit properties of class
    public class MoviesContext : DbContext 
    {
        //constructor
        public MoviesContext (DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<MovieCollection> collection { get; set; }

        //seed in data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieCollection>().HasData(
                //first entry
                new MovieCollection
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "Non-Stop",
                    Year = 2014,
                    Director = "Jaume Collet-Serra",
                    Rating = MovieRating.PG13,
                    Notes = "Amazing Liam Neeson movie"
                },

                //second entry
                new MovieCollection
                {
                    MovieId = 2,
                    Category = "Musical",
                    Title = "Grease",
                    Year = 1978,
                    Director = "Randal Kleiser",
                    Rating = MovieRating.PG,
                    LentTo = "Mom"
                },

                //third entry
                new MovieCollection
                {
                    MovieId = 3,
                    Category = "Action",
                    Title = "The Italian Job",
                    Year = 2003,
                    Director = "Jaume Collet-Serra",
                    Rating = MovieRating.PG13,
                    Edited = false,
                    LentTo = "Kara and Dad"
                }
            );
        }
    }
}
