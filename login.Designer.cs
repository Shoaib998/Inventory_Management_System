namespace IMS
{
    partial class login
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
            this.userNameLab = new System.Windows.Forms.Label();
            this.uNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLab = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.passwordTB);
            this.leftPanel.Controls.Add(this.passwordLab);
            this.leftPanel.Controls.Add(this.uNameTB);
            this.leftPanel.Controls.Add(this.userNameLab);
            this.leftPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.leftPanel.Size = new System.Drawing.Size(250, 508);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.userNameLab, 0);
            this.leftPanel.Controls.SetChildIndex(this.uNameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLab, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(705, 508);
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Location = new System.Drawing.Point(12, 227);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(68, 15);
            this.userNameLab.TabIndex = 1;
            this.userNameLab.Text = "User Name:";
            // 
            // uNameTB
            // 
            this.uNameTB.Location = new System.Drawing.Point(12, 245);
            this.uNameTB.MaxLength = 30;
            this.uNameTB.Name = "uNameTB";
            this.uNameTB.Size = new System.Drawing.Size(232, 23);
            this.uNameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(12, 295);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(232, 23);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordLab.Location = new System.Drawing.Point(12, 277);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(60, 15);
            this.passwordLab.TabIndex = 3;
            this.passwordLab.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(12, 333);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(232, 37);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 508);
            this.Name = "login";
            this.Text = "login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uNameTB;
        private System.Windows.Forms.Label userNameLab;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLab;
        private System.Windows.Forms.Button loginBtn;
    }
}