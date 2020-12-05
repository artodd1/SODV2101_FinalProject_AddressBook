namespace AddressBook
{
    partial class MyAddressBook
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.lblTop = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.iconButtonContacts = new FontAwesome.Sharp.IconButton();
            this.iconButtonUserAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonSettings = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.panelDrawer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuContact4 = new AddressBook.UserControls.MenuContact();
            this.menuContact3 = new AddressBook.UserControls.MenuContact();
            this.menuContact2 = new AddressBook.UserControls.MenuContact();
            this.menuContact1 = new AddressBook.UserControls.MenuContact();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxMainIcon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipMainIcon = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelDrawer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.iconButton1);
            this.panelTop.Controls.Add(this.iconButtonMinimize);
            this.panelTop.Controls.Add(this.iconButtonMaximize);
            this.panelTop.Controls.Add(this.iconButtonExit);
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1226, 50);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(953, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(138, 40);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Current User";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButton1.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimize.IconSize = 25;
            this.iconButtonMinimize.Location = new System.Drawing.Point(1131, 14);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.iconButtonMinimize.TabIndex = 3;
            this.iconButtonMinimize.UseVisualStyleBackColor = false;
            this.iconButtonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.iconButtonMinimize.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonMinimize.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonMaximize
            // 
            this.iconButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButtonMaximize.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaximize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMaximize.IconSize = 25;
            this.iconButtonMaximize.Location = new System.Drawing.Point(1162, 14);
            this.iconButtonMaximize.Name = "iconButtonMaximize";
            this.iconButtonMaximize.Size = new System.Drawing.Size(25, 25);
            this.iconButtonMaximize.TabIndex = 2;
            this.iconButtonMaximize.UseVisualStyleBackColor = false;
            this.iconButtonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            this.iconButtonMaximize.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonMaximize.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 25;
            this.iconButtonExit.Location = new System.Drawing.Point(1193, 14);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Size = new System.Drawing.Size(25, 25);
            this.iconButtonExit.TabIndex = 1;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.iconButtonExit.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnterRed);
            this.iconButtonExit.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(12, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(226, 31);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "My Address Book";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.iconButtonContacts);
            this.panelSideMenu.Controls.Add(this.iconButtonUserAdd);
            this.panelSideMenu.Controls.Add(this.iconButtonSettings);
            this.panelSideMenu.Controls.Add(this.iconButtonMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(101, 671);
            this.panelSideMenu.TabIndex = 1;
            // 
            // iconButtonContacts
            // 
            this.iconButtonContacts.FlatAppearance.BorderSize = 0;
            this.iconButtonContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonContacts.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonContacts.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonContacts.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconButtonContacts.IconColor = System.Drawing.Color.White;
            this.iconButtonContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonContacts.IconSize = 40;
            this.iconButtonContacts.Location = new System.Drawing.Point(0, 59);
            this.iconButtonContacts.Name = "iconButtonContacts";
            this.iconButtonContacts.Size = new System.Drawing.Size(100, 75);
            this.iconButtonContacts.TabIndex = 3;
            this.iconButtonContacts.Text = "Contacts";
            this.iconButtonContacts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonContacts.UseVisualStyleBackColor = true;
            this.iconButtonContacts.Click += new System.EventHandler(this.iconButtonContacts_Click);
            this.iconButtonContacts.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonContacts.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonUserAdd
            // 
            this.iconButtonUserAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUserAdd.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUserAdd.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonUserAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonUserAdd.IconColor = System.Drawing.Color.White;
            this.iconButtonUserAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUserAdd.IconSize = 40;
            this.iconButtonUserAdd.Location = new System.Drawing.Point(0, 140);
            this.iconButtonUserAdd.Name = "iconButtonUserAdd";
            this.iconButtonUserAdd.Size = new System.Drawing.Size(100, 75);
            this.iconButtonUserAdd.TabIndex = 4;
            this.iconButtonUserAdd.Text = "Add Contact";
            this.iconButtonUserAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonUserAdd.UseVisualStyleBackColor = true;
            this.iconButtonUserAdd.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonUserAdd.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonSettings
            // 
            this.iconButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButtonSettings.FlatAppearance.BorderSize = 0;
            this.iconButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonSettings.IconColor = System.Drawing.Color.White;
            this.iconButtonSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSettings.IconSize = 40;
            this.iconButtonSettings.Location = new System.Drawing.Point(1, 596);
            this.iconButtonSettings.Name = "iconButtonSettings";
            this.iconButtonSettings.Size = new System.Drawing.Size(100, 75);
            this.iconButtonSettings.TabIndex = 2;
            this.iconButtonSettings.UseVisualStyleBackColor = true;
            this.iconButtonSettings.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonSettings.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButtonMenu.IconColor = System.Drawing.Color.White;
            this.iconButtonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMenu.IconSize = 40;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 3);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Size = new System.Drawing.Size(100, 75);
            this.iconButtonMenu.TabIndex = 1;
            this.iconButtonMenu.UseVisualStyleBackColor = true;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            this.iconButtonMenu.MouseEnter += new System.EventHandler(this.ChangeColorOnMouseEnter);
            this.iconButtonMenu.MouseLeave += new System.EventHandler(this.ChangeColorOnMouseLeave);
            // 
            // panelDrawer
            // 
            this.panelDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelDrawer.Controls.Add(this.panel1);
            this.panelDrawer.Controls.Add(this.menuContact4);
            this.panelDrawer.Controls.Add(this.menuContact3);
            this.panelDrawer.Controls.Add(this.menuContact2);
            this.panelDrawer.Controls.Add(this.menuContact1);
            this.panelDrawer.Controls.Add(this.panelLabels);
            this.panelDrawer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDrawer.Location = new System.Drawing.Point(101, 50);
            this.panelDrawer.Name = "panelDrawer";
            this.panelDrawer.Size = new System.Drawing.Size(417, 671);
            this.panelDrawer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 50);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 30);
            this.textBox1.TabIndex = 0;
            // 
            // menuContact4
            // 
            this.menuContact4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuContact4.contactEmail = "Salvador_Dali@gmail.com";
            this.menuContact4.contactImg = global::AddressBook.Properties.Resources.SalvadorDali;
            this.menuContact4.contactName = "Salvador Dali";
            this.menuContact4.contactPhone = "111-111-1111";
            this.menuContact4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuContact4.Location = new System.Drawing.Point(0, 220);
            this.menuContact4.Name = "menuContact4";
            this.menuContact4.Size = new System.Drawing.Size(1100, 60);
            this.menuContact4.TabIndex = 10;
            this.menuContact4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayAllUserInfo);
            // 
            // menuContact3
            // 
            this.menuContact3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuContact3.contactEmail = "Spidy@gmail.com";
            this.menuContact3.contactImg = global::AddressBook.Properties.Resources.Spiderman;
            this.menuContact3.contactName = "Spiderman";
            this.menuContact3.contactPhone = "555-555-5555";
            this.menuContact3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuContact3.Location = new System.Drawing.Point(0, 280);
            this.menuContact3.Name = "menuContact3";
            this.menuContact3.Size = new System.Drawing.Size(1100, 60);
            this.menuContact3.TabIndex = 9;
            this.menuContact3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayAllUserInfo);
            // 
            // menuContact2
            // 
            this.menuContact2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuContact2.contactEmail = "Leon_Lemur@gmail.com";
            this.menuContact2.contactImg = global::AddressBook.Properties.Resources.Lemur;
            this.menuContact2.contactName = "Leon Lemur";
            this.menuContact2.contactPhone = "987-654-3210";
            this.menuContact2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuContact2.Location = new System.Drawing.Point(0, 160);
            this.menuContact2.Name = "menuContact2";
            this.menuContact2.Size = new System.Drawing.Size(1100, 60);
            this.menuContact2.TabIndex = 8;
            this.menuContact2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayAllUserInfo);
            // 
            // menuContact1
            // 
            this.menuContact1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuContact1.contactEmail = "Henry_Husky@gmail.com";
            this.menuContact1.contactImg = global::AddressBook.Properties.Resources.Husky;
            this.menuContact1.contactName = "Henry Husky";
            this.menuContact1.contactPhone = "012-345-6789";
            this.menuContact1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuContact1.Location = new System.Drawing.Point(0, 100);
            this.menuContact1.Name = "menuContact1";
            this.menuContact1.Size = new System.Drawing.Size(1100, 60);
            this.menuContact1.TabIndex = 7;
            this.menuContact1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplayAllUserInfo);
            // 
            // panelLabels
            // 
            this.panelLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLabels.Controls.Add(this.labelPhone);
            this.panelLabels.Controls.Add(this.labelEmail);
            this.panelLabels.Controls.Add(this.labelName);
            this.panelLabels.Location = new System.Drawing.Point(0, 50);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(1100, 60);
            this.panelLabels.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(900, 19);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(129, 22);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(600, 19);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(124, 22);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(78, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 22);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBoxMainIcon);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(518, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(708, 671);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBoxMainIcon
            // 
            this.pictureBoxMainIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMainIcon.Image = global::AddressBook.Properties.Resources.icons8_moleskine_128px;
            this.pictureBoxMainIcon.Location = new System.Drawing.Point(267, 200);
            this.pictureBoxMainIcon.Name = "pictureBoxMainIcon";
            this.pictureBoxMainIcon.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainIcon.TabIndex = 0;
            this.pictureBoxMainIcon.TabStop = false;
            this.toolTipMainIcon.SetToolTip(this.pictureBoxMainIcon, "MouseHover");
            this.pictureBoxMainIcon.Click += new System.EventHandler(this.iconButtonContacts_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTipMainIcon
            // 
            this.toolTipMainIcon.ToolTipTitle = "Click to display your contacts!";
            // 
            // MyAddressBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1226, 721);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelDrawer);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MyAddressBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.MyAddressBook_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelDrawer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelDrawer;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButtonContacts;
        private FontAwesome.Sharp.IconButton iconButtonSettings;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private UserControls.MenuContact menuContact4;
        private UserControls.MenuContact menuContact3;
        private UserControls.MenuContact menuContact2;
        private UserControls.MenuContact menuContact1;
        private FontAwesome.Sharp.IconButton iconButtonUserAdd;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonMaximize;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Label lblTop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxMainIcon;
        private System.Windows.Forms.ToolTip toolTipMainIcon;
    }
}