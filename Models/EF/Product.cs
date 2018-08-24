using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models.EF
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("prodid")]
        public string Prodid { get; set; }

        [Column("prodname")]
        public string ProdName { get; set; }

        public double Price { get; set; }
        public int Qoh { get; set; }
        public string Remarks { get; set; }
        public string Catcode { get; set; }
       
    }
}