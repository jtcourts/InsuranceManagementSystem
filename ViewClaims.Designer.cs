
namespace MyLoginForm
{
    partial class ViewClaims
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
            this.lblClaims = new System.Windows.Forms.Label();
            this.lstBoxClaims = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.datetimeSearchClaims = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.rdlProgress = new System.Windows.Forms.RadioButton();
            this.rdlComplete = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaims
            // 
            this.lblClaims.BackColor = System.Drawing.Color.Transparent;
            this.lblClaims.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaims.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblClaims.Location = new System.Drawing.Point(44, 104);
            this.lblClaims.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaims.Name = "lblClaims";
            this.lblClaims.Size = new System.Drawing.Size(176, 19);
            this.lblClaims.TabIndex = 114;
            this.lblClaims.Text = "Claims:";
            this.lblClaims.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstBoxClaims
            // 
            this.lstBoxClaims.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lstBoxClaims.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxClaims.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstBoxClaims.FormattingEnabled = true;
            this.lstBoxClaims.ItemHeight = 12;
            this.lstBoxClaims.Location = new System.Drawing.Point(48, 126);
            this.lstBoxClaims.Name = "lstBoxClaims";
            this.lstBoxClaims.ScrollAlwaysVisible = true;
            this.lstBoxClaims.Size = new System.Drawing.Size(809, 304);
            this.lstBoxClaims.TabIndex = 115;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSelect.FlatAppearance.BorderSize = 3;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSelect.Location = new System.Drawing.Point(716, 445);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(122, 27);
            this.btnSelect.TabIndex = 117;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.FlatAppearance.BorderSize = 3;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.Location = new System.Drawing.Point(48, 445);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 27);
            this.btnLoad.TabIndex = 119;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // datetimeSearchClaims
            // 
            this.datetimeSearchClaims.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.datetimeSearchClaims.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.datetimeSearchClaims.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.datetimeSearchClaims.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.datetimeSearchClaims.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.datetimeSearchClaims.Checked = false;
            this.datetimeSearchClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datetimeSearchClaims.Font = new System.Drawing.Font("Lucida Console", 13.875F);
            this.datetimeSearchClaims.Location = new System.Drawing.Point(440, 17);
            this.datetimeSearchClaims.Name = "datetimeSearchClaims";
            this.datetimeSearchClaims.ShowCheckBox = true;
            this.datetimeSearchClaims.Size = new System.Drawing.Size(400, 26);
            this.datetimeSearchClaims.TabIndex = 120;
            this.datetimeSearchClaims.Value = new System.DateTime(2022, 4, 7, 11, 54, 33, 0);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(43, 517);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 27);
            this.btnBack.TabIndex = 118;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChange.Location = new System.Drawing.Point(287, 449);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(298, 16);
            this.lblChange.TabIndex = 121;
            this.lblChange.Text = "Change Selected Claim Status:";
            // 
            // rdlProgress
            // 
            this.rdlProgress.AutoSize = true;
            this.rdlProgress.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlProgress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdlProgress.Location = new System.Drawing.Point(290, 468);
            this.rdlProgress.Name = "rdlProgress";
            this.rdlProgress.Size = new System.Drawing.Size(136, 20);
            this.rdlProgress.TabIndex = 122;
            this.rdlProgress.TabStop = true;
            this.rdlProgress.Text = "In Progress";
            this.rdlProgress.UseVisualStyleBackColor = true;
            // 
            // rdlComplete
            // 
            this.rdlComplete.AutoSize = true;
            this.rdlComplete.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlComplete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdlComplete.Location = new System.Drawing.Point(290, 494);
            this.rdlComplete.Name = "rdlComplete";
            this.rdlComplete.Size = new System.Drawing.Size(106, 20);
            this.rdlComplete.TabIndex = 123;
            this.rdlComplete.TabStop = true;
            this.rdlComplete.Text = "Complete";
            this.rdlComplete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnChange.FlatAppearance.BorderSize = 3;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnChange.Location = new System.Drawing.Point(290, 517);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(122, 27);
            this.btnChange.TabIndex = 124;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.pnlBar.Controls.Add(this.datetimeSearchClaims);
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
            this.lblTitle.Size = new System.Drawing.Size(400, 48);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "VIEW CLAIMS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 572);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.rdlComplete);
            this.Controls.Add(this.rdlProgress);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstBoxClaims);
            this.Controls.Add(this.lblClaims);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewClaims";
            this.Text = "ViewClaims";
            this.Load += new System.EventHandler(this.ViewClaims_Load);
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClaims;
        private System.Windows.Forms.ListBox lstBoxClaims;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker datetimeSearchClaims;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.RadioButton rdlProgress;
        private System.Windows.Forms.RadioButton rdlComplete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblTitle;
    }
}