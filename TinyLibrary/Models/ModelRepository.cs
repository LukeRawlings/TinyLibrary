using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyLibrary.Models
{
    class ModelRepository
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }



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

            Authors[2] = new Author
            {
                FirstName = Authors[1].FirstName,
                LastName = Authors[1].LastName,
                About = Authors[1].About
            };
        }

        public void AddBooks()
        {
            
            Book myBook1 = new Book {
                ISBN = "123457899999",
                Title = "book1",
                BookAuthors = new List<Author>
                {
                    Authors[2]
                },
                Location = "B20",
                Count = 10
            };

            Book myBook2 = new Book
            {
                ISBN = "123457899955",
                Title = "book2",
                BookAuthors = Authors.RemoveAt(2),
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
