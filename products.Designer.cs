﻿namespace IMS
{
    partial class products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.expiryLbl = new System.Windows.Forms.Label();
            this.barcodeTB = new System.Windows.Forms.TextBox();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.productTB = new System.Windows.Forms.TextBox();
            this.productnameLbl = new System.Windows.Forms.Label();
            this.barcodeerrorLbl = new System.Windows.Forms.Label();
            this.priceerrorLbl = new System.Windows.Forms.Label();
            this.categoryerrorLbl = new System.Windows.Forms.Label();
            this.productnameerrorLbl = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.expiryerrorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(117, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.expiryPicker);
            this.leftPanel.Controls.Add(this.categoryDD);
            this.leftPanel.Controls.Add(this.categoryLbl);
            this.leftPanel.Controls.Add(this.priceTB);
            this.leftPanel.Controls.Add(this.priceLbl);
            this.leftPanel.Controls.Add(this.expiryLbl);
            this.leftPanel.Controls.Add(this.barcodeTB);
            this.leftPanel.Controls.Add(this.barcodeLbl);
            this.leftPanel.Controls.Add(this.productTB);
            this.leftPanel.Controls.Add(this.productnameLbl);
            this.leftPanel.Controls.Add(this.barcodeerrorLbl);
            this.leftPanel.Controls.Add(this.priceerrorLbl);
            this.leftPanel.Controls.Add(this.categoryerrorLbl);
            this.leftPanel.Controls.Add(this.productnameerrorLbl);
            this.leftPanel.Controls.Add(this.expiryerrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 515);
            this.leftPanel.Controls.SetChildIndex(this.expiryerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productnameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productnameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(754, 515);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // categoryDD
            // 
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(10, 277);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(232, 23);
            this.categoryDD.TabIndex = 37;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(7, 259);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(55, 15);
            this.categoryLbl.TabIndex = 36;
            this.categoryLbl.Text = "Category";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(10, 233);
            this.priceTB.MaxLength = 15;
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(232, 23);
            this.priceTB.TabIndex = 28;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(7, 215);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(33, 15);
            this.priceLbl.TabIndex = 27;
            this.priceLbl.Text = "Price\r\n";
            // 
            // expiryLbl
            // 
            this.expiryLbl.AutoSize = true;
            this.expiryLbl.Location = new System.Drawing.Point(7, 171);
            this.expiryLbl.Name = "expiryLbl";
            this.expiryLbl.Size = new System.Drawing.Size(66, 15);
            this.expiryLbl.TabIndex = 25;
            this.expiryLbl.Text = "Expiry Date";
            // 
            // barcodeTB
            // 
            this.barcodeTB.Location = new System.Drawing.Point(10, 145);
            this.barcodeTB.MaxLength = 20;
            this.barcodeTB.Name = "barcodeTB";
            this.barcodeTB.Size = new System.Drawing.Size(232, 23);
            this.barcodeTB.TabIndex = 24;
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Location = new System.Drawing.Point(7, 127);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(50, 15);
            this.barcodeLbl.TabIndex = 23;
            this.barcodeLbl.Text = "Barcode";
            // 
            // productTB
            // 
            this.productTB.Location = new System.Drawing.Point(10, 101);
            this.productTB.MaxLength = 35;
            this.productTB.Name = "productTB";
            this.productTB.Size = new System.Drawing.Size(232, 23);
            this.productTB.TabIndex = 22;
            // 
            // productnameLbl
            // 
            this.productnameLbl.AutoSize = true;
            this.productnameLbl.Location = new System.Drawing.Point(7, 84);
            this.productnameLbl.Name = "productnameLbl";
            this.productnameLbl.Size = new System.Drawing.Size(87, 15);
            this.productnameLbl.TabIndex = 21;
            this.productnameLbl.Text = "Product Name ";
            // 
            // barcodeerrorLbl
            // 
            this.barcodeerrorLbl.AutoSize = true;
            this.barcodeerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeerrorLbl.Location = new System.Drawing.Point(53, 128);
            this.barcodeerrorLbl.Name = "barcodeerrorLbl";
            this.barcodeerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.barcodeerrorLbl.TabIndex = 32;
            this.barcodeerrorLbl.Text = "*";
            this.barcodeerrorLbl.Visible = false;
            // 
            // priceerrorLbl
            // 
            this.priceerrorLbl.AutoSize = true;
            this.priceerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceerrorLbl.Location = new System.Drawing.Point(38, 215);
            this.priceerrorLbl.Name = "priceerrorLbl";
            this.priceerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.priceerrorLbl.TabIndex = 34;
            this.priceerrorLbl.Text = "*";
            this.priceerrorLbl.Visible = false;
            // 
            // categoryerrorLbl
            // 
            this.categoryerrorLbl.AutoSize = true;
            this.categoryerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryerrorLbl.Location = new System.Drawing.Point(62, 260);
            this.categoryerrorLbl.Name = "categoryerrorLbl";
            this.categoryerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.categoryerrorLbl.TabIndex = 38;
            this.categoryerrorLbl.Text = "*";
            this.categoryerrorLbl.Visible = false;
            // 
            // productnameerrorLbl
            // 
            this.productnameerrorLbl.AutoSize = true;
            this.productnameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnameerrorLbl.Location = new System.Drawing.Point(90, 83);
            this.productnameerrorLbl.Name = "productnameerrorLbl";
            this.productnameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.productnameerrorLbl.TabIndex = 39;
            this.productnameerrorLbl.Text = "*";
            this.productnameerrorLbl.Visible = false;
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(10, 189);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(232, 23);
            this.expiryPicker.TabIndex = 40;
            // 
            // expiryerrorLbl
            // 
            this.expiryerrorLbl.AutoSize = true;
            this.expiryerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryerrorLbl.Location = new System.Drawing.Point(70, 171);
            this.expiryerrorLbl.Name = "expiryerrorLbl";
            this.expiryerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.expiryerrorLbl.TabIndex = 41;
            this.expiryerrorLbl.Text = "*";
            this.expiryerrorLbl.Visible = false;
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
            this.barcodeGV,
            this.expiryGV,
            this.priceGV,
            this.catIDGV,
            this.catGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(754, 417);
            this.dataGridView1.TabIndex = 3;
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
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "Category ID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Name = "products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label expiryLbl;
        private System.Windows.Forms.TextBox barcodeTB;
        private System.Windows.Forms.Label barcodeLbl;
        private System.Windows.Forms.TextBox productTB;
        private System.Windows.Forms.Label productnameLbl;
        private System.Windows.Forms.Label barcodeerrorLbl;
        private System.Windows.Forms.Label priceerrorLbl;
        private System.Windows.Forms.Label categoryerrorLbl;
        private System.Windows.Forms.Label productnameerrorLbl;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label expiryerrorLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}