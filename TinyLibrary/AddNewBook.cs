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

        private void button1_Click(object sender, EventArgs e)
        {

            if (AuthorInputsAreValid())
            {
                Author author = MakeAuthor();
            }
        }

        private bool AuthorInputsAreValid()
        {
            return firstNamebox.Text.NotEmpty() 
                    && lastNamebox.Text.NotEmpty() 
                    && aboutbox.Text.NotEmpty();


        }

        private Author MakeAuthor()
        {
            
            Author author = new Author
            {       
                FirstName = firstNamebox.Text,
                LastName = lastNamebox.Text,
                About = aboutbox.Text
            }; 
            
            return author;
        }
    }
}
