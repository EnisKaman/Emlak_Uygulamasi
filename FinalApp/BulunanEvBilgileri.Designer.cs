namespace FinalApp
{
    partial class BulunanEvBilgileri
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
            this.EvBilgileri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EvBilgileri
            // 
            this.EvBilgileri.AutoSize = true;
            this.EvBilgileri.Location = new System.Drawing.Point(356, 190);
            this.EvBilgileri.Name = "EvBilgileri";
            this.EvBilgileri.Size = new System.Drawing.Size(38, 15);
            this.EvBilgileri.TabIndex = 0;
            this.EvBilgileri.Text = "label1";
            // 
            // BulunanEvBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EvBilgileri);
            this.Name = "BulunanEvBilgileri";
            this.Text = "BulunanEvBilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label EvBilgileri;
    }
}