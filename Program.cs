namespace BookMan
{
    using BookMan.Controllers;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var controller = new BookController();

            while (true)
            {
                Console.WriteLine(@"
Book Manager
1. View all books
2. View a single book
3. Delete a book
4. Search books
5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        controller.List();
                        break;
                    case 2:
                    case 3:
                        Console.Write("Enter book ID: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            if (choice == 2) controller.Single(id);
                            else controller.Delete(id);
                        }
                        else Console.WriteLine("Invalid ID.");
                        break;
                    case 4:
                        Console.Write("Enter keyword to search: ");
                        controller.Search(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
