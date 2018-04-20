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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findBookButton
            // 
            this.findBookButton.Location = new System.Drawing.Point(315, 25);
            this.findBookButton.Name = "findBookButton";
            this.findBookButton.Size = new System.Drawing.Size(120, 52);
            this.findBookButton.TabIndex = 0;
            this.findBookButton.Text = "Find Book";
            this.findBookButton.UseVisualStyleBackColor = true;
            this.findBookButton.Click += new System.EventHandler(this.findBookButton_Click);
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
            this.label2.Location = new System.Drawing.Point(23, 41);
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
            this.isbnBox.Location = new System.Drawing.Point(116, 38);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(131, 26);
            this.isbnBox.TabIndex = 4;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(88, 515);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(137, 55);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(392, 515);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 45);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultsBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.authorBox);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.findBookButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isbnBox);
            this.groupBox1.Location = new System.Drawing.Point(81, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 377);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(116, 143);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(131, 26);
            this.titleBox.TabIndex = 7;
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(119, 93);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(131, 26);
            this.authorBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Results:";
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.ItemHeight = 20;
            this.resultsBox.Location = new System.Drawing.Point(119, 225);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(215, 124);
            this.resultsBox.TabIndex = 10;
            // 
            // CheckoutBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.borrowerIdBox);
            this.Controls.Add(this.label1);
            this.Name = "CheckoutBook";
            this.Text = "CheckoutBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}