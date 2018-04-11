using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    class ModelRepository
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Author> Authors { get; set; } = new List<Author>();

        public ModelRepository()
        {
            AddAuthors();
            AddBooks();
        }


        public void AddAuthors()
        {
            for(int i = 10; i <= 20; i++)
            {                
                Authors.Add(new Author
                {
                    FirstName = "Bill"+ i.ToString(),
                    LastName = "Gates" + i.ToString(), 
                    About = "Creator of Microsoft" + i.ToString()
                });
                
            }

            
        }

        public void AddBooks()
        {

            Book myBook1 = new Book {
                ISBN = "123457899999",
                Title = "book1",
                BookAuthors = new List<Author>
                {
                    Authors.First()
                },
                Location = "B20",
                Count = 10
            };

            Book myBook2 = new Book
            {
                ISBN = "123457899955",
                Title = "book2",
                BookAuthors = Authors.Skip(1).ToList(),
                Location = "B20",
                Count = 10
            };

            /*public string ISBN
            public string Title
            public Author Author 
            public string Location
            public int Count */
        }
    }
}
