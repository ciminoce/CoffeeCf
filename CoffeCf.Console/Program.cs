using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeCf.Data;

namespace CoffeCf.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new CoffeeDbContext())
            {
                var typesList = context.ProductTypes.ToList();
                foreach (var productType in typesList) 
                {
                    System.Console.WriteLine($"{productType.Description}");
                }
            }

            System.Console.ReadLine();
        }
    }
}
