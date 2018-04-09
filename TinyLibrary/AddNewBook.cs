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
    public partial class AddNewBook : Form
    {
        ModelRepository repo = new ModelRepository();
        Book book = new Book();

        public AddNewBook()
        {
            InitializeComponent();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void AddToBookbutton_Click(object sender, EventArgs e)
        {
            if (AuthorInputsAreValid())
            {
                Author author = MakeAuthor();
                CheckForExistingAuthor(author);
                AddAuthorToBook(author);
            }
        }

        private void CheckForExistingAuthor(Author author)
        {
            var possibleMatches = repo.Authors.Where
                (a => author.FirstName == a.FirstName 
                && author.LastName == a.LastName);
            DisplayPossibleMatches(possibleMatches);
        }

        private void DisplayPossibleMatches(IEnumerable<Author> possibleMatches)
        {
            MatchesForm form = new MatchesForm(possibleMatches);
            form.ShowDialog();
        }

        private void AddAuthorToBook(Author author)
        {
            book.BookAuthors.Add(author);
            authorBox.Items.Add(author);

        }

        private bool AuthorInputsAreValid()
        {
            return firstNamebox.Text.NotEmpty() 
                    && lastNamebox.Text.NotEmpty() 
                    && aboutbox.Text.NotEmpty();
        }

        private Author MakeAuthor()
        {
            return new Author
            {
                FirstName = firstNamebox.Text,
                LastName = lastNamebox.Text,
                About = aboutbox.Text
            };
        }
    }
}
