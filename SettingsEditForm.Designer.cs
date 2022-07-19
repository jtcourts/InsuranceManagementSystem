
namespace MyLoginForm
{
    partial class SettingsEditForm
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
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtCCN = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserId2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpPrivateInfo = new System.Windows.Forms.GroupBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.pnlExp = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.lblExpDate2 = new System.Windows.Forms.Label();
            this.pnlCCV = new System.Windows.Forms.Panel();
            this.pnlCCN = new System.Windows.Forms.Panel();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblCCN2 = new System.Windows.Forms.Label();
            this.lblCCV2 = new System.Windows.Forms.Label();
            this.lblCardName2 = new System.Windows.Forms.Label();
            this.pnlCardName = new System.Windows.Forms.Panel();
            this.btnRoleQuest = new System.Windows.Forms.Button();
            this.pnlBar.SuspendLayout();
            this.gpPrivateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExpDate
            // 
            this.txtExpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtExpDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpDate.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.txtExpDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtExpDate.Location = new System.Drawing.Point(440, 233);
            this.txtExpDate.MaxLength = 7;
            this.txtExpDate.Multiline = true;
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(320, 27);
            this.txtExpDate.TabIndex = 110;
            this.txtExpDate.Click += new System.EventHandler(this.txtExpDate_Click);
            // 
            // txtCCV
            // 
            this.txtCCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtCCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCV.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.txtCCV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCCV.Location = new System.Drawing.Point(60, 233);
            this.txtCCV.MaxLength = 6;
            this.txtCCV.Multiline = true;
            this.txtCCV.Name = "txtCCV";
            this.txtCCV.Size = new System.Drawing.Size(320, 27);
            this.txtCCV.TabIndex = 112;
            this.txtCCV.Click += new System.EventHandler(this.txtCCV_Click);
            // 
            // txtCardName
            // 
            this.txtCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardName.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.txtCardName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCardName.Location = new System.Drawing.Point(60, 173);
            this.txtCardName.Multiline = true;
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(700, 27);
            this.txtCardName.TabIndex = 115;
            this.txtCardName.Click += new System.EventHandler(this.txtCardName_Click);
            // 
            // txtCCN
            // 
            this.txtCCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtCCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCN.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.txtCCN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCCN.Location = new System.Drawing.Point(60, 113);
            this.txtCCN.MaxLength = 16;
            this.txtCCN.Multiline = true;
            this.txtCCN.Name = "txtCCN";
            this.txtCCN.Size = new System.Drawing.Size(657, 27);
            this.txtCCN.TabIndex = 116;
            this.txtCCN.Click += new System.EventHandler(this.txtCCN_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(40, 550);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(740, 550);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserId2
            // 
            this.lblUserId2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblUserId2.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.lblUserId2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserId2.Location = new System.Drawing.Point(440, 53);
            this.lblUserId2.Name = "lblUserId2";
            this.lblUserId2.Size = new System.Drawing.Size(320, 27);
            this.lblUserId2.TabIndex = 133;
            this.lblUserId2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserId2.Click += new System.EventHandler(this.lblUserId2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(60, 53);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 27);
            this.txtPassword.TabIndex = 117;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
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
            this.pnlBar.Controls.Add(this.lblTitle);
            this.pnlBar.Location = new System.Drawing.Point(25, 10);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(850, 60);
            this.pnlBar.TabIndex = 175;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(10, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 48);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "SETTINGS - EDIT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpPrivateInfo
            // 
            this.gpPrivateInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpPrivateInfo.Controls.Add(this.btnRoleQuest);
            this.gpPrivateInfo.Controls.Add(this.txtPassword);
            this.gpPrivateInfo.Controls.Add(this.pnlPass);
            this.gpPrivateInfo.Controls.Add(this.pnlExp);
            this.gpPrivateInfo.Controls.Add(this.label3);
            this.gpPrivateInfo.Controls.Add(this.pnlId);
            this.gpPrivateInfo.Controls.Add(this.lblUserId2);
            this.gpPrivateInfo.Controls.Add(this.txtCCN);
            this.gpPrivateInfo.Controls.Add(this.txtCardName);
            this.gpPrivateInfo.Controls.Add(this.txtCCV);
            this.gpPrivateInfo.Controls.Add(this.txtExpDate);
            this.gpPrivateInfo.Controls.Add(this.lblExpDate2);
            this.gpPrivateInfo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPrivateInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpPrivateInfo.Location = new System.Drawing.Point(40, 76);
            this.gpPrivateInfo.Name = "gpPrivateInfo";
            this.gpPrivateInfo.Size = new System.Drawing.Size(800, 280);
            this.gpPrivateInfo.TabIndex = 177;
            this.gpPrivateInfo.TabStop = false;
            this.gpPrivateInfo.Text = "Private Info";
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlPass.ForeColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(60, 80);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(320, 1);
            this.pnlPass.TabIndex = 143;
            // 
            // pnlExp
            // 
            this.pnlExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlExp.ForeColor = System.Drawing.Color.White;
            this.pnlExp.Location = new System.Drawing.Point(440, 260);
            this.pnlExp.Name = "pnlExp";
            this.pnlExp.Size = new System.Drawing.Size(320, 1);
            this.pnlExp.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.label3.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(440, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 19);
            this.label3.TabIndex = 132;
            this.label3.Text = "User ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlId.ForeColor = System.Drawing.Color.White;
            this.pnlId.Location = new System.Drawing.Point(440, 80);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(320, 1);
            this.pnlId.TabIndex = 144;
            // 
            // lblExpDate2
            // 
            this.lblExpDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblExpDate2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblExpDate2.Location = new System.Drawing.Point(440, 210);
            this.lblExpDate2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpDate2.Name = "lblExpDate2";
            this.lblExpDate2.Size = new System.Drawing.Size(326, 19);
            this.lblExpDate2.TabIndex = 101;
            this.lblExpDate2.Text = "Expiration Date (Month/Year)";
            this.lblExpDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCCV
            // 
            this.pnlCCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCCV.ForeColor = System.Drawing.Color.White;
            this.pnlCCV.Location = new System.Drawing.Point(100, 340);
            this.pnlCCV.Name = "pnlCCV";
            this.pnlCCV.Size = new System.Drawing.Size(320, 1);
            this.pnlCCV.TabIndex = 142;
            // 
            // pnlCCN
            // 
            this.pnlCCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCCN.ForeColor = System.Drawing.Color.White;
            this.pnlCCN.Location = new System.Drawing.Point(100, 220);
            this.pnlCCN.Name = "pnlCCN";
            this.pnlCCN.Size = new System.Drawing.Size(657, 1);
            this.pnlCCN.TabIndex = 143;
            // 
            // lblPassword2
            // 
            this.lblPassword2.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblPassword2.Location = new System.Drawing.Point(100, 110);
            this.lblPassword2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(160, 19);
            this.lblPassword2.TabIndex = 92;
            this.lblPassword2.Text = "Password";
            this.lblPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCCN2
            // 
            this.lblCCN2.BackColor = System.Drawing.Color.Transparent;
            this.lblCCN2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblCCN2.Location = new System.Drawing.Point(100, 170);
            this.lblCCN2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCN2.Name = "lblCCN2";
            this.lblCCN2.Size = new System.Drawing.Size(130, 19);
            this.lblCCN2.TabIndex = 93;
            this.lblCCN2.Text = "Credit Card Number";
            this.lblCCN2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCCV2
            // 
            this.lblCCV2.BackColor = System.Drawing.Color.Transparent;
            this.lblCCV2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCV2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblCCV2.Location = new System.Drawing.Point(100, 290);
            this.lblCCV2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCV2.Name = "lblCCV2";
            this.lblCCV2.Size = new System.Drawing.Size(130, 19);
            this.lblCCV2.TabIndex = 100;
            this.lblCCV2.Text = "CCV";
            this.lblCCV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardName2
            // 
            this.lblCardName2.BackColor = System.Drawing.Color.Transparent;
            this.lblCardName2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblCardName2.Location = new System.Drawing.Point(100, 230);
            this.lblCardName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardName2.Name = "lblCardName2";
            this.lblCardName2.Size = new System.Drawing.Size(149, 19);
            this.lblCardName2.TabIndex = 105;
            this.lblCardName2.Text = "Name on Card";
            this.lblCardName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCardName
            // 
            this.pnlCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCardName.ForeColor = System.Drawing.Color.White;
            this.pnlCardName.Location = new System.Drawing.Point(100, 280);
            this.pnlCardName.Name = "pnlCardName";
            this.pnlCardName.Size = new System.Drawing.Size(700, 1);
            this.pnlCardName.TabIndex = 143;
            // 
            // btnRoleQuest
            // 
            this.btnRoleQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnRoleQuest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoleQuest.FlatAppearance.BorderSize = 2;
            this.btnRoleQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleQuest.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleQuest.ForeColor = System.Drawing.Color.White;
            this.btnRoleQuest.Location = new System.Drawing.Point(731, 118);
            this.btnRoleQuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoleQuest.Name = "btnRoleQuest";
            this.btnRoleQuest.Size = new System.Drawing.Size(29, 27);
            this.btnRoleQuest.TabIndex = 178;
            this.btnRoleQuest.Text = "?";
            this.btnRoleQuest.UseVisualStyleBackColor = false;
            this.btnRoleQuest.Click += new System.EventHandler(this.btnRoleQuest_Click);
            // 
            // SettingsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.pnlCCV);
            this.Controls.Add(this.pnlCardName);
            this.Controls.Add(this.pnlCCN);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCardName2);
            this.Controls.Add(this.lblCCV2);
            this.Controls.Add(this.lblCCN2);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.gpPrivateInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsEditForm";
            this.Text = "SettingsEditForm";
            this.pnlBar.ResumeLayout(false);
            this.gpPrivateInfo.ResumeLayout(false);
            this.gpPrivateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtCCN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserId2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpPrivateInfo;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCCV;
        private System.Windows.Forms.Panel pnlExp;
        private System.Windows.Forms.Panel pnlCCN;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Label lblCCN2;
        private System.Windows.Forms.Label lblCCV2;
        private System.Windows.Forms.Label lblCardName2;
        private System.Windows.Forms.Panel pnlCardName;
        private System.Windows.Forms.Label lblExpDate2;
        private System.Windows.Forms.Button btnRoleQuest;
    }
}