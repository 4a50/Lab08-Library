namespace Library_Lab
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author()
        {

        }
        public Author(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
