namespace IMS
{
    partial class settings
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
            this.serverLbl = new System.Windows.Forms.Label();
            this.serverTB = new System.Windows.Forms.TextBox();
            this.dbTB = new System.Windows.Forms.TextBox();
            this.dbLbl = new System.Windows.Forms.Label();
            this.useridTB = new System.Windows.Forms.TextBox();
            this.useridLbl = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.ISCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.ISCB);
            this.leftPanel.Controls.Add(this.passwordTB);
            this.leftPanel.Controls.Add(this.passwordLbl);
            this.leftPanel.Controls.Add(this.useridTB);
            this.leftPanel.Controls.Add(this.useridLbl);
            this.leftPanel.Controls.Add(this.dbTB);
            this.leftPanel.Controls.Add(this.dbLbl);
            this.leftPanel.Controls.Add(this.serverTB);
            this.leftPanel.Controls.Add(this.serverLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 534);
            this.leftPanel.Controls.SetChildIndex(this.serverLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.useridLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.useridTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.ISCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Location = new System.Drawing.Point(3, 173);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(42, 15);
            this.serverLbl.TabIndex = 1;
            this.serverLbl.Text = "Server:";
            // 
            // serverTB
            // 
            this.serverTB.Location = new System.Drawing.Point(6, 191);
            this.serverTB.MaxLength = 50;
            this.serverTB.Name = "serverTB";
            this.serverTB.Size = new System.Drawing.Size(238, 23);
            this.serverTB.TabIndex = 2;
            // 
            // dbTB
            // 
            this.dbTB.Location = new System.Drawing.Point(6, 235);
            this.dbTB.MaxLength = 50;
            this.dbTB.Name = "dbTB";
            this.dbTB.Size = new System.Drawing.Size(238, 23);
            this.dbTB.TabIndex = 4;
            // 
            // dbLbl
            // 
            this.dbLbl.AutoSize = true;
            this.dbLbl.Location = new System.Drawing.Point(3, 217);
            this.dbLbl.Name = "dbLbl";
            this.dbLbl.Size = new System.Drawing.Size(58, 15);
            this.dbLbl.TabIndex = 3;
            this.dbLbl.Text = "Database:";
            // 
            // useridTB
            // 
            this.useridTB.Location = new System.Drawing.Point(6, 279);
            this.useridTB.MaxLength = 30;
            this.useridTB.Name = "useridTB";
            this.useridTB.Size = new System.Drawing.Size(238, 23);
            this.useridTB.TabIndex = 6;
            // 
            // useridLbl
            // 
            this.useridLbl.AutoSize = true;
            this.useridLbl.Location = new System.Drawing.Point(3, 261);
            this.useridLbl.Name = "useridLbl";
            this.useridLbl.Size = new System.Drawing.Size(47, 15);
            this.useridLbl.TabIndex = 5;
            this.useridLbl.Text = "User ID:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(6, 323);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(238, 23);
            this.passwordTB.TabIndex = 8;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(3, 305);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(60, 15);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password:";
            // 
            // ISCB
            // 
            this.ISCB.AutoSize = true;
            this.ISCB.Location = new System.Drawing.Point(6, 352);
            this.ISCB.Name = "ISCB";
            this.ISCB.Size = new System.Drawing.Size(125, 19);
            this.ISCB.TabIndex = 9;
            this.ISCB.Text = "Integrated Security";
            this.ISCB.UseVisualStyleBackColor = true;
            this.ISCB.CheckedChanged += new System.EventHandler(this.ISCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(6, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(238, 37);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 534);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox ISCB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox useridTB;
        private System.Windows.Forms.Label useridLbl;
        private System.Windows.Forms.TextBox dbTB;
        private System.Windows.Forms.Label dbLbl;
        private System.Windows.Forms.TextBox serverTB;
        private System.Windows.Forms.Label serverLbl;
    }
}