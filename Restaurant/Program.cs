using System;
using System.Collections.Generic;

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

            MenuItem item4 = new MenuItem();
            item3.ItemName = "Coffee";
            item3.ItemDescription = "Cup of Coffee";
            item3.Price = 1.99;
            
            MenuItem item5 = new MenuItem("Eggs", "Scramble Egges", 4.99);

            MenuItem item6 = new MenuItem("Ice Cream", "Vanilla Ice Cream", 3.99);
            wendys.AddItem(item6);

            wendys.MenuItems.Add(item5);

            chilis.MenuItems.Add(item1);
            chilis.MenuItems.Add(item2);
            chilis.MenuItems.Add(item3);

            chilis.AddItem(item5);
            //Console.WriteLine("Is {0} a new item? answer = {1}", item5, item5.newItem());

            //Console.WriteLine("The Menu was created at 2:36:44 - check that this {0} should be equal " , chilis.GetDate());

            //Console.WriteLine("The Menu was updated at 11:36  at 2:36:44 - check that this {0} should be equal ", chilis.GetDate());

            //Console.WriteLine(chilis.MenuItems); 

            //Console.WriteLine("The {0} menu of chilis. For {1} ", chilis.MenuName, chilis.category);

            //Console.WriteLine("includes the following items: " +chilis.printMenu(chilis.MenuItems) );
            // Console.WriteLine("The {0} menu of chilis. For {1} ", wendys.MenuName, wendys.category);

            //Console.WriteLine(" Date creation of {0} Menu was {1}", wendys.MenuName, wendys.GetDate());
            //Console.WriteLine("The total item5 of chilis should be 4==  {0}" , chilis.MenuItems.Count);
            //Console.WriteLine("includes the following items: " +chilis.printMenu(chilis.MenuItems) );

            // chilis.RemoveItem(item5);
            //Console.WriteLine("includes the following items: " + chilis.printMenu(chilis.MenuItems));


            // Console.WriteLine("Print all the items : ",item5.getItemNames());
            Console.WriteLine("Print all the items : {0}",wendys.printMenu(wendys.MenuItems));

            //Console.WriteLine("The Menu of {0} (wendys) was updated at 11:39 - check that this {1} should be equal ", wendys.MenuItems, wendys.GetDate());


            Console.Read();
        }
    }
}
