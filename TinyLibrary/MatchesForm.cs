using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TinyLibrary.Models;

namespace TinyLibrary
{
    public partial class MatchesForm : Form
    {
        AddNewBookForm addNewBookForm;
        Author inputtedAuthor;
        Book book;
        IEnumerable<Author> authors;

        public MatchesForm(MatchingAuthorsData data)
        {
            InitializeComponent();
            addNewBookForm = data.AddNewBookForm;
            inputtedAuthor = data.InputtedAuthor;
            authors = data.PossibleMatches;
            book = data.Book;
        }

        private void MatchesForm_Load(object sender, EventArgs e)
        {
            foreach (Author a in authors)
            {
                authorBox.Items.Add(a);
            }
            authorBox.SelectedIndex = 0;
        }

        private void selectAuthorButton_Click(object sender, EventArgs e)
        {
            Author author = (Author)authorBox.SelectedItem;
            addNewBookForm.AddAuthorToBook(author);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            addNewBookForm.AddAuthorToBook(inputtedAuthor);
            Close();
        }


    }
}
