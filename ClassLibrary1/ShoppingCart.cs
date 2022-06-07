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
        
        
        public void ShoppingCartItems ()
        {
            products[1] = new Product("Noodles", 50);
            products[2] = new Product("Pasta", 60);
            products[3] = new Products("Mince" 40);
            
            for (int i=0;i< numberOfProducts; i++)
            {
               dudProducts.Item.Add(products[i].Description);
            }
            dudProducts.SelectedIndex =0;
        }
        
        public void btnExit_click()
        {
            close()
        }
        
        public void by NewOrder_Click()
        {
            OrderAddress.Text="";
            itemsOrdered=0;
            ItemsOrdered.Text= "Items Ordered:0";
       
            for(int i=0; i< numberOfProducts; i++;
            {
                products[i].NumberOrdered=0;
            }
             
                dudProducts.SelectedIndex=0;
                Products.Items?Clear();
                Total Cost.Text="Total Cost";
                txtMailingLabel.Text="";
            }
             
            public void AddToOrder_Click()
            {
                products[dudProduts.SelectedIndex].NumberOrdered++;
                itemsOrdered++;
                ItemsOrdered.Text="ItemsOrdered: "+ itemsOrderd.ToString();
            }
                
            public void ShoppingCart_SelectedIndexChange()
            {
                switch(OrderedForm.SelectedIndex)
                {
                        if (itemsOrdered ==0)
                        {
                            Message Box.Show("Invalid Order",):
                            order Forms.SelectedIndex=0;
                        }
                        else
                        {
                            double totalCost=0;
                            Products.Items.Clear();
                            for(int i=0; i< numberOfProducts; i++)
                            {
                                if(products[i].NumberOrdered i=0)
                                {
                                   Products.Items Add(products[i].NumberOrdered.ToString() +""+ products[i].Desciption);
                                    totalCost+=products [i].Cost* products[i].NumberOrdered;
                                }
                            }
                            Products.Text="Total Cost:150 + String.Format("{0;0}");
                        }
                 }
                        
                        
                        
                    
                     
                           
                              
             
   
         }   
    }
}
