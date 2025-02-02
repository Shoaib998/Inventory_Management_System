namespace IMS
{
    partial class Stocks
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
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Size = new System.Drawing.Size(109, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 459);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(696, 459);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 459);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}