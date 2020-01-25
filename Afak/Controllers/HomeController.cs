using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Afak.Models;
using Microsoft.AspNetCore.Identity;
using Afak.Repo;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNet.Identity;

namespace Afak.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOfferRepo offerRepo;

        public HomeController(ILogger<HomeController> logger , IOfferRepo offerRepo)
        {
            _logger = logger;
            this.offerRepo = offerRepo;
        }

        public IActionResult Index()
        {
            IEnumerable<Offer> offers = offerRepo.GetAllOffers();
            return View(offers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Admin()
        {
         
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
