namespace IMS
{
    partial class SalesReturnWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.enterSalesIDLbl = new System.Windows.Forms.Label();
            this.enterSalesIDTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProductDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProductTotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.UsrLbl = new System.Windows.Forms.Label();
            this.payTypeTB = new System.Windows.Forms.TextBox();
            this.payTypeLbl = new System.Windows.Forms.Label();
            this.AmountToRefundTB = new System.Windows.Forms.TextBox();
            this.AmountToRefundLbl = new System.Windows.Forms.Label();
            this.enterBarcodeTB = new System.Windows.Forms.TextBox();
            this.enterBarcodeLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(774, 53);
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(117, 23);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.AmountToRefundTB);
            this.leftPanel.Controls.Add(this.AmountToRefundLbl);
            this.leftPanel.Controls.Add(this.enterBarcodeTB);
            this.leftPanel.Controls.Add(this.enterBarcodeLbl);
            this.leftPanel.Controls.Add(this.payTypeTB);
            this.leftPanel.Controls.Add(this.payTypeLbl);
            this.leftPanel.Controls.Add(this.UserTB);
            this.leftPanel.Controls.Add(this.UsrLbl);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Controls.Add(this.dateLbl);
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.enterSalesIDTB);
            this.leftPanel.Controls.Add(this.enterSalesIDLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 568);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.enterSalesIDLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.enterSalesIDTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.UsrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.UserTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.payTypeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.payTypeTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.enterBarcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.enterBarcodeTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.AmountToRefundLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.AmountToRefundTB, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(774, 568);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // enterSalesIDLbl
            // 
            this.enterSalesIDLbl.AutoSize = true;
            this.enterSalesIDLbl.Location = new System.Drawing.Point(3, 80);
            this.enterSalesIDLbl.Name = "enterSalesIDLbl";
            this.enterSalesIDLbl.Size = new System.Drawing.Size(77, 15);
            this.enterSalesIDLbl.TabIndex = 1;
            this.enterSalesIDLbl.Text = "Enter Sales ID";
            // 
            // enterSalesIDTB
            // 
            this.enterSalesIDTB.Location = new System.Drawing.Point(6, 98);
            this.enterSalesIDTB.Name = "enterSalesIDTB";
            this.enterSalesIDTB.Size = new System.Drawing.Size(238, 23);
            this.enterSalesIDTB.TabIndex = 2;
            this.enterSalesIDTB.TextChanged += new System.EventHandler(this.enterSalesIDTB_TextChanged);
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
            this.salesIDGV,
            this.proIDGV,
            this.barcodeGV,
            this.productGV,
            this.proPriceGV,
            this.quantityGV,
            this.perProductDiscountGV,
            this.perProductTotalGV,
            this.totalDiscountGV,
            this.productDiscount,
            this.totalAmountGV,
            this.amountGivenGV,
            this.amountReturnedGV,
            this.dateGV,
            this.paymentTypeGV,
            this.userGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 470);
            this.dataGridView1.TabIndex = 6;
            // 
            // salesIDGV
            // 
            this.salesIDGV.HeaderText = "SalesID";
            this.salesIDGV.Name = "salesIDGV";
            this.salesIDGV.ReadOnly = true;
            this.salesIDGV.Visible = false;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // proPriceGV
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.proPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.proPriceGV.HeaderText = "Product Price";
            this.proPriceGV.Name = "proPriceGV";
            this.proPriceGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // perProductDiscountGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.perProductDiscountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.perProductDiscountGV.HeaderText = "Per Product Discount";
            this.perProductDiscountGV.Name = "perProductDiscountGV";
            this.perProductDiscountGV.ReadOnly = true;
            this.perProductDiscountGV.Visible = false;
            // 
            // perProductTotalGV
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.perProductTotalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perProductTotalGV.HeaderText = "Per Product Total";
            this.perProductTotalGV.Name = "perProductTotalGV";
            this.perProductTotalGV.ReadOnly = true;
            // 
            // totalDiscountGV
            // 
            this.totalDiscountGV.HeaderText = "Total Discount";
            this.totalDiscountGV.Name = "totalDiscountGV";
            this.totalDiscountGV.ReadOnly = true;
            this.totalDiscountGV.Visible = false;
            // 
            // productDiscount
            // 
            this.productDiscount.HeaderText = "Product Dicount";
            this.productDiscount.Name = "productDiscount";
            this.productDiscount.ReadOnly = true;
            this.productDiscount.Visible = false;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // amountGivenGV
            // 
            this.amountGivenGV.HeaderText = "Amount Given";
            this.amountGivenGV.Name = "amountGivenGV";
            this.amountGivenGV.ReadOnly = true;
            this.amountGivenGV.Visible = false;
            // 
            // amountReturnedGV
            // 
            this.amountReturnedGV.HeaderText = "Returned Amount";
            this.amountReturnedGV.Name = "amountReturnedGV";
            this.amountReturnedGV.ReadOnly = true;
            this.amountReturnedGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            this.dateGV.Visible = false;
            // 
            // paymentTypeGV
            // 
            this.paymentTypeGV.HeaderText = "Payment";
            this.paymentTypeGV.Name = "paymentTypeGV";
            this.paymentTypeGV.ReadOnly = true;
            this.paymentTypeGV.Visible = false;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            this.userGV.Visible = false;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.IndianRed;
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(6, 127);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(238, 41);
            this.loadBtn.TabIndex = 14;
            this.loadBtn.Text = "&LOAD";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(3, 171);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(31, 15);
            this.dateLbl.TabIndex = 15;
            this.dateLbl.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyy hh:mm:ss tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // UserTB
            // 
            this.UserTB.Enabled = false;
            this.UserTB.Location = new System.Drawing.Point(6, 233);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(238, 23);
            this.UserTB.TabIndex = 18;
            // 
            // UsrLbl
            // 
            this.UsrLbl.AutoSize = true;
            this.UsrLbl.Location = new System.Drawing.Point(3, 215);
            this.UsrLbl.Name = "UsrLbl";
            this.UsrLbl.Size = new System.Drawing.Size(30, 15);
            this.UsrLbl.TabIndex = 17;
            this.UsrLbl.Text = "User";
            // 
            // payTypeTB
            // 
            this.payTypeTB.Enabled = false;
            this.payTypeTB.Location = new System.Drawing.Point(6, 277);
            this.payTypeTB.Name = "payTypeTB";
            this.payTypeTB.Size = new System.Drawing.Size(238, 23);
            this.payTypeTB.TabIndex = 20;
            // 
            // payTypeLbl
            // 
            this.payTypeLbl.AutoSize = true;
            this.payTypeLbl.Location = new System.Drawing.Point(3, 259);
            this.payTypeLbl.Name = "payTypeLbl";
            this.payTypeLbl.Size = new System.Drawing.Size(81, 15);
            this.payTypeLbl.TabIndex = 19;
            this.payTypeLbl.Text = "Payment Type";
            // 
            // AmountToRefundTB
            // 
            this.AmountToRefundTB.Enabled = false;
            this.AmountToRefundTB.Location = new System.Drawing.Point(6, 365);
            this.AmountToRefundTB.Name = "AmountToRefundTB";
            this.AmountToRefundTB.Size = new System.Drawing.Size(238, 23);
            this.AmountToRefundTB.TabIndex = 28;
            // 
            // AmountToRefundLbl
            // 
            this.AmountToRefundLbl.AutoSize = true;
            this.AmountToRefundLbl.Location = new System.Drawing.Point(3, 347);
            this.AmountToRefundLbl.Name = "AmountToRefundLbl";
            this.AmountToRefundLbl.Size = new System.Drawing.Size(107, 15);
            this.AmountToRefundLbl.TabIndex = 27;
            this.AmountToRefundLbl.Text = "Amount To Refund";
            // 
            // enterBarcodeTB
            // 
            this.enterBarcodeTB.Location = new System.Drawing.Point(6, 321);
            this.enterBarcodeTB.Name = "enterBarcodeTB";
            this.enterBarcodeTB.Size = new System.Drawing.Size(238, 23);
            this.enterBarcodeTB.TabIndex = 26;
            this.enterBarcodeTB.Validating += new System.ComponentModel.CancelEventHandler(this.enterBarcodeTB_Validating);
            // 
            // enterBarcodeLbl
            // 
            this.enterBarcodeLbl.AutoSize = true;
            this.enterBarcodeLbl.Location = new System.Drawing.Point(3, 303);
            this.enterBarcodeLbl.Name = "enterBarcodeLbl";
            this.enterBarcodeLbl.Size = new System.Drawing.Size(80, 15);
            this.enterBarcodeLbl.TabIndex = 25;
            this.enterBarcodeLbl.Text = "Enter Barcode";
            // 
            // SalesReturnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 568);
            this.Name = "SalesReturnWindow";
            this.Text = "Sales Return Window";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox enterSalesIDTB;
        private System.Windows.Forms.Label enterSalesIDLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.Label UsrLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TextBox payTypeTB;
        private System.Windows.Forms.Label payTypeLbl;
        private System.Windows.Forms.TextBox AmountToRefundTB;
        private System.Windows.Forms.Label AmountToRefundLbl;
        private System.Windows.Forms.TextBox enterBarcodeTB;
        private System.Windows.Forms.Label enterBarcodeLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProductDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProductTotalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReturnedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
    }
}