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

        
        public string MenuName { get; set; }
        public MenuItem item { get; set; }

        private DateTime Date { get; set; }

        DateTime date = DateTime.Now;

                     
        public Category category{ get; private set; }



        public Menu (string menuName,Category category)
        {
            this.category = category;
            MenuName = menuName;
            this.Date = date;
            //this.dateMenu = GetDate();
        }

      
        public List<MenuItem> GetMenus()
        {
            return MenuItems;
        }

        
      
        public DateTime GetDate()
        {
           return Date;
        }
      
        

        public List<MenuItem> AddItem(MenuItem item)
        {
           
            MenuItems.Add(item);
            return MenuItems;
        }

        public List<MenuItem> RemoveItem(MenuItem item)
        {

            MenuItems.Remove(item);
            return MenuItems;
        }

        public string printMenu(List<MenuItem> MenuItems)
        {
            string itemsMenu = "";
            foreach (var item in MenuItems)
            {
                itemsMenu = itemsMenu + item.ItemName + " , " ;

            }
            return itemsMenu;
        }


       
    }
}
