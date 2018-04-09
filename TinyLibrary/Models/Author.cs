namespace TinyLibrary.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public bool IsNew { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + About;
        }
    }
}