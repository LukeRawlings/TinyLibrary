using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TinyLibrary.Models;

namespace TinyLibrary
{
    public partial class AddNewBookForm : Form
    {
        ModelRepository repo = new ModelRepository();
        Book book = new Book();

        public AddNewBookForm(ModelRepository repo)
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (book.BookAuthors.Count > 0)
            {
                AddFieldsToBook(book);
                repo.Books.Add(book);
                ClearBookFields();
                book = new Book();
            }
            else
            {
                MessageBox.Show("Gotta add an author.");

            }
        }

        private void ClearBookFields()
        {
            isbnTextBox.Clear();
            titleTextBox.Clear();
            countTextBox.Clear();
            authorBox.Items.Clear();
            locationBox.Clear();
            yearBox.Clear();
        }

        private void AddFieldsToBook(Book book)
        {
            book.ISBN = isbnTextBox.Text;
            book.Title = titleTextBox.Text;
            book.Location = locationBox.Text;
            book.Year = int.Parse(yearBox.Text);
            book.Count = int.Parse(countTextBox.Text);
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void AddToBookbutton_Click(object sender, EventArgs e)
        {
            if (AuthorInputsAreValid())
            {
                Author author = MakeAuthor();
                List<Author> matches = GetMatchingAuthors(author);
                if (matches.Count == 0)
                    AddAuthorToBook(author);
                else
                    DisplayPossibleMatchesForAuthor(matches, author);
            }
        }

        private List<Author> GetMatchingAuthors(Author author)
        {
            var authors = repo
                .Books
                .SelectMany(b => b.BookAuthors)
                .ToList();

            authors.AddRange(book.BookAuthors);

            var possibleMatches = authors.Where
                (a => author.FirstName == a.FirstName
                && author.LastName == a.LastName);

            return possibleMatches.ToList();
        }


        private void DisplayPossibleMatchesForAuthor(IEnumerable<Author> possibleMatches, Author author)
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


    }
}
