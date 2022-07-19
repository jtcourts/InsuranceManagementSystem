
namespace MyLoginForm
{
    partial class UserControlDays
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
            this.lblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.lblDays.Location = new System.Drawing.Point(6, 6);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(28, 16);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblDays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(120, 75);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
    }
}
