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
    public partial class AddNewBookForm : Form
    {
        ModelRepository repo = new ModelRepository();
        Book book = new Book();

        public AddNewBookForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach(object obj in authorBox.Items)
            {
                Author author = (Author)obj;
                author.AddedToCurrentBook = false;
            }
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
            }
        }

        private void CheckForExistingAuthor(Author author)
        {
            var possibleMatches = repo.Authors.Where
                (a => author.FirstName == a.FirstName 
                && author.LastName == a.LastName);
            if (possibleMatches.ToList().Count > 0)
                DisplayPossibleMatches(possibleMatches, author);
             else if(!author.AddedToCurrentBook)
                AddNewAuthor(author);
                
        }

        private void AddNewAuthor(Author author)
        {
            AddAuthorToBook(author);
            repo.Authors.Add(author);
            author.AddedToCurrentBook = true;

        }

        private void DisplayPossibleMatches(IEnumerable<Author> possibleMatches, Author author)
        {
            MatchingAuthorsData data = new MatchingAuthorsData
            {
                AddNewBookForm = this,
                PossibleMatches = possibleMatches,
                Book = book,
                InputtedAuthor = author
            };
            
            MatchesForm form = new MatchesForm(data);
            form.ShowDialog();
        }

        public void AddAuthorToBook(Author author)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
