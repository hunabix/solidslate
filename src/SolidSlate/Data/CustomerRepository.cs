using SolidSlate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidSlate.Data
{
    public class CustomerRepository
    {
        private static Customer[] _customers = new Customer[]
        {
            new Customer()
            {
                Id = 1,
                Name = "Jesús Gómez",
                Alias = "Chucho",
                IsCompany = false
            },
            new Customer()
            {
                Id = 2,
                Name = "María del Mar",
                Alias = "Mare",
                IsCompany = false
            },
            new Customer()
            {
                Id = 3,
                Name = "CESVVER",
                Alias = "",
                IsCompany = true
            }
    };

        public Customer[] getCustomers()
        {
            return _customers;
        }


        public Customer GetCustomer(int id)
        {
            Customer customerToReturn = null;

            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                {
                    customerToReturn = customer;

                    break;
                }
            }

            return customerToReturn;
        }
    }
}