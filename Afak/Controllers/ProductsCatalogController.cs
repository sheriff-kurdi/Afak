using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Afak.Models;
using Afak.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Afak.Controllers
{
    public class ProductsCatalogController : Controller
    {
        private readonly IProductRepo productRepo;

        public ProductsCatalogController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        public IActionResult OrthodonticsProducts()
        {
            IEnumerable<Product> OrthodonticsProducts = productRepo.GeOrthodonticsProducts();
            return View(OrthodonticsProducts);
        }
        public IActionResult AirCompressorProducts()
        {
            IEnumerable<Product> AirCompressorProducts = productRepo.GetAirCompressorProducts();
            return View(AirCompressorProducts);
        }
        public IActionResult SmallDeviceProducts()
        {
            IEnumerable<Product> SmallDeviceProducts = productRepo.GetSmallDeviceProducts();
            return View(SmallDeviceProducts);
        }
        public IActionResult UnitProducts()
        {
            IEnumerable<Product> UnitProducts = productRepo.GetUnitProducts();
            return View(UnitProducts);
        }
        public IActionResult CompressorAccessoriesProducts()
        {
            IEnumerable<Product> CompressorAccessoriesProducts = productRepo.GetCompressorAccessoriesProducts();
            return View(CompressorAccessoriesProducts);
        }
        public IActionResult ContraAccessoriesProducts()
        {
            IEnumerable<Product> ContraAccessoriesProducts = productRepo.GetContraAccessoriesProducts();
            return View(ContraAccessoriesProducts);
        }

        //Details
        public IActionResult Details(int id)
        {
            Product pro = productRepo.GetProductByID(id);
            return View(pro);
        }



    }
}