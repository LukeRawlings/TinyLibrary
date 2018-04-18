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
        ModelRepository repo = new ModelRepository();


        public CheckoutBook()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            repo.AddBooksToBorrower();
        }
    }
}
