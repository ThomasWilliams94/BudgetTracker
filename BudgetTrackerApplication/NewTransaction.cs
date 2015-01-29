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
    public partial class NewTransaction : Form
    {
        public NewTransaction()
        {
            InitializeComponent();
        }

        private void itsAddToProjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.itsAddToProjectCheckBox.Checked == true)
            {
                this.itsProjectSelectionDropDown.Enabled = true;
            }
            else
            {
                this.itsProjectSelectionDropDown.Enabled = false;
            }
            // is another way of doing this the following:
            // this.itsProjectSelectionDropDown.Enabled = this.itsAddToProjectCheckBox;
        }

        

        
    }
}
