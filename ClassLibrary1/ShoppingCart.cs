using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    internal class ShoppingCart
    {
        public ShoppingCart()
        {
            InitializeComponent()
        }
        
        int itemsOrdered;
        const int number Of Products = 3;
        Product[] products=new Product[numberOfProducts];
        
        
        public void ShoppingCart(object sender, EventArgs)
        {
            products[1] = new Product("Noodles", 50);
            products[2] = new Product("Pasta", 60);
            products[3] = new Products("Mince" 40);
            
            for (int i=0;i< numberOfProducts; i++)
            {
               3dudProducts.Item.Add(products[i].Description);
            }
            dudProducts.SelectedIndex =0;
        }  
    }
}
