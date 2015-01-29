namespace BudgetTrackerApplication
{
    partial class MainForm
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
            this.itsButtonAddNewTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itsButtonAddNewTransaction
            // 
            this.itsButtonAddNewTransaction.Location = new System.Drawing.Point(546, 470);
            this.itsButtonAddNewTransaction.Name = "itsButtonAddNewTransaction";
            this.itsButtonAddNewTransaction.Size = new System.Drawing.Size(91, 42);
            this.itsButtonAddNewTransaction.TabIndex = 0;
            this.itsButtonAddNewTransaction.Text = "Add New Transaction";
            this.itsButtonAddNewTransaction.UseVisualStyleBackColor = true;
            this.itsButtonAddNewTransaction.Click += new System.EventHandler(this.itsButtonAddNewTransaction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 524);
            this.Controls.Add(this.itsButtonAddNewTransaction);
            this.Name = "MainForm";
            this.Text = "Budget Tracker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itsButtonAddNewTransaction;
    }
}

