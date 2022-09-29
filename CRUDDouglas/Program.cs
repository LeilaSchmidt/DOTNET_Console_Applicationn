namespace CRUDDouglas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please insert Title");
            var Title = Console.ReadLine();

            Console.WriteLine("Please insert Price");
            var Price = Console.ReadLine();

            var ConvertedPrice = Convert.ToInt32(Price);
            var WishListItem = new WhishlistItem();
            WishListItem.Title = Title;
            Console.WriteLine(WishListItem.Title);
        }
    }
}