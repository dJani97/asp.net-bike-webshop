using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BikeStore.Models
{
    public class BicycleContext : DbContext
    {
        public BicycleContext() : base("WebShop") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<CartElement> CartElements { get; set; }
    }
}