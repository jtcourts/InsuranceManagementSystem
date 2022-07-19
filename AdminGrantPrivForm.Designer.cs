
namespace MyLoginForm
{
    partial class AdminGrantPrivForm
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
            System.Windows.Forms.Label label3;
            this.lstBoxUsers = new System.Windows.Forms.ListBox();
            this.btnChangeRoles = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnRoleQuest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            label3.Location = new System.Drawing.Point(450, 194);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(229, 19);
            label3.TabIndex = 114;
            label3.Text = "User Information:   ";
            // 
            // lstBoxUsers
            // 
            this.lstBoxUsers.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.lstBoxUsers.FormattingEnabled = true;
            this.lstBoxUsers.Location = new System.Drawing.Point(86, 142);
            this.lstBoxUsers.Name = "lstBoxUsers";
            this.lstBoxUsers.ScrollAlwaysVisible = true;
            this.lstBoxUsers.Size = new System.Drawing.Size(329, 342);
            this.lstBoxUsers.TabIndex = 100;
            this.lstBoxUsers.SelectedIndexChanged += new System.EventHandler(this.lstBoxUsers_SelectedIndexChanged);
            // 
            // btnChangeRoles
            // 
            this.btnChangeRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnChangeRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRoles.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRoles.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeRoles.Location = new System.Drawing.Point(695, 457);
            this.btnChangeRoles.Name = "btnChangeRoles";
            this.btnChangeRoles.Size = new System.Drawing.Size(122, 27);
            this.btnChangeRoles.TabIndex = 104;
            this.btnChangeRoles.Text = "Make Changes";
            this.btnChangeRoles.UseVisualStyleBackColor = false;
            this.btnChangeRoles.Click += new System.EventHandler(this.btnChangeRoles_Click_1);
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold);
            this.txtRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRole.Location = new System.Drawing.Point(626, 372);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(157, 27);
            this.txtRole.TabIndex = 105;
            // 
            // lblFN
            // 
            this.lblFN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblFN.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(626, 236);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(191, 27);
            this.lblFN.TabIndex = 106;
            this.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLN
            // 
            this.lblLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblLN.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(626, 278);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(191, 27);
            this.lblLN.TabIndex = 107;
            this.lblLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUID
            // 
            this.lblUID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblUID.Font = new System.Drawing.Font("Lucida Console", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(626, 324);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(191, 27);
            this.lblUID.TabIndex = 108;
            this.lblUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName1
            // 
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.White;
            this.lblName1.Location = new System.Drawing.Point(450, 243);
            this.lblName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(176, 19);
            this.lblName1.TabIndex = 109;
            this.lblName1.Text = "First Name:";
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName2
            // 
            this.lblName2.BackColor = System.Drawing.Color.Transparent;
            this.lblName2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.White;
            this.lblName2.Location = new System.Drawing.Point(450, 285);
            this.lblName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(130, 19);
            this.lblName2.TabIndex = 110;
            this.lblName2.Text = "Last Name:";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 111;
            this.label1.Text = "User ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 112;
            this.label2.Text = "Current Role:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsers
            // 
            this.lblUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUsers.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(84, 120);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(176, 19);
            this.lblUsers.TabIndex = 113;
            this.lblUsers.Text = "Users:";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRoleQuest
            // 
            this.btnRoleQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnRoleQuest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoleQuest.FlatAppearance.BorderSize = 2;
            this.btnRoleQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleQuest.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleQuest.ForeColor = System.Drawing.Color.White;
            this.btnRoleQuest.Location = new System.Drawing.Point(788, 372);
            this.btnRoleQuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoleQuest.Name = "btnRoleQuest";
            this.btnRoleQuest.Size = new System.Drawing.Size(29, 27);
            this.btnRoleQuest.TabIndex = 131;
            this.btnRoleQuest.Text = "?";
            this.btnRoleQuest.UseVisualStyleBackColor = false;
            this.btnRoleQuest.Click += new System.EventHandler(this.button2_Click);
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
            this.btnExit.TabIndex = 190;
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
            this.pnlBar.TabIndex = 189;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(10, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 48);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "GRANT USER PRIVILEGES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminGrantPrivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.btnRoleQuest);
            this.Controls.Add(label3);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnChangeRoles);
            this.Controls.Add(this.lstBoxUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminGrantPrivForm";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.AdminGrantPrivForm_Load);
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxUsers;
        private System.Windows.Forms.Button btnChangeRoles;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnRoleQuest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblTitle;
    }
}