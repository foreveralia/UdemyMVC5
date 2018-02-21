using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UdemyMVC5.Models;

namespace UdemyMVC5.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

        public List<Movie> Movies { get; set; }


        public class MoviesViewModel
        {
               public List<Movie> Movies { get; set; }
        }

        public class CustomersViewModel
        {
            public List<Customer> Customers { get; set; }
        }

    }
}