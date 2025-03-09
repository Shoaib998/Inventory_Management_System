namespace IMS
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productPricingBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.purchaseInvBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.salesReturnBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 526);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(772, 526);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.salesReturnBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.productPricingBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplierBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.categoryBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseInvBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 481);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // productPricingBtn
            // 
            this.productPricingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPricingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.productPricingBtn.FlatAppearance.BorderSize = 2;
            this.productPricingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productPricingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPricingBtn.Location = new System.Drawing.Point(311, 99);
            this.productPricingBtn.Name = "productPricingBtn";
            this.productPricingBtn.Size = new System.Drawing.Size(148, 90);
            this.productPricingBtn.TabIndex = 7;
            this.productPricingBtn.Text = "Product Pricing";
            this.productPricingBtn.UseVisualStyleBackColor = true;
            this.productPricingBtn.Click += new System.EventHandler(this.productPricingBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.supplierBtn.FlatAppearance.BorderSize = 2;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.Location = new System.Drawing.Point(157, 99);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(148, 90);
            this.supplierBtn.TabIndex = 6;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.UseVisualStyleBackColor = true;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.categoryBtn.FlatAppearance.BorderSize = 2;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.Location = new System.Drawing.Point(3, 99);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(148, 90);
            this.categoryBtn.TabIndex = 5;
            this.categoryBtn.Text = "Categories";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBtn.Location = new System.Drawing.Point(619, 3);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(150, 90);
            this.salesBtn.TabIndex = 4;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // purchaseInvBtn
            // 
            this.purchaseInvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseInvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.purchaseInvBtn.FlatAppearance.BorderSize = 2;
            this.purchaseInvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseInvBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseInvBtn.Location = new System.Drawing.Point(465, 3);
            this.purchaseInvBtn.Name = "purchaseInvBtn";
            this.purchaseInvBtn.Size = new System.Drawing.Size(148, 90);
            this.purchaseInvBtn.TabIndex = 3;
            this.purchaseInvBtn.Text = "Purchase Invoice";
            this.purchaseInvBtn.UseVisualStyleBackColor = true;
            this.purchaseInvBtn.Click += new System.EventHandler(this.purchaseInvBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.stockBtn.FlatAppearance.BorderSize = 2;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.Location = new System.Drawing.Point(311, 3);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(148, 90);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.productBtn.FlatAppearance.BorderSize = 2;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.Location = new System.Drawing.Point(157, 3);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(148, 90);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(148, 90);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // salesReturnBtn
            // 
            this.salesReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesReturnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.salesReturnBtn.FlatAppearance.BorderSize = 2;
            this.salesReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesReturnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReturnBtn.Location = new System.Drawing.Point(465, 99);
            this.salesReturnBtn.Name = "salesReturnBtn";
            this.salesReturnBtn.Size = new System.Drawing.Size(148, 90);
            this.salesReturnBtn.TabIndex = 8;
            this.salesReturnBtn.Text = "Sales Return";
            this.salesReturnBtn.UseVisualStyleBackColor = true;
            this.salesReturnBtn.Click += new System.EventHandler(this.salesReturnBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 526);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button purchaseInvBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button productPricingBtn;
        private System.Windows.Forms.Button salesReturnBtn;
    }
}