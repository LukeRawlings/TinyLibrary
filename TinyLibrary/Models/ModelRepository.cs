using System.Collections.Generic;
using System.Linq;

namespace TinyLibrary.Models
{
    public class ModelRepository
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

        public void AddBooksToBorrower()
        {
            Book myBook3 = new Book
            {
                ISBN = "123457899999",
                Title = "book3",
                BookAuthors = new List<Author>
                {
                    authors.First()
                },
                Location = "B20",
                Count = 10
            };

            Book myBook4 = new Book
            {
                ISBN = "123457899999",
                Title = "book4",
                BookAuthors = new List<Author>
                {
                    authors.First()
                },
                Location = "B20",
                Count = 10
            };

            Borrower borrower = new Borrower
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                BorrowerType = "Student"
            };
            borrower.BorrowedBooks.Add(myBook3);
            borrower.BorrowedBooks.Add(myBook4);

        }
    }
}
