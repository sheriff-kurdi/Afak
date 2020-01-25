    using Afak.Collections;
using Afak.Data;
using Afak.Models;
using Afak.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.Repo
{
    public class SqlProductRepo : IProductRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment hostingEnvironment;

        public SqlProductRepo(ApplicationDbContext db, IWebHostEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }



        public void Update(ProductCreateVM UpdatedProduct)
        {

            //add image folders
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");




            Product OldProduct = db.Products.Find(UpdatedProduct.Id);

            OldProduct.Name = UpdatedProduct.Name;
            OldProduct.Price = UpdatedProduct.Price;
            OldProduct.Category = UpdatedProduct.Category;
            OldProduct.Desc = UpdatedProduct.Desc;
            db.SaveChanges();

 
            //if it  product and the user add Five photo
            if (UpdatedProduct.Category != Collections.Category.Unit && UpdatedProduct.Category != Collections.Category.AirCompressor )
            {
                if (UpdatedProduct.photoOne != null)
                {
                    //add image one
                    string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoOne.FileName);
                    string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                    UpdatedProduct.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));

                    OldProduct.ImageOne = uniqFileNameOne;
                }

                if (UpdatedProduct.photoTwo != null)
                {

                    //add image two
                    string uniqFileNameTwo = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoTwo.FileName);
                    string filePathTwo = Path.Combine(uploadsFolder, uniqFileNameTwo);
                    UpdatedProduct.photoTwo.CopyTo(new FileStream(filePathTwo, FileMode.Create));

                    OldProduct.ImageTwo = uniqFileNameTwo;
                }


                if (UpdatedProduct.photoThree != null)
                {
                    //add image three
                    string uniqFileNameThree = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoThree.FileName);
                    string filePathThree = Path.Combine(uploadsFolder, uniqFileNameThree);
                    UpdatedProduct.photoThree.CopyTo(new FileStream(filePathThree, FileMode.Create));

                    OldProduct.ImageThree = uniqFileNameThree;
                }
                if (UpdatedProduct.photoFour != null)
                {

                    //add image Four
                    string uniqFileNameFour = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoFour.FileName);
                    string filePathFoure = Path.Combine(uploadsFolder, uniqFileNameFour);
                    UpdatedProduct.photoFour.CopyTo(new FileStream(filePathFoure, FileMode.Create));

                    OldProduct.ImageFour = uniqFileNameFour;
                }
                if (UpdatedProduct.photoFive != null)
                {
                    //add image Five
                    string uniqFileNameFive = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoFive.FileName);
                    string filePathFive = Path.Combine(uploadsFolder, uniqFileNameFive);
                    UpdatedProduct.photoFive.CopyTo(new FileStream(filePathFive, FileMode.Create));

                    OldProduct.ImageFive = uniqFileNameFive;
                }




             


             
         
                db.SaveChanges();

            }


            //if it Compressor product and the user add two photo
            if (UpdatedProduct.Category == Collections.Category.AirCompressor )
            {
                OldProduct.ImageOne = OldProduct.ImageOne;
                OldProduct.ImageTwo = OldProduct.ImageTwo;

                if (UpdatedProduct.photoOne != null)
                {
                    //add image one
                    string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoOne.FileName);
                    string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                    UpdatedProduct.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));

                    OldProduct.ImageOne = uniqFileNameOne;
                }

                if (UpdatedProduct.photoTwo != null)
                {

                    //add image two
                    string uniqFileNameTwo = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoTwo.FileName);
                    string filePathTwo = Path.Combine(uploadsFolder, uniqFileNameTwo);
                    UpdatedProduct.photoTwo.CopyTo(new FileStream(filePathTwo, FileMode.Create));

                    OldProduct.ImageTwo = uniqFileNameTwo;
                }

                




                
                
                

                db.SaveChanges();

            }


            //if it unit product and the user add one photo
            if (UpdatedProduct.Category == Collections.Category.Unit && UpdatedProduct.photoOne != null)
            {

                //add image one
                string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(UpdatedProduct.photoOne.FileName);
                string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                UpdatedProduct.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));



                //product.ImageOne = proToUpdate.ImageOne;
                OldProduct.ImageOne = uniqFileNameOne;

                db.SaveChanges();

            }





        }

        public void AddProduct(ProductCreateVM product)
        {
            //add image folders
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");


            //if it  product and the user add Five photo
            if (product.Category != Collections.Category.Unit && product.Category != Collections.Category.AirCompressor 
                &&  product.photoOne != null && product.photoTwo != null
                && product.photoThree != null && product.photoFour != null && product.photoFive != null )
            {

                //add image one
                string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoOne.FileName);
                string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                product.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));

                //add image two
                string uniqFileNameTwo = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoTwo.FileName);
                string filePathTwo = Path.Combine(uploadsFolder, uniqFileNameTwo);
                product.photoOne.CopyTo(new FileStream(filePathTwo, FileMode.Create));

                //add image three
                string uniqFileNameThree = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoThree.FileName);
                string filePathThree = Path.Combine(uploadsFolder, uniqFileNameThree);
                product.photoOne.CopyTo(new FileStream(filePathThree, FileMode.Create));

                //add image Four
                string uniqFileNameFour = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoFour.FileName);
                string filePathFoure = Path.Combine(uploadsFolder, uniqFileNameFour);
                product.photoFour.CopyTo(new FileStream(filePathFoure, FileMode.Create));

                //add image Five
                string uniqFileNameFive = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoFive.FileName);
                string filePathFive = Path.Combine(uploadsFolder, uniqFileNameFive);
                product.photoOne.CopyTo(new FileStream(filePathFive, FileMode.Create));

                Product pro = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Desc = product.Desc,

                    ImageOne = uniqFileNameOne,
                    ImageTwo = uniqFileNameTwo,
                    ImageThree = uniqFileNameThree,
                    ImageFour = uniqFileNameFour,
                    ImageFive = uniqFileNameFive,

                    Category = product.Category


                };

                db.Products.Add(pro);

            }

            //if it Compressor product and the user add two photo
            if (product.Category == Collections.Category.AirCompressor && product.photoOne != null && product.photoTwo != null)
            {

                //add image one
                string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoOne.FileName);
                string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                product.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));

                //add image two
                string uniqFileNameTwo = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoTwo.FileName);
                string filePathTwo = Path.Combine(uploadsFolder, uniqFileNameTwo);
                product.photoOne.CopyTo(new FileStream(filePathTwo, FileMode.Create));


                Product pro = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Desc = product.Desc,
                    ImageOne = uniqFileNameOne,
                    ImageTwo = uniqFileNameTwo,           
                    Category = product.Category
                };

                db.Products.Add(pro);
            }



            //if it unit product and the user add one photo
            if (product.Category == Collections.Category.Unit && product.photoOne != null)
            {

                //add image one
                string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(product.photoOne.FileName);
                string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
                product.photoOne.CopyTo(new FileStream(filePathOne, FileMode.Create));

                Product pro = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Desc = product.Desc,
                    ImageOne = uniqFileNameOne,
                    Category = product.Category
                };

                db.Products.Add(pro);

            }

     
            db.SaveChanges();
        }

        public void Delete(Product pro)
        {
            if (pro != null)
            {
                db.Remove(pro);
                db.SaveChanges();
            }
        }

      

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> productsList = db.Products.ToList();
            return productsList;
        }

      


        public Product GetProductByID(int id)
        {
            Product pro = db.Products.Find(id);
            return pro;
        }

     

       

        public IEnumerable<Product> GeOrthodonticsProducts()
        {
            IEnumerable<Product> OrthodonticsProducts = db.Products.Where(p => p.Category == Category.Orthodontics).ToList();
            return OrthodonticsProducts;
        }

        public IEnumerable<Product> GetAirCompressorProducts()
        {
            IEnumerable<Product> AirCompressorProducts = db.Products.Where(p => p.Category == Category.AirCompressor).ToList();
            return AirCompressorProducts;
        }

        public IEnumerable<Product> GetSmallDeviceProducts()
        {
            IEnumerable<Product> SmallDeviceProducts = db.Products.Where(p => p.Category == Category.SmallDevice).ToList();
            return SmallDeviceProducts;
        }

        public IEnumerable<Product> GetUnitProducts()
        {
            IEnumerable<Product> UnitProducts = db.Products.Where(p => p.Category == Category.Unit).ToList();
            return UnitProducts;
        }
        public IEnumerable<Product> GetCompressorAccessoriesProducts()
        {
            IEnumerable<Product> CompressorAccessoriesProducts = db.Products.Where(p => p.Category == Category.CompressorAccessories).ToList();
            return CompressorAccessoriesProducts;
        }

        public IEnumerable<Product> GetContraAccessoriesProducts()
        {
            IEnumerable<Product> ContraAccessoriesProducts = db.Products.Where(p => p.Category == Category.ContraAccessories).ToList();
            return ContraAccessoriesProducts;
        }
    }
}
