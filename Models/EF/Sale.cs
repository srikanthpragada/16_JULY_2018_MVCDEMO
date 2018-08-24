using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models.EF
{
    [Table("sales")]
    public class Sale
    {
        [Key]
        public int Invno { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransDate { get; set; }
        public int Prodid { get; set; }
        // public virtual Product  Product { get; set; }

    }
}