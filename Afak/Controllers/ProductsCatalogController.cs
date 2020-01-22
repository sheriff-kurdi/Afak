using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Afak.Controllers
{
    public class ProductsCatalogController : Controller
    {
        public IActionResult OrthodonticsProducts()
        {
            return View();
        }
        public IActionResult AirCompressorProducts()
        {
            return View();
        }
        public IActionResult SmallDeviceProducts()
        {
            return View();
        }
        public IActionResult UnitProducts()
        {
            return View();
        }
        public IActionResult CompressorAccessoriesProducts()
        {
            return View();
        }
        public IActionResult ContraAccessoriesProducts()
        {
            return View();
        }
    }
}