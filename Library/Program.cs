using System;

namespace Library_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Library<Books> nyPubLib = new Library<Books>();
            LoadBooks(nyPubLib);
            UserInterface();
            //foreach (Books b in nyPubLib)
            //{
            //Console.WriteLine(b.Title);
            //}
            //nyPubLib.Remove(3);
            //foreach (Books b in nyPubLib)
            //{
            //    Console.WriteLine(b.Title);
            //}

        }
        static void UserInterface(Library<Books> library)
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Welcome to The Library.  Make a selection");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add A Book");
                Console.WriteLine("3. Borrow A Book");
                Console.WriteLine("4. Return A Book");
                Console.WriteLine("5. View Book Bag");
                Console.WriteLine("6. EXIT");
                Console.WriteLine();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ViewLibrary(library);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection.  Try Again");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        static void ViewLibrary(Library<Books> lib)
        {
            Console.WriteLine("Current Books Available At The Library");
            Console.WriteLine();
            int counter = 0;
            foreach (Books b in lib)
            {                
                Console.WriteLine($"{++counter} {b.Title}  {b.Author.LastName}, {b.Author.FirstName}  Genre: {b.BookGenre}");
            }
        }
        static void LoadBooks(Library<Books> libToLoad)
        {
            libToLoad.Add(new Books("A Book", new Author("Someone", "Famous"), Books.Genre.Mystery));
            libToLoad.Add(new Books("Another Book", new Author("S. Else0", "Famoose"), Books.Genre.Adventure));
            libToLoad.Add(new Books("Who Cut the Cheese?", new Author("Not", "Telling"), Books.Genre.Mystery));
            libToLoad.Add(new Books("An Interesting Book", new Author("John", "Boring"), Books.Genre.AutoBiography));
            libToLoad.Add(new Books("A Brief Introduction to Dishwasher", new Author("John", "Cokos"), Books.Genre.NonFiction));
        }




    }
}
