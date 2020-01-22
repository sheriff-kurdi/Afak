using Afak.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.ViewModels
{
    public class OfferVM : Offer
    {
        public IFormFile img { get; set; }
    }
}
