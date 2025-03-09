namespace IMS
{
    partial class PurchaseInvoice
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
            this.selectsupplierBtn = new System.Windows.Forms.Label();
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.productnameTB = new System.Windows.Forms.TextBox();
            this.productnameLbl = new System.Windows.Forms.Label();
            this.productnameerrorLbl = new System.Windows.Forms.Label();
            this.barcodeTB = new System.Windows.Forms.TextBox();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.barcodeerrorLbl = new System.Windows.Forms.Label();
            this.perunitpiceTB = new System.Windows.Forms.TextBox();
            this.perunitpriceLbl = new System.Windows.Forms.Label();
            this.perunitpriceerrorLbl = new System.Windows.Forms.Label();
            this.quatityTB = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityerrorLbl = new System.Windows.Forms.Label();
            this.addtocartBtn = new System.Windows.Forms.Button();
            this.totalamountLbl = new System.Windows.Forms.Label();
            this.amoutLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossamountLbl = new System.Windows.Forms.Label();
            this.grosstotalLbl = new System.Windows.Forms.Label();
            this.suppliererrorLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(758, 53);
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(116, 23);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.amoutLbl);
            this.leftPanel.Controls.Add(this.totalamountLbl);
            this.leftPanel.Controls.Add(this.addtocartBtn);
            this.leftPanel.Controls.Add(this.quatityTB);
            this.leftPanel.Controls.Add(this.quantityLbl);
            this.leftPanel.Controls.Add(this.quantityerrorLbl);
            this.leftPanel.Controls.Add(this.perunitpiceTB);
            this.leftPanel.Controls.Add(this.perunitpriceLbl);
            this.leftPanel.Controls.Add(this.perunitpriceerrorLbl);
            this.leftPanel.Controls.Add(this.barcodeTB);
            this.leftPanel.Controls.Add(this.barcodeLbl);
            this.leftPanel.Controls.Add(this.barcodeerrorLbl);
            this.leftPanel.Controls.Add(this.productnameTB);
            this.leftPanel.Controls.Add(this.productnameLbl);
            this.leftPanel.Controls.Add(this.productnameerrorLbl);
            this.leftPanel.Controls.Add(this.supplierDD);
            this.leftPanel.Controls.Add(this.selectsupplierBtn);
            this.leftPanel.Controls.Add(this.suppliererrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 532);
            this.leftPanel.Controls.SetChildIndex(this.suppliererrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.selectsupplierBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.productnameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productnameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productnameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.perunitpriceerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.perunitpriceLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.perunitpiceTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.quatityTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.addtocartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalamountLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.amoutLbl, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.footerPanel);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(758, 532);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.footerPanel, 0);
            // 
            // selectsupplierBtn
            // 
            this.selectsupplierBtn.AutoSize = true;
            this.selectsupplierBtn.Location = new System.Drawing.Point(9, 80);
            this.selectsupplierBtn.Name = "selectsupplierBtn";
            this.selectsupplierBtn.Size = new System.Drawing.Size(84, 15);
            this.selectsupplierBtn.TabIndex = 1;
            this.selectsupplierBtn.Text = "Select Supplier";
            // 
            // supplierDD
            // 
            this.supplierDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(12, 98);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(232, 23);
            this.supplierDD.TabIndex = 2;
            // 
            // productnameTB
            // 
            this.productnameTB.Location = new System.Drawing.Point(12, 185);
            this.productnameTB.MaxLength = 35;
            this.productnameTB.Name = "productnameTB";
            this.productnameTB.Size = new System.Drawing.Size(232, 23);
            this.productnameTB.TabIndex = 6;
            // 
            // productnameLbl
            // 
            this.productnameLbl.AutoSize = true;
            this.productnameLbl.Location = new System.Drawing.Point(9, 168);
            this.productnameLbl.Name = "productnameLbl";
            this.productnameLbl.Size = new System.Drawing.Size(87, 15);
            this.productnameLbl.TabIndex = 40;
            this.productnameLbl.Text = "Product Name ";
            // 
            // productnameerrorLbl
            // 
            this.productnameerrorLbl.AutoSize = true;
            this.productnameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnameerrorLbl.Location = new System.Drawing.Point(95, 168);
            this.productnameerrorLbl.Name = "productnameerrorLbl";
            this.productnameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.productnameerrorLbl.TabIndex = 42;
            this.productnameerrorLbl.Text = "*";
            this.productnameerrorLbl.Visible = false;
            // 
            // barcodeTB
            // 
            this.barcodeTB.Location = new System.Drawing.Point(12, 142);
            this.barcodeTB.MaxLength = 20;
            this.barcodeTB.Name = "barcodeTB";
            this.barcodeTB.Size = new System.Drawing.Size(232, 23);
            this.barcodeTB.TabIndex = 4;
            this.barcodeTB.TextChanged += new System.EventHandler(this.barcodeTB_TextChanged_1);
            this.barcodeTB.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTB_Validating);
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Location = new System.Drawing.Point(9, 124);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(50, 15);
            this.barcodeLbl.TabIndex = 43;
            this.barcodeLbl.Text = "Barcode";
            // 
            // barcodeerrorLbl
            // 
            this.barcodeerrorLbl.AutoSize = true;
            this.barcodeerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeerrorLbl.Location = new System.Drawing.Point(62, 125);
            this.barcodeerrorLbl.Name = "barcodeerrorLbl";
            this.barcodeerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.barcodeerrorLbl.TabIndex = 45;
            this.barcodeerrorLbl.Text = "*";
            this.barcodeerrorLbl.Visible = false;
            // 
            // perunitpiceTB
            // 
            this.perunitpiceTB.Location = new System.Drawing.Point(12, 229);
            this.perunitpiceTB.MaxLength = 20;
            this.perunitpiceTB.Name = "perunitpiceTB";
            this.perunitpiceTB.Size = new System.Drawing.Size(232, 23);
            this.perunitpiceTB.TabIndex = 8;
            this.perunitpiceTB.TextChanged += new System.EventHandler(this.perunitpiceTB_TextChanged);
            // 
            // perunitpriceLbl
            // 
            this.perunitpriceLbl.AutoSize = true;
            this.perunitpriceLbl.Location = new System.Drawing.Point(9, 211);
            this.perunitpriceLbl.Name = "perunitpriceLbl";
            this.perunitpriceLbl.Size = new System.Drawing.Size(78, 15);
            this.perunitpriceLbl.TabIndex = 46;
            this.perunitpriceLbl.Text = "Per Unit Price";
            // 
            // perunitpriceerrorLbl
            // 
            this.perunitpriceerrorLbl.AutoSize = true;
            this.perunitpriceerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perunitpriceerrorLbl.Location = new System.Drawing.Point(89, 212);
            this.perunitpriceerrorLbl.Name = "perunitpriceerrorLbl";
            this.perunitpriceerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.perunitpriceerrorLbl.TabIndex = 48;
            this.perunitpriceerrorLbl.Text = "*";
            this.perunitpriceerrorLbl.Visible = false;
            // 
            // quatityTB
            // 
            this.quatityTB.Location = new System.Drawing.Point(12, 275);
            this.quatityTB.MaxLength = 20;
            this.quatityTB.Name = "quatityTB";
            this.quatityTB.Size = new System.Drawing.Size(232, 23);
            this.quatityTB.TabIndex = 10;
            this.quatityTB.TextChanged += new System.EventHandler(this.quatityTB_TextChanged);
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(9, 257);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(53, 15);
            this.quantityLbl.TabIndex = 49;
            this.quantityLbl.Text = "Quantity";
            // 
            // quantityerrorLbl
            // 
            this.quantityerrorLbl.AutoSize = true;
            this.quantityerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityerrorLbl.Location = new System.Drawing.Point(67, 258);
            this.quantityerrorLbl.Name = "quantityerrorLbl";
            this.quantityerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.quantityerrorLbl.TabIndex = 51;
            this.quantityerrorLbl.Text = "*";
            this.quantityerrorLbl.Visible = false;
            // 
            // addtocartBtn
            // 
            this.addtocartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtocartBtn.FlatAppearance.BorderSize = 2;
            this.addtocartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtocartBtn.Location = new System.Drawing.Point(12, 304);
            this.addtocartBtn.Name = "addtocartBtn";
            this.addtocartBtn.Size = new System.Drawing.Size(232, 41);
            this.addtocartBtn.TabIndex = 12;
            this.addtocartBtn.Text = "ADD TO CART";
            this.addtocartBtn.UseVisualStyleBackColor = true;
            this.addtocartBtn.Click += new System.EventHandler(this.addtocartBtn_Click);
            // 
            // totalamountLbl
            // 
            this.totalamountLbl.AutoSize = true;
            this.totalamountLbl.Location = new System.Drawing.Point(12, 348);
            this.totalamountLbl.Name = "totalamountLbl";
            this.totalamountLbl.Size = new System.Drawing.Size(79, 15);
            this.totalamountLbl.TabIndex = 52;
            this.totalamountLbl.Text = "Total Amount";
            // 
            // amoutLbl
            // 
            this.amoutLbl.AutoSize = true;
            this.amoutLbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amoutLbl.Location = new System.Drawing.Point(73, 363);
            this.amoutLbl.Name = "amoutLbl";
            this.amoutLbl.Size = new System.Drawing.Size(68, 37);
            this.amoutLbl.TabIndex = 53;
            this.amoutLbl.Text = "0.00";
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
            this.proIDGV,
            this.proNameGV,
            this.quantityGV,
            this.perunitpriceGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 391);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proNameGV
            // 
            this.proNameGV.HeaderText = "Product";
            this.proNameGV.Name = "proNameGV";
            this.proNameGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // perunitpriceGV
            // 
            this.perunitpriceGV.HeaderText = "Per Unit Price";
            this.perunitpriceGV.Name = "perunitpriceGV";
            this.perunitpriceGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Total Amount";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.tableLayoutPanel2);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(0, 489);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(758, 43);
            this.footerPanel.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.21372F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.78628F));
            this.tableLayoutPanel2.Controls.Add(this.grossamountLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grosstotalLbl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 43);
            this.tableLayoutPanel2.TabIndex = 56;
            // 
            // grossamountLbl
            // 
            this.grossamountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossamountLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossamountLbl.Location = new System.Drawing.Point(467, 0);
            this.grossamountLbl.Name = "grossamountLbl";
            this.grossamountLbl.Size = new System.Drawing.Size(288, 43);
            this.grossamountLbl.TabIndex = 55;
            this.grossamountLbl.Text = "0.00";
            this.grossamountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grosstotalLbl
            // 
            this.grosstotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grosstotalLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosstotalLbl.Location = new System.Drawing.Point(3, 0);
            this.grosstotalLbl.Name = "grosstotalLbl";
            this.grosstotalLbl.Size = new System.Drawing.Size(458, 43);
            this.grosstotalLbl.TabIndex = 54;
            this.grosstotalLbl.Text = "Gross Total";
            this.grosstotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // suppliererrorLbl
            // 
            this.suppliererrorLbl.AutoSize = true;
            this.suppliererrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliererrorLbl.Location = new System.Drawing.Point(104, 79);
            this.suppliererrorLbl.Name = "suppliererrorLbl";
            this.suppliererrorLbl.Size = new System.Drawing.Size(17, 21);
            this.suppliererrorLbl.TabIndex = 54;
            this.suppliererrorLbl.Text = "*";
            this.suppliererrorLbl.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 532);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.Label selectsupplierBtn;
        private System.Windows.Forms.TextBox productnameTB;
        private System.Windows.Forms.Label productnameLbl;
        private System.Windows.Forms.Label productnameerrorLbl;
        private System.Windows.Forms.TextBox perunitpiceTB;
        private System.Windows.Forms.Label perunitpriceLbl;
        private System.Windows.Forms.Label perunitpriceerrorLbl;
        private System.Windows.Forms.TextBox barcodeTB;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.Label barcodeerrorLbl;
        private System.Windows.Forms.Button addtocartBtn;
        private System.Windows.Forms.TextBox quatityTB;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label quantityerrorLbl;
        private System.Windows.Forms.Label amoutLbl;
        private System.Windows.Forms.Label totalamountLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grosstotalLbl;
        private System.Windows.Forms.Label grossamountLbl;
        private System.Windows.Forms.Label suppliererrorLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}