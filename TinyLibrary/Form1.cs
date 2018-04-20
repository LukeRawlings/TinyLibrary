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
    public partial class Form1 : Form
    {
        ModelRepository repo = new ModelRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            AddNewBookForm form = new AddNewBookForm(repo);
            form.ShowDialog();
        }

        private void addBorrowerButton_Click(object sender, EventArgs e)
        {
            AddBorrowerForm form = new AddBorrowerForm(repo);
            form.ShowDialog();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CheckoutBook form = new CheckoutBook(repo);
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
