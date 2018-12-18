using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BandsController : Controller
    {
        BandsService service;

        public BandsController(BandsService service)
        {
            this.service = service;
        }

        // Bands/Index
        public IActionResult Index()
        {
            ViewBag.Bands = service.GetAllBands();
            //ViewData["Bands"] = service.GetAllBands();
            return View();
        }

        //Bands/Details/Id
        public IActionResult Details(int Id)
        {
            ViewBag.Band = service.GetBandById(Id);
            return View();
        }

    }
}