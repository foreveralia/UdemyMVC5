using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdemyMVC5.Models;
using UdemyMVC5.ViewModel;
using static UdemyMVC5.ViewModel.RandomMovieViewModel;

namespace UdemyMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie { name = "Matrix" };
            var customers = new List<Customer>
            {
               new Customer { Name="Customer 1"},
               new Customer { Name="Customer 2"},
               new Customer { Name="Customer 3"}
            };

            var ViewModel = new RandomMovieViewModel {
                Movie=movie,
                Customers=customers

            };

            return View(ViewModel);
        }

        public ActionResult Edit(int movieid)
        {
            return Content("id=" + movieid);
        }

        public ActionResult MovieList(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortname={1}", pageIndex, sortBy));


        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }


        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
               new Movie { name="Matrix 1"},
               new Movie { name="Matrix 2"},
               new Movie { name="Matrix 3"}
            };

            var ViewModel = new MoviesViewModel
            {
                Movies = movies
               

            };

            return View(ViewModel);

        }
    }
}