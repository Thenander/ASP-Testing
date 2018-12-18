using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CustomersService
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer{Id = 1, CompanyName = "Lernia", City = "Stockholm"},
            new Customer{Id = 2, CompanyName = "Nackademin", City = "Stockholm"},
            new Customer{Id = 3, CompanyName = "KYH", City = "Malmö"}
        };

        public Customer[] GetAll()
        {
            return customers
                .OrderBy(o => o.CompanyName)
                .ToArray();
        }

    }
}
