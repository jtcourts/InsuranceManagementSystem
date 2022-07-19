
namespace MyLoginForm
{
    partial class ViewClients
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.lblUsers = new System.Windows.Forms.Label();
            this.lstBoxUsers = new System.Windows.Forms.ListBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblProfile = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            userIDLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            userIDLabel.Location = new System.Drawing.Point(386, 342);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(97, 19);
            userIDLabel.TabIndex = 1;
            userIDLabel.Text = "User ID:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            roleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            roleLabel.Location = new System.Drawing.Point(387, 405);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(64, 19);
            roleLabel.TabIndex = 3;
            roleLabel.Text = "Role:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            phoneNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            phoneNumberLabel.Location = new System.Drawing.Point(643, 149);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(152, 19);
            phoneNumberLabel.TabIndex = 5;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            addressLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            addressLabel.Location = new System.Drawing.Point(643, 211);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(97, 19);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            firstNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            firstNameLabel.Location = new System.Drawing.Point(386, 152);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(130, 19);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            lastNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            lastNameLabel.Location = new System.Drawing.Point(387, 280);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(119, 19);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            middleNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            middleNameLabel.Location = new System.Drawing.Point(387, 214);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(141, 19);
            middleNameLabel.TabIndex = 13;
            middleNameLabel.Text = "Middle Name:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            stateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            stateLabel.Location = new System.Drawing.Point(643, 276);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(75, 19);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            cityLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            cityLabel.Location = new System.Drawing.Point(643, 339);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(64, 19);
            cityLabel.TabIndex = 17;
            cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            zipLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            zipLabel.Location = new System.Drawing.Point(643, 404);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(53, 19);
            zipLabel.TabIndex = 19;
            zipLabel.Text = "Zip:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            label1.Location = new System.Drawing.Point(386, 119);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(229, 19);
            label1.TabIndex = 53;
            label1.Text = "User Information:   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            label2.Location = new System.Drawing.Point(642, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(229, 19);
            label2.TabIndex = 54;
            label2.Text = "Contact Information:";
            // 
            // lblUsers
            // 
            this.lblUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUsers.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(35, 119);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(176, 19);
            this.lblUsers.TabIndex = 116;
            this.lblUsers.Text = "Users:";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstBoxUsers
            // 
            this.lstBoxUsers.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.lstBoxUsers.FormattingEnabled = true;
            this.lstBoxUsers.Location = new System.Drawing.Point(39, 141);
            this.lstBoxUsers.Name = "lstBoxUsers";
            this.lstBoxUsers.ScrollAlwaysVisible = true;
            this.lstBoxUsers.Size = new System.Drawing.Size(305, 316);
            this.lstBoxUsers.TabIndex = 114;
            this.lstBoxUsers.SelectedIndexChanged += new System.EventHandler(this.lstBoxUsers_SelectedIndexChanged);
            // 
            // lblFN
            // 
            this.lblFN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblFN.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(390, 171);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(215, 27);
            this.lblFN.TabIndex = 117;
            this.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblId.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(390, 361);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(215, 27);
            this.lblId.TabIndex = 118;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblCity.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(646, 361);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(215, 27);
            this.lblCity.TabIndex = 119;
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblRole.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(390, 427);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(215, 27);
            this.lblRole.TabIndex = 120;
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMN
            // 
            this.lblMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblMN.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMN.Location = new System.Drawing.Point(390, 233);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(215, 27);
            this.lblMN.TabIndex = 121;
            this.lblMN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLN
            // 
            this.lblLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblLN.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(390, 299);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(215, 27);
            this.lblLN.TabIndex = 122;
            this.lblLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblAddress.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(646, 233);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(215, 27);
            this.lblAddress.TabIndex = 123;
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblState.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(646, 299);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(215, 27);
            this.lblState.TabIndex = 124;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblPhone.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(646, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(215, 27);
            this.lblPhone.TabIndex = 125;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZip
            // 
            this.lblZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblZip.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(646, 427);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(215, 27);
            this.lblZip.TabIndex = 126;
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(875, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 176;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlBar.Controls.Add(this.lblProfile);
            this.pnlBar.Location = new System.Drawing.Point(25, 10);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(850, 60);
            this.pnlBar.TabIndex = 175;
            // 
            // lblProfile
            // 
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProfile.Location = new System.Drawing.Point(10, 6);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(400, 48);
            this.lblProfile.TabIndex = 49;
            this.lblProfile.Text = "VIEW USER PROFILES";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblMN);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lstBoxUsers);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(roleLabel);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(stateLabel);
            this.Controls.Add(cityLabel);
            this.Controls.Add(zipLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewClients";
            this.Text = "ProfileCarousel";
            this.Load += new System.EventHandler(this.ProfileCarousel_Load);
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ListBox lstBoxUsers;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblZip;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblProfile;
    }
}