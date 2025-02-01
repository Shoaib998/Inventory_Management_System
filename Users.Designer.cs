namespace IMS
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nameerrorLbl = new System.Windows.Forms.Label();
            this.usernameerrorLbl = new System.Windows.Forms.Label();
            this.passworderrorLbl = new System.Windows.Forms.Label();
            this.phoneerrorLbl = new System.Windows.Forms.Label();
            this.emailerrorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statuserrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(122, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.statusLbl);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Controls.Add(this.emailTB);
            this.leftPanel.Controls.Add(this.emailLbl);
            this.leftPanel.Controls.Add(this.phoneTB);
            this.leftPanel.Controls.Add(this.phoneLbl);
            this.leftPanel.Controls.Add(this.passwordTB);
            this.leftPanel.Controls.Add(this.passwordLbl);
            this.leftPanel.Controls.Add(this.usernameTB);
            this.leftPanel.Controls.Add(this.usernameLbl);
            this.leftPanel.Controls.Add(this.nameTB);
            this.leftPanel.Controls.Add(this.nameLbl);
            this.leftPanel.Controls.Add(this.nameerrorLbl);
            this.leftPanel.Controls.Add(this.usernameerrorLbl);
            this.leftPanel.Controls.Add(this.passworderrorLbl);
            this.leftPanel.Controls.Add(this.phoneerrorLbl);
            this.leftPanel.Controls.Add(this.emailerrorLbl);
            this.leftPanel.Controls.Add(this.statuserrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 524);
            this.leftPanel.Controls.SetChildIndex(this.statuserrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passworderrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(794, 524);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(7, 98);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(42, 15);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name ";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(10, 116);
            this.nameTB.MaxLength = 35;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(232, 23);
            this.nameTB.TabIndex = 3;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(10, 160);
            this.usernameTB.MaxLength = 20;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(232, 23);
            this.usernameTB.TabIndex = 5;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(7, 142);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(68, 15);
            this.usernameLbl.TabIndex = 4;
            this.usernameLbl.Text = "User Name ";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(10, 204);
            this.passwordTB.MaxLength = 20;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(232, 23);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(7, 186);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(60, 15);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password ";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(10, 248);
            this.phoneTB.MaxLength = 15;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(232, 23);
            this.phoneTB.TabIndex = 9;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Location = new System.Drawing.Point(7, 230);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(132, 15);
            this.phoneLbl.TabIndex = 8;
            this.phoneLbl.Text = "Phone (03XX-XXXXXXX)";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(10, 291);
            this.emailTB.MaxLength = 50;
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(232, 23);
            this.emailTB.TabIndex = 11;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(7, 273);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(44, 15);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "E-mail ";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 12;
            // 
            // nameerrorLbl
            // 
            this.nameerrorLbl.AutoSize = true;
            this.nameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameerrorLbl.Location = new System.Drawing.Point(44, 98);
            this.nameerrorLbl.Name = "nameerrorLbl";
            this.nameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.nameerrorLbl.TabIndex = 13;
            this.nameerrorLbl.Text = "*";
            this.nameerrorLbl.Visible = false;
            // 
            // usernameerrorLbl
            // 
            this.usernameerrorLbl.AutoSize = true;
            this.usernameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameerrorLbl.Location = new System.Drawing.Point(71, 143);
            this.usernameerrorLbl.Name = "usernameerrorLbl";
            this.usernameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.usernameerrorLbl.TabIndex = 14;
            this.usernameerrorLbl.Text = "*";
            this.usernameerrorLbl.Visible = false;
            // 
            // passworderrorLbl
            // 
            this.passworderrorLbl.AutoSize = true;
            this.passworderrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderrorLbl.Location = new System.Drawing.Point(62, 186);
            this.passworderrorLbl.Name = "passworderrorLbl";
            this.passworderrorLbl.Size = new System.Drawing.Size(17, 21);
            this.passworderrorLbl.TabIndex = 15;
            this.passworderrorLbl.Text = "*";
            this.passworderrorLbl.Visible = false;
            // 
            // phoneerrorLbl
            // 
            this.phoneerrorLbl.AutoSize = true;
            this.phoneerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneerrorLbl.Location = new System.Drawing.Point(135, 230);
            this.phoneerrorLbl.Name = "phoneerrorLbl";
            this.phoneerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.phoneerrorLbl.TabIndex = 16;
            this.phoneerrorLbl.Text = "*";
            this.phoneerrorLbl.Visible = false;
            // 
            // emailerrorLbl
            // 
            this.emailerrorLbl.AutoSize = true;
            this.emailerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailerrorLbl.Location = new System.Drawing.Point(47, 273);
            this.emailerrorLbl.Name = "emailerrorLbl";
            this.emailerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.emailerrorLbl.TabIndex = 17;
            this.emailerrorLbl.Text = "*";
            this.emailerrorLbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDGV,
            this.NameGV,
            this.UsernameGV,
            this.PasswordGV,
            this.EmailGV,
            this.PhoneGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "User ID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UsernameGV
            // 
            this.UsernameGV.HeaderText = "User Name";
            this.UsernameGV.Name = "UsernameGV";
            this.UsernameGV.ReadOnly = true;
            // 
            // PasswordGV
            // 
            this.PasswordGV.HeaderText = "Password";
            this.PasswordGV.Name = "PasswordGV";
            this.PasswordGV.ReadOnly = true;
            this.PasswordGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone #";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(7, 317);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(39, 15);
            this.statusLbl.TabIndex = 18;
            this.statusLbl.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(10, 335);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(229, 23);
            this.statusDD.TabIndex = 19;
            // 
            // statuserrorLbl
            // 
            this.statuserrorLbl.AutoSize = true;
            this.statuserrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserrorLbl.Location = new System.Drawing.Point(43, 317);
            this.statuserrorLbl.Name = "statuserrorLbl";
            this.statuserrorLbl.Size = new System.Drawing.Size(17, 21);
            this.statuserrorLbl.TabIndex = 20;
            this.statuserrorLbl.Text = "*";
            this.statuserrorLbl.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 524);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label nameerrorLbl;
        private System.Windows.Forms.Label usernameerrorLbl;
        private System.Windows.Forms.Label passworderrorLbl;
        private System.Windows.Forms.Label phoneerrorLbl;
        private System.Windows.Forms.Label emailerrorLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label statuserrorLbl;
    }
}