using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDouglas
{
    public class WishlistItem
    {
        public string title;
        public string brand;
        public double price;
        

        public WishlistItem(string title, string brand, double price)
        {
            this.title = title;
            this.brand = brand;
            this.price = price;
            
        }

        public static void createListItem()
        {

            WishlistItem Item1 = new WishlistItem("Title", "Brand", 0.0);

            Console.WriteLine("What is the name of the product?");
            Item1.title = Console.ReadLine();

            Console.WriteLine("What is the name of the products' brand?");
            Item1.brand = Console.ReadLine();


            Console.WriteLine("What is the price of the product?");
            Item1.price = Convert.ToDouble(Console.ReadLine());
        }

        public static void updateListItem()
        {
            return;
        }

        public static void readListItem()
        {
            return;
        }

        public static void deleteListItem()
        {
            return;
        }
    }
}
