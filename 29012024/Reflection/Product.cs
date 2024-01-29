using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Product
    {
        public Product()
        {

        }

        public Product(string name)
        {

        }
        public string Name;
        private double _price;
        public double GetPrice => _price;
        public string Country { get; set; }
    }
}
