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
            this.isactiveLbl = new System.Windows.Forms.Label();
            this.catogorynameTB = new System.Windows.Forms.TextBox();
            this.categorynameLbl = new System.Windows.Forms.Label();
            this.isactiveerrorLbl = new System.Windows.Forms.Label();
            this.categorynameerrorLbl = new System.Windows.Forms.Label();
            this.activeDD = new System.Windows.Forms.ComboBox();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(83, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.activeDD);
            this.leftPanel.Controls.Add(this.isactiveLbl);
            this.leftPanel.Controls.Add(this.catogorynameTB);
            this.leftPanel.Controls.Add(this.categorynameLbl);
            this.leftPanel.Controls.Add(this.isactiveerrorLbl);
            this.leftPanel.Controls.Add(this.categorynameerrorLbl);
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
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
            this.rightPanel.Size = new System.Drawing.Size(550, 450);
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
            this.activeDD.FormattingEnabled = true;
            this.activeDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.activeDD.Location = new System.Drawing.Point(6, 141);
            this.activeDD.Name = "activeDD";
            this.activeDD.Size = new System.Drawing.Size(238, 23);
            this.activeDD.TabIndex = 46;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label isactiveLbl;
        private System.Windows.Forms.TextBox catogorynameTB;
        private System.Windows.Forms.Label categorynameLbl;
        private System.Windows.Forms.Label isactiveerrorLbl;
        private System.Windows.Forms.Label categorynameerrorLbl;
        private System.Windows.Forms.ComboBox activeDD;
    }
}