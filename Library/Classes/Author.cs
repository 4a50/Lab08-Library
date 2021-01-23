namespace Library_Lab
{
    /// <summary>
    /// Author Class to store details about an Author of a Title
    /// </summary>
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
