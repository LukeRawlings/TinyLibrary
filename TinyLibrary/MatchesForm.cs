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
    public partial class MatchesForm : Form
    {
        IEnumerable<Author> authors;

        public MatchesForm(IEnumerable<Author> possibleMatches)
        {
            InitializeComponent();
            authors = possibleMatches;

        }

        private void MatchesForm_Load(object sender, EventArgs e)
        {
            foreach(Author a in authors)
            {
                authorBox.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
