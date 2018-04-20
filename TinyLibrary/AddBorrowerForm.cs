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
    public partial class AddBorrowerForm : Form
    {
        ModelRepository repo = new ModelRepository();
        Borrower borrower = new Borrower();

        List<BorrowerType> possibleBorrowerTypes = new List<BorrowerType>();

        public AddBorrowerForm(ModelRepository repo)
        {
            AddBorrowerType();
            InitializeComponent();
        }

        private void AddBorrowerType()
        {
            possibleBorrowerTypes.Add(new BorrowerType
            {
                Id = 1,
                Name = "Student",
                MaxCheckout = 2
            });
            possibleBorrowerTypes.Add(new BorrowerType
            {
                Id = 2,
                Name = "Faculty",
                MaxCheckout = 3
            });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (BorrowerInputsAreValid())
            {
                Borrower borrower = MakeBorrower();
                repo.Borrowers.Add(borrower);
                MessageBox.Show("Borrower saved.");
                ClearInputs();
            }

        }

        private void ClearInputs()
        {
            idBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            borrowerTypeBox.SelectedIndex = -1;
            idBox.Focus();
        }

        private bool BorrowerInputsAreValid()
        {
            return  idBox.Text.NotEmpty()
                    && firstNameBox.Text.NotEmpty()
                    && lastNameBox.Text.NotEmpty()
                    && borrowerTypeBox.Text.NotEmpty();
        }
        private Borrower MakeBorrower()
        {
            return new Borrower
            {
                Id =  int.Parse(idBox.Text),
                FirstName = firstNameBox.Text,
                LastName = lastNameBox.Text,
                BorrowerType = borrowerTypeBox.SelectedItem.ToString()
            };
        }

        private void AddBorrowerForm_Load(object sender, EventArgs e)
        {
            foreach(BorrowerType p in possibleBorrowerTypes)
            {
                borrowerTypeBox.Items.Add(p.Name);
            }
        }
    }
}
