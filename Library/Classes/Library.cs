using System;
using System.Collections;
using System.Collections.Generic;

namespace Library_Lab
{
    public class Library<T> : IEnumerable
    {
        public T[] Books = new T[5];
        public int Count { get; set; }

        public void Add(T book)
        {

            // Add to the Array if book exceeds length
            if (Count == Books.Length)
            {
                Array.Resize(ref Books, Books.Length * 2);
            }
            Books[Count++] = book;
        }
        public void Remove(int idxRemove)
        {
            //iterate through the array. until title == array[] value
            //replace the value with either a null, or shrink array while updating counter

            // B  B  B  X  R  B  
            T[] newBooks = new T[Books.Length - 1];            
            for (int i = 0; i < newBooks.Length; i++)
            {
                if (idxRemove > i) { newBooks[i] = Books[i]; }
                if (idxRemove <= i) { newBooks[i] = Books[i + 1]; }                
            }
                Books = newBooks;

            //IComparable() have the book class as an interface.
            //giving an implementation of the equals methods.
            //or re-factor or remove and look for a

            


            //Take the array 
            //create a NEW array with length -1 
            //iterate through the oldArray -> if Null don't add to newArray
            //oldArray = newArray.

            //books[count--] = book;
        }       
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
