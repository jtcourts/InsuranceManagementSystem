
namespace MyLoginForm
{
    partial class UserControlMessages
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(10, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 24);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(477, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 20);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date / Time";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMessageText.Location = new System.Drawing.Point(10, 40);
            this.lblMessageText.MaximumSize = new System.Drawing.Size(620, 60);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(89, 12);
            this.lblMessageText.TabIndex = 13;
            this.lblMessageText.Text = "message text";
            // 
            // UserControlMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMessageText);
            this.Name = "UserControlMessages";
            this.Size = new System.Drawing.Size(640, 110);
            this.Load += new System.EventHandler(this.UserControlMessages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMessageText;
    }
}
