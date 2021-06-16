using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CoffeCf.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
