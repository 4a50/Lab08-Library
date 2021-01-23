namespace Library_Lab
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre BookGenre { get; set; }
        public enum Genre
        {
            Fiction = 1,
            NonFiction,
            AutoBiography,
            SciFi,
            Adventure,
            Mystery
        }
        //CodeReview
        
        public Book()
        {

        }
        //
        
        public Book(string title, Author author, Genre genre)
        {
            Title = title;
            Author = author;
            BookGenre = genre;
            
        }
    }
}
