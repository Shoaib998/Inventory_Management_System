namespace IMS
{
    partial class Supplier
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
            this.suppliercompanyLbl = new System.Windows.Forms.Label();
            this.suppliercompanyTB = new System.Windows.Forms.TextBox();
            this.personnameTB = new System.Windows.Forms.TextBox();
            this.personnameLbl = new System.Windows.Forms.Label();
            this.phone1TB = new System.Windows.Forms.TextBox();
            this.phone1Lbl = new System.Windows.Forms.Label();
            this.phone2TB = new System.Windows.Forms.TextBox();
            this.phone2Lbl = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.ntnTB = new System.Windows.Forms.TextBox();
            this.ntnLbl = new System.Windows.Forms.Label();
            this.suppliernameerrorLbl = new System.Windows.Forms.Label();
            this.personnameerrorLbl = new System.Windows.Forms.Label();
            this.phone1errorLbl = new System.Windows.Forms.Label();
            this.addresserrorLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statuserrorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(107, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.statusLbl);
            this.leftPanel.Controls.Add(this.ntnTB);
            this.leftPanel.Controls.Add(this.ntnLbl);
            this.leftPanel.Controls.Add(this.addressTB);
            this.leftPanel.Controls.Add(this.addressLbl);
            this.leftPanel.Controls.Add(this.phone2TB);
            this.leftPanel.Controls.Add(this.phone2Lbl);
            this.leftPanel.Controls.Add(this.phone1TB);
            this.leftPanel.Controls.Add(this.phone1Lbl);
            this.leftPanel.Controls.Add(this.personnameTB);
            this.leftPanel.Controls.Add(this.personnameLbl);
            this.leftPanel.Controls.Add(this.suppliercompanyTB);
            this.leftPanel.Controls.Add(this.suppliercompanyLbl);
            this.leftPanel.Controls.Add(this.suppliernameerrorLbl);
            this.leftPanel.Controls.Add(this.personnameerrorLbl);
            this.leftPanel.Controls.Add(this.phone1errorLbl);
            this.leftPanel.Controls.Add(this.addresserrorLbl);
            this.leftPanel.Controls.Add(this.statuserrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 472);
            this.leftPanel.Controls.SetChildIndex(this.statuserrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.addresserrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1errorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.personnameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.suppliernameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.suppliercompanyLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.suppliercompanyTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.personnameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.personnameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1Lbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1TB, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone2Lbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone2TB, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(709, 472);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // suppliercompanyLbl
            // 
            this.suppliercompanyLbl.AutoSize = true;
            this.suppliercompanyLbl.Location = new System.Drawing.Point(6, 83);
            this.suppliercompanyLbl.Name = "suppliercompanyLbl";
            this.suppliercompanyLbl.Size = new System.Drawing.Size(142, 15);
            this.suppliercompanyLbl.TabIndex = 1;
            this.suppliercompanyLbl.Text = "Supplier Name/Company";
            // 
            // suppliercompanyTB
            // 
            this.suppliercompanyTB.Location = new System.Drawing.Point(9, 101);
            this.suppliercompanyTB.MaxLength = 100;
            this.suppliercompanyTB.Name = "suppliercompanyTB";
            this.suppliercompanyTB.Size = new System.Drawing.Size(235, 23);
            this.suppliercompanyTB.TabIndex = 2;
            // 
            // personnameTB
            // 
            this.personnameTB.Location = new System.Drawing.Point(9, 145);
            this.personnameTB.MaxLength = 50;
            this.personnameTB.Name = "personnameTB";
            this.personnameTB.Size = new System.Drawing.Size(235, 23);
            this.personnameTB.TabIndex = 4;
            // 
            // personnameLbl
            // 
            this.personnameLbl.AutoSize = true;
            this.personnameLbl.Location = new System.Drawing.Point(6, 127);
            this.personnameLbl.Name = "personnameLbl";
            this.personnameLbl.Size = new System.Drawing.Size(78, 15);
            this.personnameLbl.TabIndex = 3;
            this.personnameLbl.Text = "Person Name";
            // 
            // phone1TB
            // 
            this.phone1TB.Location = new System.Drawing.Point(9, 189);
            this.phone1TB.MaxLength = 15;
            this.phone1TB.Name = "phone1TB";
            this.phone1TB.Size = new System.Drawing.Size(235, 23);
            this.phone1TB.TabIndex = 6;
            // 
            // phone1Lbl
            // 
            this.phone1Lbl.AutoSize = true;
            this.phone1Lbl.Location = new System.Drawing.Point(6, 171);
            this.phone1Lbl.Name = "phone1Lbl";
            this.phone1Lbl.Size = new System.Drawing.Size(50, 15);
            this.phone1Lbl.TabIndex = 5;
            this.phone1Lbl.Text = "Phone 1";
            // 
            // phone2TB
            // 
            this.phone2TB.Location = new System.Drawing.Point(9, 233);
            this.phone2TB.MaxLength = 15;
            this.phone2TB.Name = "phone2TB";
            this.phone2TB.Size = new System.Drawing.Size(235, 23);
            this.phone2TB.TabIndex = 8;
            // 
            // phone2Lbl
            // 
            this.phone2Lbl.AutoSize = true;
            this.phone2Lbl.Location = new System.Drawing.Point(6, 215);
            this.phone2Lbl.Name = "phone2Lbl";
            this.phone2Lbl.Size = new System.Drawing.Size(50, 15);
            this.phone2Lbl.TabIndex = 7;
            this.phone2Lbl.Text = "Phone 2";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(9, 277);
            this.addressTB.MaxLength = 100;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(235, 23);
            this.addressTB.TabIndex = 10;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(6, 259);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(49, 15);
            this.addressLbl.TabIndex = 9;
            this.addressLbl.Text = "Address";
            // 
            // ntnTB
            // 
            this.ntnTB.Location = new System.Drawing.Point(9, 321);
            this.ntnTB.MaxLength = 25;
            this.ntnTB.Name = "ntnTB";
            this.ntnTB.Size = new System.Drawing.Size(235, 23);
            this.ntnTB.TabIndex = 12;
            // 
            // ntnLbl
            // 
            this.ntnLbl.AutoSize = true;
            this.ntnLbl.Location = new System.Drawing.Point(6, 303);
            this.ntnLbl.Name = "ntnLbl";
            this.ntnLbl.Size = new System.Drawing.Size(41, 15);
            this.ntnLbl.TabIndex = 11;
            this.ntnLbl.Text = "NTN #";
            // 
            // suppliernameerrorLbl
            // 
            this.suppliernameerrorLbl.AutoSize = true;
            this.suppliernameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliernameerrorLbl.Location = new System.Drawing.Point(154, 83);
            this.suppliernameerrorLbl.Name = "suppliernameerrorLbl";
            this.suppliernameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.suppliernameerrorLbl.TabIndex = 14;
            this.suppliernameerrorLbl.Text = "*";
            this.suppliernameerrorLbl.Visible = false;
            // 
            // personnameerrorLbl
            // 
            this.personnameerrorLbl.AutoSize = true;
            this.personnameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnameerrorLbl.Location = new System.Drawing.Point(90, 127);
            this.personnameerrorLbl.Name = "personnameerrorLbl";
            this.personnameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.personnameerrorLbl.TabIndex = 15;
            this.personnameerrorLbl.Text = "*";
            this.personnameerrorLbl.Visible = false;
            // 
            // phone1errorLbl
            // 
            this.phone1errorLbl.AutoSize = true;
            this.phone1errorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1errorLbl.Location = new System.Drawing.Point(62, 171);
            this.phone1errorLbl.Name = "phone1errorLbl";
            this.phone1errorLbl.Size = new System.Drawing.Size(17, 21);
            this.phone1errorLbl.TabIndex = 16;
            this.phone1errorLbl.Text = "*";
            this.phone1errorLbl.Visible = false;
            // 
            // addresserrorLbl
            // 
            this.addresserrorLbl.AutoSize = true;
            this.addresserrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresserrorLbl.Location = new System.Drawing.Point(61, 259);
            this.addresserrorLbl.Name = "addresserrorLbl";
            this.addresserrorLbl.Size = new System.Drawing.Size(17, 21);
            this.addresserrorLbl.TabIndex = 17;
            this.addresserrorLbl.Text = "*";
            this.addresserrorLbl.Visible = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(6, 347);
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
            this.statusDD.Location = new System.Drawing.Point(9, 365);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(235, 23);
            this.statusDD.TabIndex = 19;
            // 
            // statuserrorLbl
            // 
            this.statuserrorLbl.AutoSize = true;
            this.statuserrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuserrorLbl.Location = new System.Drawing.Point(51, 347);
            this.statuserrorLbl.Name = "statuserrorLbl";
            this.statuserrorLbl.Size = new System.Drawing.Size(17, 21);
            this.statuserrorLbl.TabIndex = 20;
            this.statuserrorLbl.Text = "*";
            this.statuserrorLbl.Visible = false;
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
            this.suppIDGV,
            this.companyNameGV,
            this.personNameGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
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
            this.dataGridView1.Size = new System.Drawing.Size(709, 374);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "Supplier ID";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyNameGV
            // 
            this.companyNameGV.HeaderText = "Company Name";
            this.companyNameGV.Name = "companyNameGV";
            this.companyNameGV.ReadOnly = true;
            // 
            // personNameGV
            // 
            this.personNameGV.HeaderText = "Person Name";
            this.personNameGV.Name = "personNameGV";
            this.personNameGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 472);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox personnameTB;
        private System.Windows.Forms.Label personnameLbl;
        private System.Windows.Forms.TextBox suppliercompanyTB;
        private System.Windows.Forms.Label suppliercompanyLbl;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox phone2TB;
        private System.Windows.Forms.Label phone2Lbl;
        private System.Windows.Forms.TextBox phone1TB;
        private System.Windows.Forms.Label phone1Lbl;
        private System.Windows.Forms.TextBox ntnTB;
        private System.Windows.Forms.Label ntnLbl;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label suppliernameerrorLbl;
        private System.Windows.Forms.Label personnameerrorLbl;
        private System.Windows.Forms.Label phone1errorLbl;
        private System.Windows.Forms.Label addresserrorLbl;
        private System.Windows.Forms.Label statuserrorLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}