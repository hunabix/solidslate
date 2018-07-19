using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolidSlate.Models
{

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool IsCompany { get; set; }
    }
}