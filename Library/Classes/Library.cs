using System;
using System.Collections;
using System.Collections.Generic;

namespace Library_Lab
{
    class Library<T> : IEnumerable
    {
        T[] books = new T[5];
        int count { get; set; }

        public void Add(T book)
        {


            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    count++;
                    break;
                }
                else
                {

                    // Add to the Array if book exceeds length
                    if (count == books.Length)
                    {
                        Array.Resize(ref books, books.Length * 2);
                    }
                    books[count++] = book;
                }
            }
        }
        public void Remove(T book)
        {
            //iterate through the array. until title == array[] value
            //replace the value with either a null, or shrink array while updating counter
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book) { }
            }

            
            //Take the array 
            //create a NEW array with length -1 
            //iterate through the oldArray -> if Null don't add to newArray
            //oldArray = newArray.

            books[count--] = book;
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
