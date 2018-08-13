using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class DiscountModel
    {
        [Range(1000.0, Double.MaxValue,ErrorMessage ="Must be more than 1000")]
        public double Amount { get; set; }

        [Range(1, 50, ErrorMessage = "Discount rate must be between 1 and 50")]
        public double Rate { get; set; }

        public double Discount { get; set; }

    }

    
}