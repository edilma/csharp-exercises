using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get;  set; }

        /*  ARREGLAR MENUS CREATION DATE
         public DateTime creation
         {
             get
             {
                 return creationDate;
             }

             set
             {
                 DateTime creationDate = DateTime.Now;
             }
         }
         */

        

        public MenuItem(string itemName, string itemDescription,double price)
        {
            ItemName = itemName;
            ItemDescription = itemDescription;
            Price = price;
        }

        public List<MenuItem> AllItems = new List<MenuItem>();
        public List<MenuItem> GetItems()
        {
            return AllItems;
        }
        /*
        public List<MenuItem> getItemNames()
        {
            string menuItemNames = "";
            foreach (MenuItem item in AllItems)
            {
                menuItemNames = menuItemNames + "\t" + item.ItemName;
            }
            return menuItemNames; // Why it is not a string?
        }
        */

    }
}

