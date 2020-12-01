namespace AddressBook.UserControls
{
    partial class MenuContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelContactEmail = new System.Windows.Forms.Label();
            this.labelContactPhone = new System.Windows.Forms.Label();
            this.roundPictureBoxContactImg = new AddressBook.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxContactImg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(75, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 27);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.MouseEnter += new System.EventHandler(this.MenuContact_MouseEnter_1);
            this.labelName.MouseLeave += new System.EventHandler(this.MenuContact_MouseLeave_1);
            // 
            // labelContactEmail
            // 
            this.labelContactEmail.AutoSize = true;
            this.labelContactEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelContactEmail.ForeColor = System.Drawing.Color.White;
            this.labelContactEmail.Location = new System.Drawing.Point(600, 19);
            this.labelContactEmail.Name = "labelContactEmail";
            this.labelContactEmail.Size = new System.Drawing.Size(55, 22);
            this.labelContactEmail.TabIndex = 2;
            this.labelContactEmail.Text = "label2";
            this.labelContactEmail.MouseEnter += new System.EventHandler(this.MenuContact_MouseEnter_1);
            this.labelContactEmail.MouseLeave += new System.EventHandler(this.MenuContact_MouseLeave_1);
            // 
            // labelContactPhone
            // 
            this.labelContactPhone.AutoSize = true;
            this.labelContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelContactPhone.ForeColor = System.Drawing.Color.White;
            this.labelContactPhone.Location = new System.Drawing.Point(900, 19);
            this.labelContactPhone.Name = "labelContactPhone";
            this.labelContactPhone.Size = new System.Drawing.Size(55, 22);
            this.labelContactPhone.TabIndex = 3;
            this.labelContactPhone.Text = "label1";
            this.labelContactPhone.MouseEnter += new System.EventHandler(this.MenuContact_MouseEnter_1);
            this.labelContactPhone.MouseLeave += new System.EventHandler(this.MenuContact_MouseLeave_1);
            // 
            // roundPictureBoxContactImg
            // 
            this.roundPictureBoxContactImg.Location = new System.Drawing.Point(3, 3);
            this.roundPictureBoxContactImg.Name = "roundPictureBoxContactImg";
            this.roundPictureBoxContactImg.Size = new System.Drawing.Size(54, 54);
            this.roundPictureBoxContactImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxContactImg.TabIndex = 0;
            this.roundPictureBoxContactImg.TabStop = false;
            this.roundPictureBoxContactImg.MouseEnter += new System.EventHandler(this.MenuContact_MouseEnter_1);
            this.roundPictureBoxContactImg.MouseLeave += new System.EventHandler(this.MenuContact_MouseLeave_1);
            // 
            // MenuContact
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.labelContactPhone);
            this.Controls.Add(this.labelContactEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundPictureBoxContactImg);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuContact";
            this.Size = new System.Drawing.Size(1000, 60);
            this.Load += new System.EventHandler(this.MenuContact_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuContact_MouseClick);
            this.MouseEnter += new System.EventHandler(this.MenuContact_MouseEnter_1);
            this.MouseLeave += new System.EventHandler(this.MenuContact_MouseLeave_1);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxContactImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPictureBox roundPictureBoxContactImg;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelContactEmail;
        private System.Windows.Forms.Label labelContactPhone;
    }
}
