using System;
using System.Collections.Generic;

namespace Library_Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library<Books> nyPubLib = new Library<Books>();
            List<Books> BookBag = new List<Books>();
            LoadBooks(nyPubLib);
            UserInterface(nyPubLib);
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
        static void ViewLibrary(Library<Books> lib)
        {
            
            int counter = 0;
            foreach (Books b in lib)
            {
                Console.WriteLine($"{++counter}.  {b.Title}");
                Console.WriteLine($"\t{b.Author.LastName}, {b.Author.FirstName}");
                Console.WriteLine($"\t{b.BookGenre}");
            }
        }
        static void AddABookInterface(Library<Books> lib)
        {
            //TODO: Determine what to do if the book already exsists.
            int counter = 0;
            Books.Genre genre;
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author Last Name: ");
            string authorLast = Console.ReadLine();
            Console.Write("Author First Name: ");
            string authorFirst = Console.ReadLine();
            Console.WriteLine("Please Choose From the following Genres");


            foreach (Object value in Enum.GetValues(typeof(Books.Genre)))
            {
                Console.WriteLine($"{++counter}. {(Books.Genre)value}");
            }
            Console.WriteLine();
            string userGenre = Console.ReadLine();
            int.TryParse(userGenre, out int genreNum);
            genre = (Books.Genre)Enum.ToObject(typeof(Books.Genre), --genreNum);
            AddABook(lib, genre, title, authorLast, authorFirst);
        }

        public static int AddABook(Library<Books> lib, Books.Genre genre, string title, string authorLast, string authorFirst)
        {
            foreach (Books b in lib)
            {
                if (b.Title == title && b.Author.LastName == authorLast && b.Author.FirstName == authorFirst &&
                    (int)b.BookGenre == (int)genre)
                {
                    Console.WriteLine("Book Already Exists!  Returning to Main.");                   
                    return -1;
                }
            }
            lib.Add(new Books(title, new Author(authorFirst, authorLast), genre));
            return 0;
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
