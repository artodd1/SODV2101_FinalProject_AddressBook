namespace AddressBook
{
    partial class UserInfoDisplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContactMain = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelMainRelationship = new System.Windows.Forms.Label();
            this.labelMainHome = new System.Windows.Forms.Label();
            this.labelMainEmail = new System.Windows.Forms.Label();
            this.labelMainPhoneNumber = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelContactHead = new System.Windows.Forms.Panel();
            this.iconButtonEdit = new FontAwesome.Sharp.IconButton();
            this.labelNameLarge = new System.Windows.Forms.Label();
            this.roundPictureBox1 = new AddressBook.RoundPictureBox();
            this.panel1.SuspendLayout();
            this.panelContactMain.SuspendLayout();
            this.panelContactHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelContactMain);
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Controls.Add(this.panelContactHead);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 678);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 1);
            this.panel2.TabIndex = 5;
            // 
            // panelContactMain
            // 
            this.panelContactMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelContactMain.Controls.Add(this.labelBirthday);
            this.panelContactMain.Controls.Add(this.labelMainRelationship);
            this.panelContactMain.Controls.Add(this.labelMainHome);
            this.panelContactMain.Controls.Add(this.labelMainEmail);
            this.panelContactMain.Controls.Add(this.labelMainPhoneNumber);
            this.panelContactMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContactMain.Location = new System.Drawing.Point(0, 291);
            this.panelContactMain.Name = "panelContactMain";
            this.panelContactMain.Size = new System.Drawing.Size(884, 387);
            this.panelContactMain.TabIndex = 6;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelBirthday.Location = new System.Drawing.Point(56, 271);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(97, 27);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelMainRelationship
            // 
            this.labelMainRelationship.AutoSize = true;
            this.labelMainRelationship.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainRelationship.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMainRelationship.Location = new System.Drawing.Point(56, 214);
            this.labelMainRelationship.Name = "labelMainRelationship";
            this.labelMainRelationship.Size = new System.Drawing.Size(134, 27);
            this.labelMainRelationship.TabIndex = 3;
            this.labelMainRelationship.Text = "Relationship:";
            // 
            // labelMainHome
            // 
            this.labelMainHome.AutoSize = true;
            this.labelMainHome.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMainHome.Location = new System.Drawing.Point(56, 157);
            this.labelMainHome.Name = "labelMainHome";
            this.labelMainHome.Size = new System.Drawing.Size(158, 27);
            this.labelMainHome.TabIndex = 2;
            this.labelMainHome.Text = "Home Address:";
            // 
            // labelMainEmail
            // 
            this.labelMainEmail.AutoSize = true;
            this.labelMainEmail.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMainEmail.Location = new System.Drawing.Point(56, 100);
            this.labelMainEmail.Name = "labelMainEmail";
            this.labelMainEmail.Size = new System.Drawing.Size(156, 27);
            this.labelMainEmail.TabIndex = 1;
            this.labelMainEmail.Text = "Email Address:";
            // 
            // labelMainPhoneNumber
            // 
            this.labelMainPhoneNumber.AutoSize = true;
            this.labelMainPhoneNumber.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainPhoneNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMainPhoneNumber.Location = new System.Drawing.Point(56, 43);
            this.labelMainPhoneNumber.Name = "labelMainPhoneNumber";
            this.labelMainPhoneNumber.Size = new System.Drawing.Size(163, 27);
            this.labelMainPhoneNumber.TabIndex = 0;
            this.labelMainPhoneNumber.Text = "Phone Number:";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.White;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLine.Location = new System.Drawing.Point(0, 290);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(884, 1);
            this.panelLine.TabIndex = 4;
            // 
            // panelContactHead
            // 
            this.panelContactHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelContactHead.Controls.Add(this.iconButtonEdit);
            this.panelContactHead.Controls.Add(this.labelNameLarge);
            this.panelContactHead.Controls.Add(this.roundPictureBox1);
            this.panelContactHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContactHead.Location = new System.Drawing.Point(0, 0);
            this.panelContactHead.Name = "panelContactHead";
            this.panelContactHead.Size = new System.Drawing.Size(884, 290);
            this.panelContactHead.TabIndex = 3;
            // 
            // iconButtonEdit
            // 
            this.iconButtonEdit.FlatAppearance.BorderSize = 0;
            this.iconButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButtonEdit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEdit.IconSize = 40;
            this.iconButtonEdit.Location = new System.Drawing.Point(12, 12);
            this.iconButtonEdit.Name = "iconButtonEdit";
            this.iconButtonEdit.Size = new System.Drawing.Size(50, 50);
            this.iconButtonEdit.TabIndex = 2;
            this.iconButtonEdit.UseVisualStyleBackColor = true;
            this.iconButtonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditUser);
            this.iconButtonEdit.MouseEnter += new System.EventHandler(this.ChangeColorGreen);
            this.iconButtonEdit.MouseLeave += new System.EventHandler(this.ChangeColorLeaveWhite);
            // 
            // labelNameLarge
            // 
            this.labelNameLarge.AutoSize = true;
            this.labelNameLarge.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameLarge.Location = new System.Drawing.Point(267, 182);
            this.labelNameLarge.Name = "labelNameLarge";
            this.labelNameLarge.Size = new System.Drawing.Size(319, 68);
            this.labelNameLarge.TabIndex = 1;
            this.labelNameLarge.Text = "Leon Lemur";
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = global::AddressBook.Properties.Resources.Lemur;
            this.roundPictureBox1.Location = new System.Drawing.Point(61, 50);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(200, 200);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 0;
            this.roundPictureBox1.TabStop = false;
            // 
            // UserInfoDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(884, 678);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfoDisplay";
            this.Load += new System.EventHandler(this.UserInfoDisplaycs_Load);
            this.panel1.ResumeLayout(false);
            this.panelContactMain.ResumeLayout(false);
            this.panelContactMain.PerformLayout();
            this.panelContactHead.ResumeLayout(false);
            this.panelContactHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelContactHead;
        private FontAwesome.Sharp.IconButton iconButtonEdit;
        private System.Windows.Forms.Label labelNameLarge;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContactMain;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelMainRelationship;
        private System.Windows.Forms.Label labelMainHome;
        private System.Windows.Forms.Label labelMainEmail;
        private System.Windows.Forms.Label labelMainPhoneNumber;
    }
}