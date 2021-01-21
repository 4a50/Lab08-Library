using System;
using System.Collections;
using System.Collections.Generic;

namespace Library_Lab
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[5];
        int count { get; set; }

        public void Add(T book)
        {

            // Add to the Array if book exceeds length
            if (count == books.Length)
            {
                Array.Resize(ref books, books.Length * 2);
            }
            books[count++] = book;


        }
        public void Remove(int idxRemove)
        {
            //iterate through the array. until title == array[] value
            //replace the value with either a null, or shrink array while updating counter

            // B  B  B  X  R  B  
            T[] newBooks = new T[books.Length - 1];            
            for (int i = 0; i < newBooks.Length; i++)
            {
                if (idxRemove > i) { newBooks[i] = books[i]; }
                if (idxRemove <= i) { newBooks[i] = books[i + 1]; }                
            }
                books = newBooks;

            //IComparable() have the book class as an interface.
            //giving an implemetation of the equals methods.
            //or refactor or remove and look for a

            


            //Take the array 
            //create a NEW array with length -1 
            //iterate through the oldArray -> if Null don't add to newArray
            //oldArray = newArray.

            //books[count--] = book;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
