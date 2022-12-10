using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * So first we want to create 
 * 
 * **/

namespace CRUDDouglas
{
    public class WishlistItem
    {
        public string title;
        public string category;
        public double price;
        public string[] enteredValues;


        public WishlistItem(string title, string category, double price)
        {
            this.title = title;
            this.category = category;
            this.price = price;

        }

        public static void CreateListItem()
        {
            WishlistItem Item1 = new WishlistItem("Title", "Brand", 0.0);

            Console.WriteLine("What is the name of the product?");
            Item1.title = Console.ReadLine();

            Console.WriteLine("What is the name of the products' brand?");
            Item1.category = Console.ReadLine();

            Console.WriteLine("What is the price of the product?");
            Item1.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Item1);
        }

        public static void updateListItem()
        {
            return;
        }

        public static void readListItem()
        {
            Console.WriteLine();
        }

        public static void deleteListItem()
        {
            return;
        }
    }
}
