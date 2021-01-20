using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Lab
{
    public class Books
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public enum Genre
        {
            Fiction,
            NonFiction,
            AutoBiography,
            SciFi,
            Adventure,
            Mystery
        }
    }
}
