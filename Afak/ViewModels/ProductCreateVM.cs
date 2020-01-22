using Afak.Collections;
using Afak.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.ViewModels
{
    public class ProductCreateVM : Product
    {

        //[Required]
        public IFormFile photoOne { get; set; }
        public IFormFile photoTwo { get; set; }
        public IFormFile photoThree { get; set; }
        public IFormFile photoFour { get; set; }
        public IFormFile photoFive { get; set; }

        //[Required]

        //public IFormFile photo { get; set; }
    }
}
