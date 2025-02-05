namespace IMS
{
    partial class PurchaseInvoiceDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectDateLbl = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.selectPurchaseInvoiceLbl = new System.Windows.Forms.Label();
            this.selectPurchaseInvoiceDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossamountLbl = new System.Windows.Forms.Label();
            this.grosstotalLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(111, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.selectPurchaseInvoiceDD);
            this.leftPanel.Controls.Add(this.selectPurchaseInvoiceLbl);
            this.leftPanel.Controls.Add(this.datePicker);
            this.leftPanel.Controls.Add(this.selectDateLbl);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.selectDateLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.datePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.selectPurchaseInvoiceLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.selectPurchaseInvoiceDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(728, 537);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // selectDateLbl
            // 
            this.selectDateLbl.AutoSize = true;
            this.selectDateLbl.Location = new System.Drawing.Point(7, 80);
            this.selectDateLbl.Name = "selectDateLbl";
            this.selectDateLbl.Size = new System.Drawing.Size(65, 15);
            this.selectDateLbl.TabIndex = 1;
            this.selectDateLbl.Text = "Select Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MMMM- yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(10, 98);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(234, 23);
            this.datePicker.TabIndex = 41;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // selectPurchaseInvoiceLbl
            // 
            this.selectPurchaseInvoiceLbl.AutoSize = true;
            this.selectPurchaseInvoiceLbl.Location = new System.Drawing.Point(7, 124);
            this.selectPurchaseInvoiceLbl.Name = "selectPurchaseInvoiceLbl";
            this.selectPurchaseInvoiceLbl.Size = new System.Drawing.Size(130, 15);
            this.selectPurchaseInvoiceLbl.TabIndex = 42;
            this.selectPurchaseInvoiceLbl.Text = "Select Purchase Invoice";
            // 
            // selectPurchaseInvoiceDD
            // 
            this.selectPurchaseInvoiceDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPurchaseInvoiceDD.FormattingEnabled = true;
            this.selectPurchaseInvoiceDD.Location = new System.Drawing.Point(10, 142);
            this.selectPurchaseInvoiceDD.Name = "selectPurchaseInvoiceDD";
            this.selectPurchaseInvoiceDD.Size = new System.Drawing.Size(234, 23);
            this.selectPurchaseInvoiceDD.TabIndex = 43;
            this.selectPurchaseInvoiceDD.SelectedIndexChanged += new System.EventHandler(this.selectPurchaseInvoiceDD_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIDGV,
            this.proNameGV,
            this.quantityGV,
            this.perunitpriceGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 391);
            this.dataGridView1.TabIndex = 5;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.21372F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.78628F));
            this.tableLayoutPanel2.Controls.Add(this.grossamountLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grosstotalLbl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 489);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 48);
            this.tableLayoutPanel2.TabIndex = 57;
            // 
            // grossamountLbl
            // 
            this.grossamountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossamountLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossamountLbl.Location = new System.Drawing.Point(448, 0);
            this.grossamountLbl.Name = "grossamountLbl";
            this.grossamountLbl.Size = new System.Drawing.Size(277, 48);
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
            this.grosstotalLbl.Size = new System.Drawing.Size(439, 48);
            this.grosstotalLbl.TabIndex = 54;
            this.grosstotalLbl.Text = "Gross Total";
            this.grosstotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 537);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "Purchase Invoice Details";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectDateLbl;
        private System.Windows.Forms.Label selectPurchaseInvoiceLbl;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox selectPurchaseInvoiceDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grossamountLbl;
        private System.Windows.Forms.Label grosstotalLbl;
    }
}