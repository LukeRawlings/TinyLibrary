namespace TinyLibrary
{
    partial class AddNewBookForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.firstNamebox = new System.Windows.Forms.TextBox();
            this.lastNamebox = new System.Windows.Forms.TextBox();
            this.aboutbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddToBookbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.authorBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(474, 411);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(124, 55);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(38, 62);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(47, 20);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Count";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(134, 58);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(194, 26);
            this.isbnTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(134, 118);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(194, 26);
            this.titleTextBox.TabIndex = 6;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(134, 185);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(194, 26);
            this.countTextBox.TabIndex = 8;
            // 
            // saveBookButton
            // 
            this.saveBookButton.Location = new System.Drawing.Point(214, 411);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(142, 55);
            this.saveBookButton.TabIndex = 10;
            this.saveBookButton.Text = "&Submit";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstNamebox
            // 
            this.firstNamebox.Location = new System.Drawing.Point(120, 40);
            this.firstNamebox.MaxLength = 20;
            this.firstNamebox.Name = "firstNamebox";
            this.firstNamebox.Size = new System.Drawing.Size(188, 26);
            this.firstNamebox.TabIndex = 11;
            // 
            // lastNamebox
            // 
            this.lastNamebox.Location = new System.Drawing.Point(120, 97);
            this.lastNamebox.MaxLength = 20;
            this.lastNamebox.Name = "lastNamebox";
            this.lastNamebox.Size = new System.Drawing.Size(188, 26);
            this.lastNamebox.TabIndex = 12;
            // 
            // aboutbox
            // 
            this.aboutbox.Location = new System.Drawing.Point(120, 162);
            this.aboutbox.MaxLength = 1000;
            this.aboutbox.Name = "aboutbox";
            this.aboutbox.Size = new System.Drawing.Size(188, 26);
            this.aboutbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddToBookbutton);
            this.groupBox1.Controls.Add(this.aboutbox);
            this.groupBox1.Controls.Add(this.firstNamebox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lastNamebox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(434, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 352);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authors";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddToBookbutton
            // 
            this.AddToBookbutton.Location = new System.Drawing.Point(120, 268);
            this.AddToBookbutton.Name = "AddToBookbutton";
            this.AddToBookbutton.Size = new System.Drawing.Size(146, 55);
            this.AddToBookbutton.TabIndex = 18;
            this.AddToBookbutton.Text = "Add to Book";
            this.AddToBookbutton.UseVisualStyleBackColor = true;
            this.AddToBookbutton.Click += new System.EventHandler(this.AddToBookbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.authorBox);
            this.groupBox2.Controls.Add(this.isbnTextBox);
            this.groupBox2.Controls.Add(this.ISBN);
            this.groupBox2.Controls.Add(this.titleTextBox);
            this.groupBox2.Controls.Add(this.countTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(28, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 363);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book";
            // 
            // authorBox
            // 
            this.authorBox.FormattingEnabled = true;
            this.authorBox.ItemHeight = 20;
            this.authorBox.Location = new System.Drawing.Point(134, 242);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(229, 104);
            this.authorBox.TabIndex = 9;
            // 
            // AddNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveBookButton);
            this.Controls.Add(this.closeButton);
            this.Name = "AddNewBookForm";
            this.Text = "AddNewBook";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.TextBox firstNamebox;
        private System.Windows.Forms.TextBox lastNamebox;
        private System.Windows.Forms.TextBox aboutbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddToBookbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox authorBox;
    }
}