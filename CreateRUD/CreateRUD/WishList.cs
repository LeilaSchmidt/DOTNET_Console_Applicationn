namespace CreateRUD
{
    public class Wishlist
    {
        public string title;
        public string brand;
        public double price;
        public string[] enteredValues;


        public Wishlist(string title, string brand, double price)
        {
            this.title = title;
            this.brand = brand;
            this.price = price;

        }

        public static void CreateListItem()
        {
            Wishlist Item1 = new Wishlist("Title", "Brand", 0.0);

            Console.WriteLine("What is the name of the product?");
            Item1.title = Console.ReadLine();

            Console.WriteLine("What is the name of the products' brand?");
            Item1.brand = Console.ReadLine();

            Console.WriteLine("What is the price of the product?");
            Item1.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Are these inputs correct? Name: {Item1.title}, Brand: {Item1.brand}, Price: {Item1.price}");
            Console.ReadLine();
        }

        public static void updateListItem()
        {
            return;
        }

        public static void readListItem()
        {
            Console.WriteLine("hello");
            Console.ReadLine();
        }

        public static void deleteListItem()
        {
            return;
        }
    }
}