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
