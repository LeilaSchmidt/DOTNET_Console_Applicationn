namespace CRUDDouglas
{

    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your own personal Douglas wishlist! Here you can create a wishlist of all your favorite Douglas items (including price, name and category)!");
            Console.WriteLine("Now, let's get started!");
            Console.WriteLine("To add an item, type 'add'.");
            Console.WriteLine("To view the items, type 'view'.");
            Console.WriteLine("To update an already existing item, type 'update'.");
            Console.WriteLine("To delete an item, type 'delete'");
            var userInput = Console.ReadLine();

            if (userInput == "add")
            {
                CreateListItem();
            }

        }

    }
}


/**
 * First we ask the used what they would like to do? 
 * Create, Read, Update or Delete an item?
 * 
 * 
 * 
 * **/