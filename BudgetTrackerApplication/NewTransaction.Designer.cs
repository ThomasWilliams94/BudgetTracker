namespace BudgetTrackerApplication
{
    partial class NewTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itsLongDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itsShortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.itsCategorySelectionDropDown = new System.Windows.Forms.ComboBox();
            this.itsAddToProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.itsProjectSelectionDropDown = new System.Windows.Forms.ComboBox();
            this.itsButtonAddTransaction = new System.Windows.Forms.Button();
            this.itsButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itsLongDescriptionTextBox
            // 
            this.itsLongDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itsLongDescriptionTextBox.Location = new System.Drawing.Point(12, 38);
            this.itsLongDescriptionTextBox.Multiline = true;
            this.itsLongDescriptionTextBox.Name = "itsLongDescriptionTextBox";
            this.itsLongDescriptionTextBox.Size = new System.Drawing.Size(225, 136);
            this.itsLongDescriptionTextBox.TabIndex = 4;
            this.itsLongDescriptionTextBox.Text = "Optional long description...";
            // 
            // itsShortDescriptionTextBox
            // 
            this.itsShortDescriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.itsShortDescriptionTextBox.Name = "itsShortDescriptionTextBox";
            this.itsShortDescriptionTextBox.Size = new System.Drawing.Size(226, 20);
            this.itsShortDescriptionTextBox.TabIndex = 3;
            this.itsShortDescriptionTextBox.Text = "Short Description";
            // 
            // itsDatePicker
            // 
            this.itsDatePicker.Location = new System.Drawing.Point(281, 12);
            this.itsDatePicker.Name = "itsDatePicker";
            this.itsDatePicker.Size = new System.Drawing.Size(200, 20);
            this.itsDatePicker.TabIndex = 6;
            // 
            // itsCategorySelectionDropDown
            // 
            this.itsCategorySelectionDropDown.FormattingEnabled = true;
            this.itsCategorySelectionDropDown.Items.AddRange(new object[] {
            "Add New Category..."});
            this.itsCategorySelectionDropDown.Location = new System.Drawing.Point(281, 53);
            this.itsCategorySelectionDropDown.Name = "itsCategorySelectionDropDown";
            this.itsCategorySelectionDropDown.Size = new System.Drawing.Size(200, 21);
            this.itsCategorySelectionDropDown.Sorted = true;
            this.itsCategorySelectionDropDown.TabIndex = 7;
            this.itsCategorySelectionDropDown.Text = "Select Category";
            // 
            // itsAddToProjectCheckBox
            // 
            this.itsAddToProjectCheckBox.AutoSize = true;
            this.itsAddToProjectCheckBox.Location = new System.Drawing.Point(281, 91);
            this.itsAddToProjectCheckBox.Name = "itsAddToProjectCheckBox";
            this.itsAddToProjectCheckBox.Size = new System.Drawing.Size(178, 17);
            this.itsAddToProjectCheckBox.TabIndex = 8;
            this.itsAddToProjectCheckBox.Text = "Add this transaction to a project.";
            this.itsAddToProjectCheckBox.UseVisualStyleBackColor = true;
            this.itsAddToProjectCheckBox.CheckedChanged += new System.EventHandler(this.itsAddToProjectCheckBox_CheckedChanged);
            // 
            // itsProjectSelectionDropDown
            // 
            this.itsProjectSelectionDropDown.Enabled = false;
            this.itsProjectSelectionDropDown.FormattingEnabled = true;
            this.itsProjectSelectionDropDown.Items.AddRange(new object[] {
            "Add New Project..."});
            this.itsProjectSelectionDropDown.Location = new System.Drawing.Point(281, 118);
            this.itsProjectSelectionDropDown.Name = "itsProjectSelectionDropDown";
            this.itsProjectSelectionDropDown.Size = new System.Drawing.Size(200, 21);
            this.itsProjectSelectionDropDown.TabIndex = 9;
            this.itsProjectSelectionDropDown.Text = "Select Project";
            // 
            // itsButtonAddTransaction
            // 
            this.itsButtonAddTransaction.Location = new System.Drawing.Point(281, 151);
            this.itsButtonAddTransaction.Name = "itsButtonAddTransaction";
            this.itsButtonAddTransaction.Size = new System.Drawing.Size(103, 23);
            this.itsButtonAddTransaction.TabIndex = 10;
            this.itsButtonAddTransaction.Text = "Add Transaction";
            this.itsButtonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // itsButtonCancel
            // 
            this.itsButtonCancel.Location = new System.Drawing.Point(409, 151);
            this.itsButtonCancel.Name = "itsButtonCancel";
            this.itsButtonCancel.Size = new System.Drawing.Size(72, 23);
            this.itsButtonCancel.TabIndex = 11;
            this.itsButtonCancel.Text = "Cancel";
            this.itsButtonCancel.UseVisualStyleBackColor = true;
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 184);
            this.Controls.Add(this.itsButtonCancel);
            this.Controls.Add(this.itsButtonAddTransaction);
            this.Controls.Add(this.itsProjectSelectionDropDown);
            this.Controls.Add(this.itsAddToProjectCheckBox);
            this.Controls.Add(this.itsCategorySelectionDropDown);
            this.Controls.Add(this.itsDatePicker);
            this.Controls.Add(this.itsLongDescriptionTextBox);
            this.Controls.Add(this.itsShortDescriptionTextBox);
            this.Name = "NewTransaction";
            this.Text = "NewTransaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itsLongDescriptionTextBox;
        private System.Windows.Forms.TextBox itsShortDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker itsDatePicker;
        private System.Windows.Forms.ComboBox itsCategorySelectionDropDown;
        private System.Windows.Forms.CheckBox itsAddToProjectCheckBox;
        private System.Windows.Forms.ComboBox itsProjectSelectionDropDown;
        private System.Windows.Forms.Button itsButtonAddTransaction;
        private System.Windows.Forms.Button itsButtonCancel;
    }
}