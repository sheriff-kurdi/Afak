using Afak.Collections;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Afak.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        public string ImageThree { get; set; }
        public string ImageFour { get; set; }
        public string ImageFive { get; set; }
        public Category Category { get; set; }

        //public int Id { get; set; }

        //public string Name { get; set; }

        //public int Price { get; set; }

        //public string Image { get; set; }

        //public Category Category { get; set; }






    }


}
