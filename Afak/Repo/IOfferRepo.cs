using Afak.Models;
using Afak.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.Repo
{
    public interface IOfferRepo
    {
        void AddOffer(OfferVM offer);
        Offer GetOfferByID(int id);
        IEnumerable<Offer> GetAllOffers();
        void Delete(Offer offer);
        void Update(OfferVM offer);
    }
}
