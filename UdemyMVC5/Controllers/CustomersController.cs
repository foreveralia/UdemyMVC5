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
    public class CustomersController : Controller
    {
        // GET: Customers
      

               public ActionResult Index()
        {
            var customers = new List<Customer>
            {
               new Customer { Id=1, Name="Customer 1"},
               new Customer { Id=2, Name="Customer 2"},
               new Customer { Id=3, Name="Customer 3"}
            };

            var ViewModel = new CustomersViewModel
            {
              Customers=customers

            };

            return View(ViewModel);

        }

        public ActionResult Detail(int id)
        {

            return View();
        }

                 
    }
}