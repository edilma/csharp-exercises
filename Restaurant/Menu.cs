using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {
        public enum Category
        {
            Appetizer,
            Entree,
            Dessert
        }

        public List<MenuItem> MenuItems = new List<MenuItem>();

        private DateTime dateMenuUpdated;
        public DateTime DateMenuUpdated { get; set; }


        public string MenuName { get; set; }
        public MenuItem item { get; set; } // chequear si esto o public List<MenuItem> Items { get { return items; } }

        public DateTime Date { get; set; }


                     
        public Category category{ get; private set; }

        


        public Menu (string menuName,Category category )
        {
            this.category = category;
            MenuName = menuName;
            dateMenuUpdated = DateTime.Now;
        }
/*
        public Menu ()
        {
            List<MenuItem> items = MenuItems;
        }

      */
        public List<MenuItem> GetMenus()
        {
            return MenuItems;
        }

        
      
        public DateTime GetDate()
        {
           return dateMenuUpdated;
        }
      
        

        public List<MenuItem> AddItem(MenuItem item)
        {
           
            MenuItems.Add(item);
            dateMenuUpdated = DateTime.Now;
            return MenuItems;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {

            MenuItems.Remove(item);
            dateMenuUpdated = DateTime.Now;
            return MenuItems;
        }

        public string printMenu(List<MenuItem> MenuItems)
        {
            string itemsMenu = "";
            foreach (var item in MenuItems)
            {
                itemsMenu = itemsMenu + item.ItemName + " \n " ;

            }
            return itemsMenu;
        }


       
    }
}
