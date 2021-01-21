namespace Library_Lab
{
    public class Books
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre BookGenre { get; set; }
        public enum Genre
        {
            Fiction,
            NonFiction,
            AutoBiography,
            SciFi,
            Adventure,
            Mystery
        }

        public Books(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            BookGenre = genre;
            
        }
    }
}
