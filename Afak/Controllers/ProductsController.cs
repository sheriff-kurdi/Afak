using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Afak.Models;
using Afak.Repo;
using Afak.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Afak.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepo productRepo;

        public ProductsController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        public IActionResult Index()
        {
            return View();
        }




        public IActionResult ManageProducts()
        {
            IEnumerable<Product> model = productRepo.GetAllProducts();
            return View(model);
        }


        //Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product pro = productRepo.GetProductByID(id);

            return View(pro);
        }

        [HttpPost]
        public IActionResult Delete(Product pro)
        {


            productRepo.Delete(pro);
            return RedirectToAction("ManageProducts");
        }
        // end Delete


        //add

        [HttpGet]

        public IActionResult AddProduct()

        {

            return View("AddProduct");

        }



        [HttpPost]

        public IActionResult AddProduct(ProductCreateVM model)

        {

            //string uniqFileName = null;



            if (model.photoOne != null)

            {

                productRepo.AddProduct(model);

                //return RedirectToAction("AddProduct");
                return View();

            }



            return RedirectToAction("index");

        }

        //end add



        //update
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            Product pro = productRepo.GetProductByID(id);
            return View(pro);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product UpdatedPro)
        {
            productRepo.Update(UpdatedPro);
            return RedirectToAction("ManageProducts", "products");
        }
        //end update
    }
}