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
            Library<Books> book = new Library<Books>();

        }
/// <summary>
/// This is adding a book, trying to add the SAME book through the method.  Expecting a return
/// of -1 for book already exists.
/// </summary>
/// 
        [Fact]
        public void Adding_Exsisting_Book_To_Library()
        {
            Library<Books> testLib = new Library<Books>();
            testLib.Add(new Books("Test Plan", new Author("Test", "Dummy"), Books.Genre.NonFiction));
            Assert.Equal(-1, Program.AddABook(testLib, Books.Genre.NonFiction, "Test Plan", "Dummy", "Test"));
        }
    }
}
