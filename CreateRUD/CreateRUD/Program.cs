namespace CreateRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to create, read, update or delete?");
            string userInput = Console.ReadLine();

            if (userInput == "create")
            {
                Wishlist.CreateListItem();
            }
            else if (userInput == "read")
            {
                Console.WriteLine();
            }
        }
    }
}