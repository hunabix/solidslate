using SolidSlate.Data;
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
        private CustomerRepository _customerRepository = null;

        public CustomersController()
        {
            _customerRepository = new CustomerRepository();
        }

        public ActionResult Index()
        {
            var customers = _customerRepository.getCustomers();

            return View(customers);
        }

        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }

            var customer = _customerRepository.GetCustomer((int)id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}