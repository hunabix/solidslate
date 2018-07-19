using SolidSlate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolidSlate.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Detail()
        {

            var customer = new Customer()
            {
                Id = 1,
                Name = "Jesús Gómez",
                Alias = "Chucho",
                IsCompany = false
            };

            return View(customer);
        }
    }
}