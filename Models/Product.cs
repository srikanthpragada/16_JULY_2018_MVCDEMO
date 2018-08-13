using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class Product
    {
        public string Id { get; set; }

        [MinLength(5,ErrorMessage="Min length is 5")]
        [Required]
        public string Name { get; set; }

        [Range(0,Double.MaxValue, ErrorMessage ="Invalid Price. It must be >=0")]
        public double Price { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid Qoh. It must be >=0")]
        public int Qoh { get; set; }
        public string Remarks { get; set; }

        [RegularExpression(@"^[a-zA-Z]{2}$",ErrorMessage ="Must be 2 chars")]
        public string Category { get; set; }
       
    }
}