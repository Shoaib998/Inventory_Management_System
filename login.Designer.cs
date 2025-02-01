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
            this.nameerrorLbl = new System.Windows.Forms.Label();
            this.passworderrorLbl = new System.Windows.Forms.Label();
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
            this.leftPanel.Controls.Add(this.nameerrorLbl);
            this.leftPanel.Controls.Add(this.passworderrorLbl);
            this.leftPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.leftPanel.Size = new System.Drawing.Size(250, 508);
            this.leftPanel.Controls.SetChildIndex(this.passworderrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameerrorLbl, 0);
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
            this.userNameLab.Size = new System.Drawing.Size(65, 15);
            this.userNameLab.TabIndex = 1;
            this.userNameLab.Text = "User Name";
            // 
            // uNameTB
            // 
            this.uNameTB.Location = new System.Drawing.Point(12, 245);
            this.uNameTB.MaxLength = 30;
            this.uNameTB.Name = "uNameTB";
            this.uNameTB.Size = new System.Drawing.Size(232, 23);
            this.uNameTB.TabIndex = 2;
            this.uNameTB.TextChanged += new System.EventHandler(this.uNameTB_TextChanged);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(12, 295);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(232, 23);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // passwordLab
            // 
            this.passwordLab.AutoSize = true;
            this.passwordLab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordLab.Location = new System.Drawing.Point(12, 277);
            this.passwordLab.Name = "passwordLab";
            this.passwordLab.Size = new System.Drawing.Size(57, 15);
            this.passwordLab.TabIndex = 3;
            this.passwordLab.Text = "Password";
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
            // nameerrorLbl
            // 
            this.nameerrorLbl.AutoSize = true;
            this.nameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerrorLbl.Location = new System.Drawing.Point(75, 228);
            this.nameerrorLbl.Name = "nameerrorLbl";
            this.nameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.nameerrorLbl.TabIndex = 14;
            this.nameerrorLbl.Text = "*";
            this.nameerrorLbl.Visible = false;
            // 
            // passworderrorLbl
            // 
            this.passworderrorLbl.AutoSize = true;
            this.passworderrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderrorLbl.Location = new System.Drawing.Point(75, 277);
            this.passworderrorLbl.Name = "passworderrorLbl";
            this.passworderrorLbl.Size = new System.Drawing.Size(17, 21);
            this.passworderrorLbl.TabIndex = 15;
            this.passworderrorLbl.Text = "*";
            this.passworderrorLbl.Visible = false;
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
        private System.Windows.Forms.Label nameerrorLbl;
        private System.Windows.Forms.Label passworderrorLbl;
    }
}