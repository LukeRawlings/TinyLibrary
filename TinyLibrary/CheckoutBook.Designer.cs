namespace TinyLibrary
{
    partial class CheckoutBook
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
            this.findBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowerIdBox = new System.Windows.Forms.TextBox();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findBookButton
            // 
            this.findBookButton.Location = new System.Drawing.Point(399, 104);
            this.findBookButton.Name = "findBookButton";
            this.findBookButton.Size = new System.Drawing.Size(120, 52);
            this.findBookButton.TabIndex = 0;
            this.findBookButton.Text = "Find Book";
            this.findBookButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BorrowerId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // borrowerIdBox
            // 
            this.borrowerIdBox.Location = new System.Drawing.Point(200, 40);
            this.borrowerIdBox.Name = "borrowerIdBox";
            this.borrowerIdBox.Size = new System.Drawing.Size(131, 26);
            this.borrowerIdBox.TabIndex = 3;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(200, 117);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(131, 26);
            this.isbnBox.TabIndex = 4;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(111, 310);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(137, 55);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(415, 310);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 45);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CheckoutBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 410);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.borrowerIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findBookButton);
            this.Name = "CheckoutBook";
            this.Text = "CheckoutBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBookButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox borrowerIdBox;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button closeButton;
    }
}