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
    }
}
/*Add a Book to your Library that exists
Remove a book from your library
Cannot remove a book from the library that doesn’t exist.
Getter/Setters of your properties from your Book class
Getter/ Setters of your properties from your Author class.
Accurate count of books within the library
One edge case of your choice*/