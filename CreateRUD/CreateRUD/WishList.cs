namespace CreateRUD
{
    public class Wishlist
    {
        public string title;
        public string category;
        public double price;
        public string[] enteredValues;


        public Wishlist(string title, string category, double price)
        {
            this.title = title;
            this.category = category;
            this.price = price;

        }

        public static void CreateListItem()
        {
            Wishlist Item1 = new Wishlist("Title", "Brand", 0.0);

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
            Console.WriteLine(Item1.title);
        }

        public static void deleteListItem()
        {
            return;
        }
    }
}