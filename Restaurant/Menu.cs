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
        
        public Category category{ get; private set; }

        public Menu (string menuName,Category category)
        {
            this.category = category;
            MenuName = menuName;
        }

        public List<MenuItem> GetMenus()
        {
            return MenuItems;
        }

        public List<MenuItem> AddItem(MenuItem item)
        {
            return Menu.MenuItems.Add(item);
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
