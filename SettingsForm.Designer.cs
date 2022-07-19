
namespace MyLoginForm
{
    partial class SettingsForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCCV = new System.Windows.Forms.Panel();
            this.pnlCardName = new System.Windows.Forms.Panel();
            this.pnlCCN = new System.Windows.Forms.Panel();
            this.lblCardName2 = new System.Windows.Forms.Label();
            this.lblCCV2 = new System.Windows.Forms.Label();
            this.lblCCN2 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.gpPrivateInfo = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.pnlExp = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.lblUserId2 = new System.Windows.Forms.Label();
            this.txtCCN = new System.Windows.Forms.TextBox();
            this.txtCCV = new System.Windows.Forms.TextBox();
            this.lblExpDate2 = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.gpPrivateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(740, 550);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 85;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnExit.TabIndex = 186;
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
            this.pnlBar.TabIndex = 185;
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
            this.lblTitle.Text = "SETTINGS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCCV
            // 
            this.pnlCCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCCV.ForeColor = System.Drawing.Color.White;
            this.pnlCCV.Location = new System.Drawing.Point(100, 340);
            this.pnlCCV.Name = "pnlCCV";
            this.pnlCCV.Size = new System.Drawing.Size(320, 1);
            this.pnlCCV.TabIndex = 182;
            // 
            // pnlCardName
            // 
            this.pnlCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCardName.ForeColor = System.Drawing.Color.White;
            this.pnlCardName.Location = new System.Drawing.Point(100, 280);
            this.pnlCardName.Name = "pnlCardName";
            this.pnlCardName.Size = new System.Drawing.Size(700, 1);
            this.pnlCardName.TabIndex = 183;
            // 
            // pnlCCN
            // 
            this.pnlCCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.pnlCCN.ForeColor = System.Drawing.Color.White;
            this.pnlCCN.Location = new System.Drawing.Point(100, 220);
            this.pnlCCN.Name = "pnlCCN";
            this.pnlCCN.Size = new System.Drawing.Size(700, 1);
            this.pnlCCN.TabIndex = 184;
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
            this.lblCardName2.TabIndex = 181;
            this.lblCardName2.Text = "Name on Card";
            this.lblCardName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblCCV2.TabIndex = 180;
            this.lblCCV2.Text = "CCV";
            this.lblCCV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblCCN2.TabIndex = 179;
            this.lblCCN2.Text = "Credit Card Number";
            this.lblCCN2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblPassword2.TabIndex = 178;
            this.lblPassword2.Text = "Password";
            this.lblPassword2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpPrivateInfo
            // 
            this.gpPrivateInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpPrivateInfo.Controls.Add(this.lblExpDate);
            this.gpPrivateInfo.Controls.Add(this.lblCardName);
            this.gpPrivateInfo.Controls.Add(this.txtPassword);
            this.gpPrivateInfo.Controls.Add(this.pnlPass);
            this.gpPrivateInfo.Controls.Add(this.pnlExp);
            this.gpPrivateInfo.Controls.Add(this.label3);
            this.gpPrivateInfo.Controls.Add(this.pnlId);
            this.gpPrivateInfo.Controls.Add(this.lblUserId2);
            this.gpPrivateInfo.Controls.Add(this.txtCCN);
            this.gpPrivateInfo.Controls.Add(this.txtCCV);
            this.gpPrivateInfo.Controls.Add(this.lblExpDate2);
            this.gpPrivateInfo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPrivateInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gpPrivateInfo.Location = new System.Drawing.Point(40, 80);
            this.gpPrivateInfo.Name = "gpPrivateInfo";
            this.gpPrivateInfo.Size = new System.Drawing.Size(800, 280);
            this.gpPrivateInfo.TabIndex = 187;
            this.gpPrivateInfo.TabStop = false;
            this.gpPrivateInfo.Text = "Private Info";
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
            this.txtCCN.Size = new System.Drawing.Size(700, 27);
            this.txtCCN.TabIndex = 116;
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
            // lblCardName
            // 
            this.lblCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblCardName.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.lblCardName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCardName.Location = new System.Drawing.Point(60, 173);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(700, 27);
            this.lblCardName.TabIndex = 145;
            this.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExpDate
            // 
            this.lblExpDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblExpDate.Font = new System.Drawing.Font("Lucida Console", 15.75F);
            this.lblExpDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExpDate.Location = new System.Drawing.Point(440, 233);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(320, 27);
            this.lblExpDate.TabIndex = 146;
            this.lblExpDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
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
            this.Controls.Add(this.lblCardName2);
            this.Controls.Add(this.lblCCV2);
            this.Controls.Add(this.lblCCN2);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.gpPrivateInfo);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Expiration Date";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnlBar.ResumeLayout(false);
            this.gpPrivateInfo.ResumeLayout(false);
            this.gpPrivateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCCV;
        private System.Windows.Forms.Panel pnlCardName;
        private System.Windows.Forms.Panel pnlCCN;
        private System.Windows.Forms.Label lblCardName2;
        private System.Windows.Forms.Label lblCCV2;
        private System.Windows.Forms.Label lblCCN2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.GroupBox gpPrivateInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Panel pnlExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Label lblUserId2;
        private System.Windows.Forms.TextBox txtCCN;
        private System.Windows.Forms.TextBox txtCCV;
        private System.Windows.Forms.Label lblExpDate2;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblExpDate;
    }
}