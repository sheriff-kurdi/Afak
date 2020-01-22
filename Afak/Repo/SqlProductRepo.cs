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

        //many repos for every product to implement AddProduct

        //public void AddProduct(ProductCreateVM model)

        //{

        //    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");

        //    string uniqFileName = Guid.NewGuid().ToString() + "_" + model.photo.FileName;



        //    string filePath = Path.Combine(uploadsFolder, uniqFileName);



        //    model.photo.CopyTo(new FileStream(filePath, FileMode.Create));



        //    Product pro = new Product

        //    {

        //        Name = model.Name,

        //        Price = model.Price,

        //        Image = uniqFileName,


        //        Category = model.Category





        //    };



        //    db.Products.Add(pro);

        //    db.SaveChanges();

        //}
        //------------------***************
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

        public void Update(Product proToUpdate)
        {

            Product product = db.Products.Find(proToUpdate.Id);

            product.Name = proToUpdate.Name;
            product.Price = proToUpdate.Price;
            product.Category = proToUpdate.Category;

            //if it  product and the user add Five photo
            if (product.Category != Collections.Category.Unit && product.Category != Collections.Category.AirCompressor
                && product.ImageOne != null && product.ImageTwo != null
                && product.ImageThree != null && product.ImageFour != null && product.ImageFive != null)
            {
                product.ImageOne = proToUpdate.ImageOne;
                product.ImageTwo = proToUpdate.ImageTwo;
                product.ImageThree = proToUpdate.ImageThree;
                product.ImageFour = proToUpdate.ImageFour;
                product.ImageFive = proToUpdate.ImageFive;
            }

            //if it Compressor product and the user add two photo
            if (product.Category == Collections.Category.AirCompressor && product.ImageOne != null && product.ImageTwo != null)
            {

                product.ImageOne = proToUpdate.ImageOne;
                product.ImageTwo = proToUpdate.ImageTwo;
            }

            //if it unit product and the user add one photo
            if (product.Category == Collections.Category.Unit && product.ImageOne != null)
            {
                product.ImageOne = proToUpdate.ImageOne;

            }


            db.SaveChanges();
        }
    }
}
