﻿namespace TinyLibrary
{
    partial class MatchesForm
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
            this.authorBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAuthorButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorBox
            // 
            this.authorBox.FormattingEnabled = true;
            this.authorBox.ItemHeight = 20;
            this.authorBox.Location = new System.Drawing.Point(94, 115);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(356, 224);
            this.authorBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following authors match your input: ";
            // 
            // selectAuthorButton
            // 
            this.selectAuthorButton.Location = new System.Drawing.Point(417, 39);
            this.selectAuthorButton.Name = "selectAuthorButton";
            this.selectAuthorButton.Size = new System.Drawing.Size(124, 42);
            this.selectAuthorButton.TabIndex = 2;
            this.selectAuthorButton.Text = "&Select";
            this.selectAuthorButton.UseVisualStyleBackColor = true;
            this.selectAuthorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectAuthorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorBox);
            this.Name = "MatchesForm";
            this.Text = "MatchesForm";
            this.Load += new System.EventHandler(this.MatchesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectAuthorButton;
        private System.Windows.Forms.Button button2;
    }
}