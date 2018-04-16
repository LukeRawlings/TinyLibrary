using System.Collections.Generic;
using System.Linq;

namespace TinyLibrary.Models
{
    class ModelRepository
    {
        public List<Book> Books { get; set; } = new List<Book>();
        private List<Author> authors = new List<Author>();
        public List<Borrower> Borrowers { get; set; } = new List<Borrower>();

        public ModelRepository()
        {
            AddAuthors();
            AddBooks();
        }


        public void AddAuthors()
        {
            for (int i = 10; i <= 20; i++)
            {
                authors.Add(new Author
                {
                    FirstName = "Bill" + i.ToString(),
                    LastName = "Gates" + i.ToString(),
                    About = "Creator of Microsoft" + i.ToString()
                });

            }


        }

        public void AddBooks()
        {

            Book myBook1 = new Book
            {
                ISBN = "123457899999",
                Title = "book1",
                BookAuthors = new List<Author>
                {
                    authors.First()
                },
                Location = "B20",
                Count = 10
            };

            Book myBook2 = new Book
            {
                ISBN = "123457899955",
                Title = "book2",
                BookAuthors = authors.Skip(1).ToList(),
                Location = "B20",
                Count = 10
            };
        }
    }
}
