using System;
using System.Collections.Generic;

namespace Library_Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library<Book> nyPubLib = new Library<Book>();
            List<Book> BookBag = new List<Book>();
            LoadBooks(nyPubLib);            
            UserInterface(nyPubLib, BookBag);
            
            

        }
        static void UserInterface(Library<Book> library, List<Book> bookBag)
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Welcome to The Library.  Make a selection");
                Console.WriteLine("------------------------------------------\n");                
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add A Book");
                Console.WriteLine("3. Borrow A Book");
                Console.WriteLine("4. Return A Book");
                Console.WriteLine("5. View Book Bag");
                Console.WriteLine("6. EXIT\n");                
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Current Books Available At The Library");
                        Console.WriteLine();
                        ViewLibrary(library);
                        Console.ReadKey();                        
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Add A Book");
                        Console.WriteLine();
                        AddABookInterface(library);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("The Following Books are in your BookBag");
                        Console.WriteLine("---------------------------------------");
                        ViewBookBag(bookBag);
                        Console.WriteLine("\n\nPress Any Key to Return To Main");
                        Console.ReadKey();
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
                Console.Clear();
            }
        }
        static void ViewLibrary(Library<Book> lib)
        {
            
            int counter = 0;
            foreach (Book b in lib)
            {
                Console.WriteLine($"{++counter}.  {b.Title}");
                Console.WriteLine($"\t{b.Author.LastName}, {b.Author.FirstName}");
                Console.WriteLine($"\t{b.BookGenre}");
            }
        }
        static void AddABookInterface(Library<Book> lib)
        {
            //TODO: Determine what to do if the book already exists.
            int counter = 0;
            Book.Genre genre;
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author Last Name: ");
            string authorLast = Console.ReadLine();
            Console.Write("Author First Name: ");
            string authorFirst = Console.ReadLine();
            Console.WriteLine("Please Choose From the following Genres");


            foreach (Object value in Enum.GetValues(typeof(Book.Genre)))
            {
                Console.WriteLine($"{++counter}. {(Book.Genre)value}");
            }
            Console.WriteLine();
            string userGenre = Console.ReadLine();
            int.TryParse(userGenre, out int genreNum);
            //Get hash code another way to transfer the int to the enum?
            genre = (Book.Genre)Enum.ToObject(typeof(Book.Genre), genreNum);
            AddABook(lib, genre, title, authorLast, authorFirst);
        }

        public static int AddABook(Library<Book> lib, Book.Genre genre, string title, string authorLast, string authorFirst)
        {
            foreach (Book b in lib)
            {
                if (b.Title == title && b.Author.LastName == authorLast && b.Author.FirstName == authorFirst &&
                    (int)b.BookGenre == (int)genre)
                {
                    Console.WriteLine("Book Already Exists!  Returning to Main.");                   
                    return -1;
                }
            }
            lib.Add(new Book(title, new Author(authorFirst, authorLast), genre));
            return 0;
        }

        public static void ReturnABook(Library<Book> lib, List<Book> bookBag)
        {
            bool goodInput = false;
            int counter = 0;
            int idx = 0;
            Book selectBook = new Book();
            //View Book bag
            ViewBookBag(bookBag);            
            //Choose a number.
            while (goodInput == false)
            {
                Console.WriteLine("Select A Book To Return to the Library");
                try {
                    string userInput = Console.ReadLine();
                    idx = int.Parse(userInput) - 1;
                    goodInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Entry.  Please try again.");
                    Console.ReadKey();
                }

            }
            //iterate
            foreach (Book b in bookBag)
            // when counter + 1 = number chosen.  
            //  set the book to a var
            //  break the loop
            {
                if (counter == idx)
                {
                    selectBook = b;
                    break;
                }
                counter++;
            }
            // using the counter run the add book to library.
            lib.Add(selectBook);
            // remove the book from the BookBag via .Remove
            bookBag.Remove(selectBook);
            
            

        }
        

        static void ViewBookBag(List<Book> bookBag)
        {
            if (bookBag.Count == 0) { Console.WriteLine( "\nThere are no books in your bag!"); }
            else
            {
                int counter = 0;
                foreach (Book b in bookBag)
                {                    
                    Console.WriteLine($"{++counter}.  {b.Title}");
                }
            }
        }
        static void LoadBooks(Library<Book> libToLoad)
        {
            libToLoad.Add(new Book("A Book", new Author("Someone", "Famous"), Book.Genre.Mystery));
            libToLoad.Add(new Book("Another Book", new Author("S. Else", "Famoose"), Book.Genre.Adventure));
            libToLoad.Add(new Book("Who Cut the Cheese?", new Author("Not", "Telling"), Book.Genre.Mystery));
            libToLoad.Add(new Book("An Interesting Book", new Author("John", "Boring"), Book.Genre.AutoBiography));
            libToLoad.Add(new Book("A Brief Introduction to Dishwasher", new Author("John", "Cokos"), Book.Genre.NonFiction));
            //Class Code Review
            Book johnsBook = new Book()
            {
                Title = "Delivery Woes",
                Author = new Author()
                {
                    FirstName = "John",
                    LastName = "Cokos"
                },
                BookGenre = Book.Genre.Adventure
            };
            libToLoad.Add(johnsBook);
            //
        }
        
    }
}
