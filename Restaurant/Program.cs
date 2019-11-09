using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu chilis = new Menu("Lunch", Menu.Category.Appetizer);
            Menu wendys = new Menu("Breakfast", Menu.Category.Entree);

            MenuItem item1 = new MenuItem();
            item1.ItemName = "chickenSandwich";
            item1.ItemDescription = "emparedado pollo";
            item1.Price = 5.99;

            MenuItem item2 = new MenuItem();
            item2.ItemName = "French Fries";
            item2.ItemDescription = "papas";
            item2.Price = 2.99;

            MenuItem item3 = new MenuItem();
            item3.ItemName = "Soda";
            item3.ItemDescription = "Gaseosa";
            item3.Price = 1.99;

            chilis.MenuItems.Add(item1);
            chilis.MenuItems.Add(item2);
            chilis.MenuItems.Add(item3);




            Console.WriteLine(chilis.MenuItems); 

            Console.WriteLine("The {0} menu of chilis. For {1} ", chilis.MenuName, chilis.category);

            Console.WriteLine("includes the following items: " +chilis.printMenu(chilis.MenuItems) );
           // Console.WriteLine("The {0} menu of chilis. For {1} ", wendys.MenuName, wendys.category);

            Console.Read();
        }
    }
}
