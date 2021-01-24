using System;
using Xunit;
using Library_Lab;

namespace LibraryTesting
{
    public class LibraryUnitTest
    {
        [Fact]
        public void TestIfItemIsRemovedFromList()
        {
            Library<Book> book = new Library<Book>();

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
            //TODO: Add Remove When method works
            Assert.Equal(2, testLib.Count);
            
        }
    }
}
/*Add a Book to your Library that exists <----------------- Complete
Remove a book from your library
Cannot remove a book from the library that doesn’t exist.
Getter/Setters of your properties from your Book class
Getter/ Setters of your properties from your Author class.
Accurate count of books within the library
One edge case of your choice*/