namespace IMS
{
    partial class Sample
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 548);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.welcomeLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 45);
            this.panel3.TabIndex = 0;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.welcomeLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(75, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(175, 45);
            this.welcomeLbl.TabIndex = 1;
            this.welcomeLbl.Text = "Welcome";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(250, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(763, 548);
            this.rightPanel.TabIndex = 1;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 45);
            this.panel1.TabIndex = 0;
            // 
            // userLbl
            // 
            this.userLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.userLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(0, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(629, 45);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "User";
            this.userLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 548);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sample";
            this.leftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel leftPanel;
        protected System.Windows.Forms.Panel rightPanel;
        protected System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label userLbl;
    }
}