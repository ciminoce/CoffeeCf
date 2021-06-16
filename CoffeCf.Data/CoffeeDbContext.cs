using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeCf.Entities;

namespace CoffeCf.Data
{
    public class CoffeeDbContext:DbContext
    {
        public CoffeeDbContext():base("name=DefaultConnection")
        {
            
        }

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
