using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        private static int nextItemId = 1;
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double Price { get;  set; }
        private DateTime dateCreated;
        public DateTime DateCreated
        {
            get { return dateCreated; }
        }
        

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
            ItemId = nextItemId++;
            ItemName = itemName;
            ItemDescription = itemDescription;
            Price = price;
            dateCreated = DateTime.Now;
            
        }

        public MenuItem( )
        {
        }


        public List<MenuItem> AllItems = new List<MenuItem>();
        public List<MenuItem> GetItems()
        {
            return AllItems;
        }

        public bool newItem()
        {
            DateTime today = DateTime.Now;
            if ((dateCreated.AddDays(14)> DateTime.Now ))
            {
                return true;
            }
            else
            {
                return false;
            }
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

