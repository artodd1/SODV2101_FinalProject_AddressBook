﻿
namespace AddressBook.Forms
{
    partial class Registration
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
            this.maskedTextBoxFirstName = new System.Windows.Forms.MaskedTextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelCreateUserTitle = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.maskedTextBoxLastName = new System.Windows.Forms.MaskedTextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.maskedTextBoxUsername = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // maskedTextBoxFirstName
            // 
            this.maskedTextBoxFirstName.Location = new System.Drawing.Point(175, 108);
            this.maskedTextBoxFirstName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.maskedTextBoxFirstName.Name = "maskedTextBoxFirstName";
            this.maskedTextBoxFirstName.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBoxFirstName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 111);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(123, 25);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelCreateUserTitle
            // 
            this.labelCreateUserTitle.AutoSize = true;
            this.labelCreateUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUserTitle.Location = new System.Drawing.Point(116, 42);
            this.labelCreateUserTitle.Name = "labelCreateUserTitle";
            this.labelCreateUserTitle.Size = new System.Drawing.Size(244, 32);
            this.labelCreateUserTitle.TabIndex = 2;
            this.labelCreateUserTitle.Text = "Create New User";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(14, 211);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(158, 25);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email Address:";
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(175, 208);
            this.maskedTextBoxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBoxEmail.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(14, 161);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(122, 25);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name:";
            // 
            // maskedTextBoxLastName
            // 
            this.maskedTextBoxLastName.Location = new System.Drawing.Point(175, 158);
            this.maskedTextBoxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxLastName.Name = "maskedTextBoxLastName";
            this.maskedTextBoxLastName.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBoxLastName.TabIndex = 5;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(15, 261);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(117, 25);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username:";
            // 
            // maskedTextBoxUsername
            // 
            this.maskedTextBoxUsername.Location = new System.Drawing.Point(176, 258);
            this.maskedTextBoxUsername.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxUsername.Name = "maskedTextBoxUsername";
            this.maskedTextBoxUsername.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBoxUsername.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(14, 311);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(113, 25);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password:";
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(175, 308);
            this.maskedTextBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(302, 30);
            this.maskedTextBoxPassword.TabIndex = 9;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(174, 397);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(186, 45);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Create User";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(491, 580);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.maskedTextBoxUsername);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.maskedTextBoxLastName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.labelCreateUserTitle);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.maskedTextBoxFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.MouseEnter += new System.EventHandler(this.Registration_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Registration_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelCreateUserTitle;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLastName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}