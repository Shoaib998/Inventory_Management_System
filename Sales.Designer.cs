namespace IMS
{
    partial class Sales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perunitpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossamountLbl = new System.Windows.Forms.Label();
            this.grosstotalLbl = new System.Windows.Forms.Label();
            this.enterBarcodLbl = new System.Windows.Forms.Label();
            this.barcodeTB = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.paymentGB = new System.Windows.Forms.GroupBox();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.changeToGiveTB = new System.Windows.Forms.TextBox();
            this.changeToGiveLbl = new System.Windows.Forms.Label();
            this.amountGivenTB = new System.Windows.Forms.TextBox();
            this.amountGivenLbl = new System.Windows.Forms.Label();
            this.totalDiscountTB = new System.Windows.Forms.TextBox();
            this.grossTotalTB = new System.Windows.Forms.TextBox();
            this.paymnetTypeDD = new System.Windows.Forms.ComboBox();
            this.paymentTypeLbl = new System.Windows.Forms.Label();
            this.totalDiscountLbl = new System.Windows.Forms.Label();
            this.groTotalLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.paymentGB.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(762, 53);
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(120, 23);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.paymentGB);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.Add(this.panel4);
            this.leftPanel.Size = new System.Drawing.Size(247, 551);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel5, 0);
            this.leftPanel.Controls.SetChildIndex(this.paymentGB, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Location = new System.Drawing.Point(247, 0);
            this.rightPanel.Size = new System.Drawing.Size(762, 551);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(247, 45);
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
            this.discountGV,
            this.totalGV,
            this.deleteGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(762, 391);
            this.dataGridView1.TabIndex = 5;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.perunitpriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.perunitpriceGV.HeaderText = "Per Unit Price";
            this.perunitpriceGV.Name = "perunitpriceGV";
            this.perunitpriceGV.ReadOnly = true;
            // 
            // discountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountGV.HeaderText = "Discount";
            this.discountGV.Name = "discountGV";
            this.discountGV.ReadOnly = true;
            // 
            // totalGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalGV.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 62);
            this.tableLayoutPanel2.TabIndex = 57;
            // 
            // grossamountLbl
            // 
            this.grossamountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossamountLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossamountLbl.Location = new System.Drawing.Point(469, 0);
            this.grossamountLbl.Name = "grossamountLbl";
            this.grossamountLbl.Size = new System.Drawing.Size(290, 62);
            this.grossamountLbl.TabIndex = 55;
            this.grossamountLbl.Text = "0.00";
            this.grossamountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grosstotalLbl
            // 
            this.grosstotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grosstotalLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grosstotalLbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosstotalLbl.Location = new System.Drawing.Point(3, 0);
            this.grosstotalLbl.Name = "grosstotalLbl";
            this.grosstotalLbl.Size = new System.Drawing.Size(460, 62);
            this.grosstotalLbl.TabIndex = 54;
            this.grosstotalLbl.Text = "Gross Total";
            this.grosstotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // enterBarcodLbl
            // 
            this.enterBarcodLbl.AutoSize = true;
            this.enterBarcodLbl.Location = new System.Drawing.Point(3, 35);
            this.enterBarcodLbl.Name = "enterBarcodLbl";
            this.enterBarcodLbl.Size = new System.Drawing.Size(80, 15);
            this.enterBarcodLbl.TabIndex = 1;
            this.enterBarcodLbl.Text = "Enter Barcode";
            // 
            // barcodeTB
            // 
            this.barcodeTB.Location = new System.Drawing.Point(6, 3);
            this.barcodeTB.MaxLength = 100;
            this.barcodeTB.Name = "barcodeTB";
            this.barcodeTB.Size = new System.Drawing.Size(235, 23);
            this.barcodeTB.TabIndex = 2;
            this.barcodeTB.TextChanged += new System.EventHandler(this.barcodeTB_TextChanged);
            this.barcodeTB.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTB_Validating);
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.IndianRed;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Location = new System.Drawing.Point(6, 322);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(235, 74);
            this.payBtn.TabIndex = 13;
            this.payBtn.Text = "&PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // paymentGB
            // 
            this.paymentGB.Controls.Add(this.checkOutBtn);
            this.paymentGB.Controls.Add(this.changeToGiveTB);
            this.paymentGB.Controls.Add(this.changeToGiveLbl);
            this.paymentGB.Controls.Add(this.amountGivenTB);
            this.paymentGB.Controls.Add(this.amountGivenLbl);
            this.paymentGB.Controls.Add(this.totalDiscountTB);
            this.paymentGB.Controls.Add(this.grossTotalTB);
            this.paymentGB.Controls.Add(this.paymnetTypeDD);
            this.paymentGB.Controls.Add(this.paymentTypeLbl);
            this.paymentGB.Controls.Add(this.totalDiscountLbl);
            this.paymentGB.Controls.Add(this.groTotalLbl);
            this.paymentGB.Controls.Add(this.payBtn);
            this.paymentGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGB.ForeColor = System.Drawing.Color.White;
            this.paymentGB.Location = new System.Drawing.Point(0, 127);
            this.paymentGB.Name = "paymentGB";
            this.paymentGB.Size = new System.Drawing.Size(247, 424);
            this.paymentGB.TabIndex = 4;
            this.paymentGB.TabStop = false;
            this.paymentGB.Text = "Payments";
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.checkOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutBtn.FlatAppearance.BorderSize = 2;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Location = new System.Drawing.Point(6, 242);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(235, 74);
            this.checkOutBtn.TabIndex = 14;
            this.checkOutBtn.Text = "&CHECKOUT";
            this.checkOutBtn.UseVisualStyleBackColor = false;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // changeToGiveTB
            // 
            this.changeToGiveTB.Enabled = false;
            this.changeToGiveTB.Location = new System.Drawing.Point(6, 213);
            this.changeToGiveTB.MaxLength = 100;
            this.changeToGiveTB.Name = "changeToGiveTB";
            this.changeToGiveTB.Size = new System.Drawing.Size(235, 23);
            this.changeToGiveTB.TabIndex = 12;
            // 
            // changeToGiveLbl
            // 
            this.changeToGiveLbl.AutoSize = true;
            this.changeToGiveLbl.Location = new System.Drawing.Point(3, 195);
            this.changeToGiveLbl.Name = "changeToGiveLbl";
            this.changeToGiveLbl.Size = new System.Drawing.Size(89, 15);
            this.changeToGiveLbl.TabIndex = 11;
            this.changeToGiveLbl.Text = "Change To Give";
            // 
            // amountGivenTB
            // 
            this.amountGivenTB.Location = new System.Drawing.Point(6, 169);
            this.amountGivenTB.MaxLength = 100;
            this.amountGivenTB.Name = "amountGivenTB";
            this.amountGivenTB.Size = new System.Drawing.Size(235, 23);
            this.amountGivenTB.TabIndex = 10;
            this.amountGivenTB.TextChanged += new System.EventHandler(this.amountGivenTB_TextChanged);
            this.amountGivenTB.Validating += new System.ComponentModel.CancelEventHandler(this.amountGivenTB_Validating);
            // 
            // amountGivenLbl
            // 
            this.amountGivenLbl.AutoSize = true;
            this.amountGivenLbl.Location = new System.Drawing.Point(3, 151);
            this.amountGivenLbl.Name = "amountGivenLbl";
            this.amountGivenLbl.Size = new System.Drawing.Size(84, 15);
            this.amountGivenLbl.TabIndex = 9;
            this.amountGivenLbl.Text = "Amount Given";
            // 
            // totalDiscountTB
            // 
            this.totalDiscountTB.Enabled = false;
            this.totalDiscountTB.Location = new System.Drawing.Point(6, 81);
            this.totalDiscountTB.MaxLength = 100;
            this.totalDiscountTB.Name = "totalDiscountTB";
            this.totalDiscountTB.Size = new System.Drawing.Size(235, 23);
            this.totalDiscountTB.TabIndex = 8;
            // 
            // grossTotalTB
            // 
            this.grossTotalTB.Enabled = false;
            this.grossTotalTB.Location = new System.Drawing.Point(6, 37);
            this.grossTotalTB.MaxLength = 100;
            this.grossTotalTB.Name = "grossTotalTB";
            this.grossTotalTB.Size = new System.Drawing.Size(235, 23);
            this.grossTotalTB.TabIndex = 3;
            // 
            // paymnetTypeDD
            // 
            this.paymnetTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymnetTypeDD.FormattingEnabled = true;
            this.paymnetTypeDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.paymnetTypeDD.Location = new System.Drawing.Point(6, 125);
            this.paymnetTypeDD.Name = "paymnetTypeDD";
            this.paymnetTypeDD.Size = new System.Drawing.Size(235, 23);
            this.paymnetTypeDD.TabIndex = 7;
            // 
            // paymentTypeLbl
            // 
            this.paymentTypeLbl.AutoSize = true;
            this.paymentTypeLbl.Location = new System.Drawing.Point(3, 107);
            this.paymentTypeLbl.Name = "paymentTypeLbl";
            this.paymentTypeLbl.Size = new System.Drawing.Size(81, 15);
            this.paymentTypeLbl.TabIndex = 6;
            this.paymentTypeLbl.Text = "Payment Type";
            // 
            // totalDiscountLbl
            // 
            this.totalDiscountLbl.AutoSize = true;
            this.totalDiscountLbl.Location = new System.Drawing.Point(3, 63);
            this.totalDiscountLbl.Name = "totalDiscountLbl";
            this.totalDiscountLbl.Size = new System.Drawing.Size(82, 15);
            this.totalDiscountLbl.TabIndex = 5;
            this.totalDiscountLbl.Text = "Total Discount";
            // 
            // groTotalLbl
            // 
            this.groTotalLbl.AutoSize = true;
            this.groTotalLbl.Location = new System.Drawing.Point(3, 19);
            this.groTotalLbl.Name = "groTotalLbl";
            this.groTotalLbl.Size = new System.Drawing.Size(64, 15);
            this.groTotalLbl.TabIndex = 4;
            this.groTotalLbl.Text = "Gross Total";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.enterBarcodLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 53);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.barcodeTB);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 29);
            this.panel5.TabIndex = 6;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 551);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.paymentGB.ResumeLayout(false);
            this.paymentGB.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox barcodeTB;
        private System.Windows.Forms.Label enterBarcodLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label grossamountLbl;
        private System.Windows.Forms.Label grosstotalLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perunitpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.GroupBox paymentGB;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label paymentTypeLbl;
        private System.Windows.Forms.Label totalDiscountLbl;
        private System.Windows.Forms.Label groTotalLbl;
        private System.Windows.Forms.ComboBox paymnetTypeDD;
        private System.Windows.Forms.TextBox amountGivenTB;
        private System.Windows.Forms.Label amountGivenLbl;
        private System.Windows.Forms.TextBox totalDiscountTB;
        private System.Windows.Forms.TextBox grossTotalTB;
        private System.Windows.Forms.TextBox changeToGiveTB;
        private System.Windows.Forms.Label changeToGiveLbl;
        private System.Windows.Forms.Button checkOutBtn;
    }
}