namespace IMS
{
    partial class categories
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
            this.isactiveLbl = new System.Windows.Forms.Label();
            this.catogorynameTB = new System.Windows.Forms.TextBox();
            this.categorynameLbl = new System.Windows.Forms.Label();
            this.isactiveerrorLbl = new System.Windows.Forms.Label();
            this.categorynameerrorLbl = new System.Windows.Forms.Label();
            this.activeDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(118, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.activeDD);
            this.leftPanel.Controls.Add(this.isactiveLbl);
            this.leftPanel.Controls.Add(this.catogorynameTB);
            this.leftPanel.Controls.Add(this.categorynameLbl);
            this.leftPanel.Controls.Add(this.isactiveerrorLbl);
            this.leftPanel.Controls.Add(this.categorynameerrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 518);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.categorynameerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.isactiveerrorLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.categorynameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.catogorynameTB, 0);
            this.leftPanel.Controls.SetChildIndex(this.isactiveLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(750, 518);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // isactiveLbl
            // 
            this.isactiveLbl.AutoSize = true;
            this.isactiveLbl.Location = new System.Drawing.Point(3, 123);
            this.isactiveLbl.Name = "isactiveLbl";
            this.isactiveLbl.Size = new System.Drawing.Size(51, 15);
            this.isactiveLbl.TabIndex = 42;
            this.isactiveLbl.Text = "Is Active";
            // 
            // catogorynameTB
            // 
            this.catogorynameTB.Location = new System.Drawing.Point(6, 97);
            this.catogorynameTB.MaxLength = 35;
            this.catogorynameTB.Name = "catogorynameTB";
            this.catogorynameTB.Size = new System.Drawing.Size(238, 23);
            this.catogorynameTB.TabIndex = 41;
            // 
            // categorynameLbl
            // 
            this.categorynameLbl.AutoSize = true;
            this.categorynameLbl.Location = new System.Drawing.Point(3, 80);
            this.categorynameLbl.Name = "categorynameLbl";
            this.categorynameLbl.Size = new System.Drawing.Size(93, 15);
            this.categorynameLbl.TabIndex = 40;
            this.categorynameLbl.Text = "Category Name ";
            // 
            // isactiveerrorLbl
            // 
            this.isactiveerrorLbl.AutoSize = true;
            this.isactiveerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isactiveerrorLbl.Location = new System.Drawing.Point(51, 123);
            this.isactiveerrorLbl.Name = "isactiveerrorLbl";
            this.isactiveerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.isactiveerrorLbl.TabIndex = 44;
            this.isactiveerrorLbl.Text = "*";
            this.isactiveerrorLbl.Visible = false;
            // 
            // categorynameerrorLbl
            // 
            this.categorynameerrorLbl.AutoSize = true;
            this.categorynameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorynameerrorLbl.Location = new System.Drawing.Point(92, 80);
            this.categorynameerrorLbl.Name = "categorynameerrorLbl";
            this.categorynameerrorLbl.Size = new System.Drawing.Size(17, 21);
            this.categorynameerrorLbl.TabIndex = 45;
            this.categorynameerrorLbl.Text = "*";
            this.categorynameerrorLbl.Visible = false;
            // 
            // activeDD
            // 
            this.activeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeDD.FormattingEnabled = true;
            this.activeDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activeDD.Location = new System.Drawing.Point(6, 141);
            this.activeDD.Name = "activeDD";
            this.activeDD.Size = new System.Drawing.Size(238, 23);
            this.activeDD.TabIndex = 46;
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
            this.catIDGV,
            this.NameGV,
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
            this.dataGridView1.Size = new System.Drawing.Size(750, 420);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "Category ID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 518);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label isactiveLbl;
        private System.Windows.Forms.TextBox catogorynameTB;
        private System.Windows.Forms.Label categorynameLbl;
        private System.Windows.Forms.Label isactiveerrorLbl;
        private System.Windows.Forms.Label categorynameerrorLbl;
        private System.Windows.Forms.ComboBox activeDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}