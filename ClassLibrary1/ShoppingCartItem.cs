using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    internal class ShoppingCartItem
    {
        public string Description { get; set; }
        public double Cost { get; set; }
        public int SubTotal { get; set; }
        
        public Product(string Description, double Cost)
          {
            Description = description;
            Cost= cost;
          }

    }
}
