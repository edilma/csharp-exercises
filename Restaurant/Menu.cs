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

        /*
        public DateTime DateMenu 
            {
           
            set { DateTime dateMenu = DateTime.Now; }
            }
        

            
        public DateTime dateMenu
        {
            get
            { return dateMenu; }
            set { 
                dateMenu = DateTime.Now; }
        
        }
        */
       
                
        public Category category{ get; private set; }



        public Menu (string menuName,Category category)
        {
            this.category = category;
            MenuName = menuName;
            //this.dateMenu = GetDate();
        }

      
        public List<MenuItem> GetMenus()
        {
            return MenuItems;
        }

        
       /*
        public DateTime GetDate()
        {
           return dateMenu;
        }
       */
        

        /*
        public List<MenuItem> AddItem(MenuItem item)
        {
           
            return RestMenuItems.Add(item);
        }
        */

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
