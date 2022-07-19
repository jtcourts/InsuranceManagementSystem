
namespace MyLoginForm
{
    partial class FileClaim2
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
            this.btnFileClaim = new System.Windows.Forms.Button();
            this.txtIncident = new System.Windows.Forms.TextBox();
            this.txtDamages = new System.Windows.Forms.TextBox();
            this.lblDamages = new System.Windows.Forms.Label();
            this.lblIncident = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.btnUpload2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoc1Quest = new System.Windows.Forms.Button();
            this.btnDoc2Quest = new System.Windows.Forms.Button();
            this.btnPicQuest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileClaim
            // 
            this.btnFileClaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnFileClaim.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFileClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileClaim.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnFileClaim.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFileClaim.Location = new System.Drawing.Point(668, 493);
            this.btnFileClaim.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileClaim.Name = "btnFileClaim";
            this.btnFileClaim.Size = new System.Drawing.Size(150, 32);
            this.btnFileClaim.TabIndex = 73;
            this.btnFileClaim.Text = "File Claim";
            this.btnFileClaim.UseVisualStyleBackColor = false;
            this.btnFileClaim.Click += new System.EventHandler(this.btnFileClaim_Click);
            // 
            // txtIncident
            // 
            this.txtIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncident.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncident.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtIncident.Location = new System.Drawing.Point(107, 118);
            this.txtIncident.Multiline = true;
            this.txtIncident.Name = "txtIncident";
            this.txtIncident.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtIncident.Size = new System.Drawing.Size(327, 173);
            this.txtIncident.TabIndex = 96;
            // 
            // txtDamages
            // 
            this.txtDamages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.txtDamages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDamages.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamages.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDamages.Location = new System.Drawing.Point(467, 118);
            this.txtDamages.Multiline = true;
            this.txtDamages.Name = "txtDamages";
            this.txtDamages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDamages.Size = new System.Drawing.Size(327, 173);
            this.txtDamages.TabIndex = 95;
            // 
            // lblDamages
            // 
            this.lblDamages.BackColor = System.Drawing.Color.Transparent;
            this.lblDamages.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblDamages.Location = new System.Drawing.Point(467, 99);
            this.lblDamages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDamages.Name = "lblDamages";
            this.lblDamages.Size = new System.Drawing.Size(326, 19);
            this.lblDamages.TabIndex = 94;
            this.lblDamages.Text = "Description of Damages";
            this.lblDamages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncident
            // 
            this.lblIncident.BackColor = System.Drawing.Color.Transparent;
            this.lblIncident.Font = new System.Drawing.Font("Lucida Console", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblIncident.Location = new System.Drawing.Point(107, 99);
            this.lblIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncident.Name = "lblIncident";
            this.lblIncident.Size = new System.Drawing.Size(326, 19);
            this.lblIncident.TabIndex = 93;
            this.lblIncident.Text = "Description of Incident";
            this.lblIncident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpload.FlatAppearance.BorderSize = 2;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpload.Location = new System.Drawing.Point(107, 324);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(288, 32);
            this.btnUpload.TabIndex = 100;
            this.btnUpload.Text = "Upload Document 1";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // lblFile
            // 
            this.lblFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblFile.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFile.Location = new System.Drawing.Point(107, 358);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(327, 27);
            this.lblFile.TabIndex = 105;
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFile2
            // 
            this.lblFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.lblFile2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFile2.Location = new System.Drawing.Point(107, 446);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(327, 27);
            this.lblFile2.TabIndex = 107;
            this.lblFile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpload2
            // 
            this.btnUpload2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnUpload2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpload2.FlatAppearance.BorderSize = 2;
            this.btnUpload2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnUpload2.Location = new System.Drawing.Point(107, 412);
            this.btnUpload2.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload2.Name = "btnUpload2";
            this.btnUpload2.Size = new System.Drawing.Size(288, 32);
            this.btnUpload2.TabIndex = 106;
            this.btnUpload2.Text = "Upload Document 2";
            this.btnUpload2.UseVisualStyleBackColor = false;
            this.btnUpload2.Click += new System.EventHandler(this.btnUpload2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnFileOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnFileOpen.FlatAppearance.BorderSize = 2;
            this.btnFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileOpen.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnFileOpen.Location = new System.Drawing.Point(467, 324);
            this.btnFileOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(288, 32);
            this.btnFileOpen.TabIndex = 108;
            this.btnFileOpen.Text = "Upload Pictures";
            this.btnFileOpen.UseVisualStyleBackColor = false;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(467, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 112);
            this.flowLayoutPanel1.TabIndex = 109;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(107, 493);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 32);
            this.btnBack.TabIndex = 110;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(106, 384);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(327, 1);
            this.panel7.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(106, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 128;
            // 
            // btnDoc1Quest
            // 
            this.btnDoc1Quest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnDoc1Quest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoc1Quest.FlatAppearance.BorderSize = 2;
            this.btnDoc1Quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc1Quest.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc1Quest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoc1Quest.Location = new System.Drawing.Point(399, 324);
            this.btnDoc1Quest.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoc1Quest.Name = "btnDoc1Quest";
            this.btnDoc1Quest.Size = new System.Drawing.Size(35, 32);
            this.btnDoc1Quest.TabIndex = 129;
            this.btnDoc1Quest.Text = "?";
            this.btnDoc1Quest.UseVisualStyleBackColor = false;
            this.btnDoc1Quest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoc2Quest
            // 
            this.btnDoc2Quest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnDoc2Quest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoc2Quest.FlatAppearance.BorderSize = 2;
            this.btnDoc2Quest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc2Quest.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc2Quest.ForeColor = System.Drawing.Color.White;
            this.btnDoc2Quest.Location = new System.Drawing.Point(399, 412);
            this.btnDoc2Quest.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoc2Quest.Name = "btnDoc2Quest";
            this.btnDoc2Quest.Size = new System.Drawing.Size(35, 32);
            this.btnDoc2Quest.TabIndex = 130;
            this.btnDoc2Quest.Text = "?";
            this.btnDoc2Quest.UseVisualStyleBackColor = false;
            this.btnDoc2Quest.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPicQuest
            // 
            this.btnPicQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.btnPicQuest.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicQuest.FlatAppearance.BorderSize = 2;
            this.btnPicQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicQuest.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicQuest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPicQuest.Location = new System.Drawing.Point(759, 324);
            this.btnPicQuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnPicQuest.Name = "btnPicQuest";
            this.btnPicQuest.Size = new System.Drawing.Size(35, 32);
            this.btnPicQuest.TabIndex = 131;
            this.btnPicQuest.Text = "?";
            this.btnPicQuest.UseVisualStyleBackColor = false;
            this.btnPicQuest.Click += new System.EventHandler(this.button3_Click);
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
            this.btnExit.TabIndex = 192;
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
            this.pnlBar.TabIndex = 191;
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
            this.lblTitle.Text = "MAKE A CLAIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileClaim2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.btnPicQuest);
            this.Controls.Add(this.btnDoc2Quest);
            this.Controls.Add(this.btnDoc1Quest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.btnUpload2);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtIncident);
            this.Controls.Add(this.txtDamages);
            this.Controls.Add(this.lblDamages);
            this.Controls.Add(this.lblIncident);
            this.Controls.Add(this.btnFileClaim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileClaim2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileClaim2";
            this.Load += new System.EventHandler(this.FileClaim2_Load);
            this.pnlBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileClaim;
        private System.Windows.Forms.TextBox txtIncident;
        private System.Windows.Forms.TextBox txtDamages;
        private System.Windows.Forms.Label lblDamages;
        private System.Windows.Forms.Label lblIncident;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.Button btnUpload2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoc1Quest;
        private System.Windows.Forms.Button btnDoc2Quest;
        private System.Windows.Forms.Button btnPicQuest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Label lblTitle;
    }
}