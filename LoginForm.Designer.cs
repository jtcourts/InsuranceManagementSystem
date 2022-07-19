
namespace MyLoginForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picUsername = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.picSeePassword = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDragBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.HideSelection = false;
            this.txtUsername.Location = new System.Drawing.Point(55, 175);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 15);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Email";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(55, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 15);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGo.Location = new System.Drawing.Point(25, 260);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(300, 39);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Sign In";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(325, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picUsername
            // 
            this.picUsername.BackgroundImage = global::MyLoginForm.Properties.Resources.user_1;
            this.picUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picUsername.Location = new System.Drawing.Point(25, 170);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(24, 24);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 9;
            this.picUsername.TabStop = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUsername.ForeColor = System.Drawing.Color.White;
            this.pnlUsername.Location = new System.Drawing.Point(25, 200);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(300, 1);
            this.pnlUsername.TabIndex = 0;
            this.pnlUsername.TabStop = true;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPassword.ForeColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(25, 240);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(300, 1);
            this.pnlPassword.TabIndex = 13;
            // 
            // picPassword
            // 
            this.picPassword.BackgroundImage = global::MyLoginForm.Properties.Resources.lock_1;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPassword.Location = new System.Drawing.Point(25, 210);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(24, 24);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 12;
            this.picPassword.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.Location = new System.Drawing.Point(25, 310);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 39);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.lblTeam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTeam.Location = new System.Drawing.Point(23, 363);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(302, 18);
            this.lblTeam.TabIndex = 17;
            this.lblTeam.Text = "007 Car Insurance";
            this.lblTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSeePassword
            // 
            this.picSeePassword.BackgroundImage = global::MyLoginForm.Properties.Resources.Eye_1;
            this.picSeePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSeePassword.Location = new System.Drawing.Point(300, 210);
            this.picSeePassword.Name = "picSeePassword";
            this.picSeePassword.Size = new System.Drawing.Size(24, 24);
            this.picSeePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeePassword.TabIndex = 18;
            this.picSeePassword.TabStop = false;
            this.picSeePassword.Click += new System.EventHandler(this.picSeePassword_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Image = global::MyLoginForm.Properties.Resources.Carbrella_2;
            this.picLogo.Location = new System.Drawing.Point(115, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(120, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 19;
            this.picLogo.TabStop = false;
            // 
            // pnlDragBar
            // 
            this.pnlDragBar.AllowDrop = true;
            this.pnlDragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDragBar.Location = new System.Drawing.Point(0, 0);
            this.pnlDragBar.Name = "pnlDragBar";
            this.pnlDragBar.Size = new System.Drawing.Size(350, 400);
            this.pnlDragBar.TabIndex = 20;
            this.pnlDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDragBar_MouseDown);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnGo;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picSeePassword);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlDragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the login form!";
            this.ResizeBegin += new System.EventHandler(this.LoginForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.LoginForm_ResizeEnd);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoginForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.PictureBox picSeePassword;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDragBar;
    }
}

