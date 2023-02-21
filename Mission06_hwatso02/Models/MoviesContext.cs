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
        public DbSet<Category> categories { get; set; }
        public DbSet<Rating> ratings { get; set; }

        //seed in data
        protected override void OnModelCreating(ModelBuilder mb)
        {

            //Add dropdown for catgories
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Family" },
                new Category { CategoryId = 4, CategoryName = "Horror" },
                new Category { CategoryId = 5, CategoryName = "Musical" },
                new Category { CategoryId = 6, CategoryName = "Mystery" },
                new Category { CategoryId = 7, CategoryName = "Romance" },
                new Category { CategoryId = 8, CategoryName = "Rom-Com" },
                new Category { CategoryId = 9, CategoryName = "Sci-Fi" },
                new Category { CategoryId = 10, CategoryName = "Suspense" },
                new Category { CategoryId = 11, CategoryName = "Thriller" },
                new Category { CategoryId = 12, CategoryName = "Other" }
            );

            //Add better dropdown for ratings
            mb.Entity<Rating>().HasData(
                new Rating { RatingId = 1, RatingName = "G" },
                new Rating { RatingId = 2, RatingName = "PG" },
                new Rating { RatingId = 3, RatingName = "PG-13" },
                new Rating { RatingId = 4, RatingName = "R" }
            );

            mb.Entity<MovieCollection>().HasData(
                //first entry
                new MovieCollection
                {
                    MovieId = 1,
                    CategoryId = 11,
                    Title = "Non-Stop",
                    Year = 2014,
                    Director = "Jaume Collet-Serra",
                    RatingId = 3,
                    Notes = "Amazing Liam Neeson movie"
                },

                //second entry
                new MovieCollection
                {
                    MovieId = 2,
                    CategoryId = 6,
                    Title = "Grease",
                    Year = 1978,
                    Director = "Randal Kleiser",
                    RatingId = 2,
                    LentTo = "Mom"
                },

                //third entry
                new MovieCollection
                {
                    MovieId = 3,
                    CategoryId = 1,
                    Title = "The Italian Job",
                    Year = 2003,
                    Director = "Jaume Collet-Serra",
                    RatingId = 3,
                    Edited = false,
                    LentTo = "Kara and Dad"
                }
            );
        }
    }
}
