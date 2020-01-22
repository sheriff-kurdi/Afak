using Afak.Data;
using Afak.Models;
using Afak.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;

using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.Repo
{
    public class SqlOfferRepo : IOfferRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment hostingEnvironment;

        public SqlOfferRepo(ApplicationDbContext db, IWebHostEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }
        public void AddOffer(OfferVM offer)
        {
            //add image folders
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");

            //add image one
            string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(offer.img.FileName);
            string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
            offer.img.CopyTo(new FileStream(filePathOne, FileMode.Create));

            Offer newOffer = new Offer
            {
                Name = offer.Name,
                Price = offer.Price,
                Desc = offer.Desc,

                photo = uniqFileNameOne

            };

            db.Offers.Add(newOffer);

            db.SaveChanges();

        }

        public void Delete(Offer offer)
        {
            if (offer != null)
            {
                db.Remove(offer);
                db.SaveChanges();
            }
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            IEnumerable<Offer> offersList = db.Offers.ToList();
            return offersList;
        }

        public Offer GetOfferByID(int id)
        {
            Offer offer = db.Offers.Find(id);
            return offer;
        }

        public void Update(OfferVM updatedOffer)
        {
            //add image folders
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");

            Offer OldOffer = db.Offers.Find(updatedOffer.Id);

            OldOffer.Name = updatedOffer.Name;
            OldOffer.Price = updatedOffer.Price;
            OldOffer.Desc = updatedOffer.Desc;

            //add image one
            string uniqFileNameOne = Guid.NewGuid().ToString() + "_" + Path.GetFileName(updatedOffer.img.FileName);
            string filePathOne = Path.Combine(uploadsFolder, uniqFileNameOne);
            updatedOffer.img.CopyTo(new FileStream(filePathOne, FileMode.Create));

            OldOffer.photo = uniqFileNameOne;

            db.SaveChanges();
        }
    }
}
