namespace MyGitProject
{
    partial class Form1
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
            this.login1 = new ctrlLoginInfo.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.Transparent;
            this.login1.ButtonLoginColor = System.Drawing.Color.Teal;
            this.login1.ButtonLoginForeColor = System.Drawing.Color.White;
            this.login1.FillColorPassword = System.Drawing.Color.White;
            this.login1.FillColorRememberMe_Checked = System.Drawing.Color.Lime;
            this.login1.FillColorRememberMe_UnChecked = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.login1.FillColorUsername = System.Drawing.Color.White;
            this.login1.ForeColorlabelPassword = System.Drawing.SystemColors.ButtonFace;
            this.login1.ForeColorlabelUsername = System.Drawing.SystemColors.ButtonHighlight;
            this.login1.ForeColorPassword = System.Drawing.Color.Black;
            this.login1.ForeColorUsername = System.Drawing.Color.Black;
            this.login1.Location = new System.Drawing.Point(220, 86);
            this.login1.Name = "login1";
            this.login1.PlaceholderPassword = "Password";
            this.login1.PlaceholderUsername = "Username";
            this.login1.Size = new System.Drawing.Size(272, 177);
            this.login1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLoginInfo.Login login1;
    }
}

