using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_hwatso02.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_hwatso02.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext movieContext { get; set; }

        public HomeController(MoviesContext movie)
        {
            movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            //Store table in list of categories
            ViewBag.Categories = movieContext.categories.ToList();
            //Store table in list of ratings
            ViewBag.Ratings = movieContext.ratings.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieCollection mc)
        {
            //Validation
            if (ModelState.IsValid)
            {
                //read in data inputs
                movieContext.Add(mc);
                movieContext.SaveChanges();

                return View("Confirmation", mc);
            }
            else
            {
                ViewBag.Categories = movieContext.categories.ToList();
                ViewBag.Ratings = movieContext.ratings.ToList();

                return View(mc);
            }
        }

        //Action for Movie Table
        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.collection
                .Include(c => c.Category)
                .Include(r => r.Rating)
                .OrderBy(m => m.Title)
                .ToList();

            return View(movies);
        }

        //Edit entry
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.categories.ToList();
            ViewBag.Ratings = movieContext.ratings.ToList();

            var movie = movieContext.collection.Single(m => m.MovieId == movieid);

            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieCollection mc)
        {
            movieContext.Update(mc);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        //Delete entry
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.collection.Single(m => m.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieCollection mc)
        {
            movieContext.collection.Remove(mc);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
