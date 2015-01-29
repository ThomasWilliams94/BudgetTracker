using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTrackerApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void itsButtonAddNewTransaction_Click(object sender, EventArgs e)
        {
            NewTransaction newTransaction = new NewTransaction();

            newTransaction.Show();
            
        }
    }
}
