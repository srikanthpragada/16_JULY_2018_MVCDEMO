using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qoh { get; set; }
        public string Remarks { get; set; }
        public string Category { get; set; }
       
    }
}