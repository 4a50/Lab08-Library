using System;
using Xunit;
using Library_Lab;
using System.Collections.Generic;

namespace LibraryTesting
{
    public class LibraryUnitTest
    {
        /// <summary>
        /// Test to verify book has been removed from the library.
        /// </summary>
        [Fact]
        public void Remove_Book_From_Library()
        {
            Library<Book> lib = new Library<Book>();
            lib.Add(new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction));
            lib.Add(new Book("Magicians, Martyrs and Madmen", new Author("Leon", "Zundinger"), Book.Genre.NonFiction));
            lib.Add(new Book("Who Cut the Cheese?", new Author("Not", "Telling"), Book.Genre.Mystery));
            lib.Add(new Book("An Interesting Book", new Author("John", "Boring"), Book.Genre.AutoBiography));
            lib.Add(new Book("A Brief Introduction to Dishwasher", new Author("John", "Cokos"), Book.Genre.NonFiction));
            lib.Remove(1);
            //Look at all the books in the library.
            //Ensure book removed is not present.
            bool isEqual = false;
            for (int i = 0; i < lib.Books.Length; i++)
            {
                if (lib.Books[i].Title == "Magicians, Martyrs and Madmen")
                {
                    isEqual = true;
                }
            }
                Assert.False(isEqual);

        }
        /// <summary>
        /// This is adding a book, trying to add the SAME book through the method.  Expecting a return
        /// of -1 for book already exists.
        /// </summary>
        /// 
        [Fact]
        public void Adding_Exsisting_Book_To_Library()
        {
            Library<Book> testLib = new Library<Book>();
            testLib.Add(new Book("Test Plan", new Author("Test", "Dummy"), Book.Genre.NonFiction));
            Assert.Equal(-1, Program.AddABook(testLib, Book.Genre.NonFiction, "Test Plan", "Dummy", "Test"));
        }
        /// <summary>
        /// Will add and remove some book to ensure an accurate count
        /// </summary>
        [Fact]
        public void Accurate_Count_Of_Books_In_Library()
        {
            Library<Book> testLib = new Library<Book>();
            testLib.Add(new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction));
            testLib.Add(new Book("Magicians, Martyrs and Madmen", new Author("Leon", "Zundinger"), Book.Genre.NonFiction));
            testLib.Add(new Book("Who Cut the Cheese?", new Author("Not", "Telling"), Book.Genre.Mystery));
            testLib.Add(new Book("An Interesting Book", new Author("John", "Boring"), Book.Genre.AutoBiography));
            testLib.Add(new Book("A Brief Introduction to Dishwasher", new Author("John", "Cokos"), Book.Genre.NonFiction));
            testLib.Remove(0);
            testLib.Remove(0);
            //TODO: Add Remove When method works
            Assert.Equal(3, testLib.Count);
            
        }
        [Fact]
        public void Remove_A_Book_That_Does_Not_Exist()
        {
            Library<Book> lib = new Library<Book>();
            lib.Add(new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction));
            lib.Add(new Book("Magicians, Martyrs and Madmen", new Author("Leon", "Zundinger"), Book.Genre.NonFiction));
            lib.Add(new Book("Who Cut the Cheese?", new Author("Not", "Telling"), Book.Genre.Mystery));
            lib.Add(new Book("An Interesting Book", new Author("John", "Boring"), Book.Genre.AutoBiography));
            lib.Add(new Book("A Brief Introduction to Dishwasher", new Author("John", "Cokos"), Book.Genre.NonFiction));

            Assert.False(Program.BorrowABook(lib, new List<Book>(), "6"));
            Assert.False(Program.BorrowABook(lib, new List<Book>(), "Bob"));
        }
        [Fact]
        public void Test_Use_Of_Property_Title_In_Book()
        {
            
            Book book = new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction);            
            Assert.Equal("Tobin's Spirit Guide", book.Title);
        }
        [Fact]
        public void Test_Use_Of_Property_Author_In_Book()
        {
            Book book = new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction);            
            Assert.Equal("John Horace", book.Author.FirstName);
        }
        [Fact]
        public void Test_Use_Of_Property_Genre_In_Book()
        {
            Book book = new Book("Tobin's Spirit Guide", new Author("John Horace", "Tobin"), Book.Genre.NonFiction);
            Assert.Equal(2, (int)book.BookGenre);
        }
        [Fact]
        public void Test_Use_Of_Property_FirstName_In_Author()
        {
            Author author = new Author("John Horace", "Tobin");
            Assert.Equal("John Horace", author.FirstName);
        }
        [Fact]
        public void Test_Use_Of_Property_Last_Name_In_Author()
        {
            Author author = new Author("John Horace", "Tobin");
            Assert.Equal("Tobin", author.LastName);
        }
        [Fact]
        public void Test_If_Blank_Input_When_Adding_Title()
        {
            Library<Book> testLib = new Library<Book>();
            Assert.Equal(-1, Program.AddABook(testLib, Book.Genre.Adventure, "", "Mouse", "Mickey"));
        }


    }
}
/*Add a Book to your Library that exists <----------------- Complete
Remove a book from your library  <------------------------- Complete
Cannot remove a book from the library that doesn’t exist. < Complete
Getter/Setters of your properties from your Book class <--- Complete
Getter/ Setters of your properties from your Author class.< Complete
Accurate count of books within the library <--------------- Complete
One edge case of your choice
*/