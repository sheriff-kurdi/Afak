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
    public class OffersController : Controller
    {
        private readonly IOfferRepo offerRepo;

        public OffersController(IOfferRepo offerRepo)
        {
            this.offerRepo = offerRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddOffer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOffer(OfferVM offer)
        {
            offerRepo.AddOffer(offer);
            return View();
        }

        [HttpGet]
        public IActionResult DeleteOffer(int id)
        {
            Offer offer = offerRepo.GetOfferByID(id);
            return View(offer);
        }

        [HttpPost]
        public IActionResult DeleteOffer(Offer offer)
        {
            offerRepo.Delete(offer);
            return RedirectToAction("AllOffers", "Offers");
        }

        [HttpGet]
        public IActionResult EditOffer(int id)
        {
            Offer offer = offerRepo.GetOfferByID(id);

            OfferVM offerVM = new OfferVM
            {
                Id = offer.Id,
                Name = offer.Name,
                Price = offer.Price,
                Desc = offer.Desc,
                photo = offer.photo
            };
            return View(offerVM);
        }

        [HttpPost]
        public IActionResult EditOffer(OfferVM UpdatedOffer)
        {
            offerRepo.Update(UpdatedOffer);
            return RedirectToAction("AllOffers", "Offers");
        }
        [HttpGet]
        public IActionResult AllOffers()
        {
            IEnumerable<Offer> offers = offerRepo.GetAllOffers();
            return View(offers);
        }


        [HttpGet]
        public IActionResult OfferDetails(int id)
        {
            Offer offers = offerRepo.GetOfferByID(id);
            return View(offers);
        }



    }
}