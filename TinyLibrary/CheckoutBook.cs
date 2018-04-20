using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyLibrary.Models;


namespace TinyLibrary
{
    public partial class CheckoutBook : Form
    {
        public ModelRepository repo { get; set; }

        public CheckoutBook(ModelRepository repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            repo.AddBooksToBorrower();
        }

        private void findBookButton_Click(object sender, EventArgs e)
        {
            List<string> filters = GetFilters();

            string isbn = isbnBox.Text;
            string author = authorBox.Text;
            string title = titleBox.Text;
            var books = repo.Books;
            List<Book> filteredBooks = null;

            if (isbn)

                if (!string.IsNullOrEmpty(isbn))
                {
                    filteredBooks = books.Where(b => b.ISBN == isbn).ToList();
                }
                else
                {
                    if (!string.IsNullOrEmpty(author))
                    {
                        filteredBooks = books.Where(b => b.BookAuthors.Exists
                            (a => a.ToString() == author)).ToList();
                    }
                    else
                    {

                    }
                }




        }

        private List<string> GetFilters() =>        
            new List<string>
            {
                isbnBox.Text,
                authorBox.Text,
                titleBox.Text
            }
            .Where(f => !string.IsNullOrEmpty(f))
            .ToList();
        
    }
}
