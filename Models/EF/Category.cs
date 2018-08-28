using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models.EF
{
    [Table("categories")]
    public class Category
    {
        [Key]
        public string CatCode { get; set; }
        public string CatDesc { get; set; }
    }
}