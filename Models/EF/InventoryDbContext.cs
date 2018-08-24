using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Models.EF
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext() :
            base(@"data source=(localdb)\mssqllocaldb;integrated security=true; initial catalog=msdb;MultipleActiveResultSets=True")
        {
            //Disable initializer 
            System.Data.Entity.Database.SetInitializer<InventoryDbContext>(null);
        }

        
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

    }

}