using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        CustomersService service;

        public CustomersController(CustomersService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            ViewData["Customers"] = service.GetAll();
            return View();
        }
    }
}