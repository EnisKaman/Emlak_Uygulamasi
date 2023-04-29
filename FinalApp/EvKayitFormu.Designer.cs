namespace FinalApp
{
    partial class EvKayitFormu
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlanNo = new System.Windows.Forms.TextBox();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.txtKatNo = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtSemt = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(69, 37);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(61, 15);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoşgeldin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlan No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kat No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Semt";
            // 
            // txtIlanNo
            // 
            this.txtIlanNo.Location = new System.Drawing.Point(188, 78);
            this.txtIlanNo.Name = "txtIlanNo";
            this.txtIlanNo.Size = new System.Drawing.Size(100, 23);
            this.txtIlanNo.TabIndex = 6;
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(188, 107);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(100, 23);
            this.txtOdaSayisi.TabIndex = 7;
            // 
            // txtKatNo
            // 
            this.txtKatNo.Location = new System.Drawing.Point(188, 140);
            this.txtKatNo.Name = "txtKatNo";
            this.txtKatNo.Size = new System.Drawing.Size(100, 23);
            this.txtKatNo.TabIndex = 8;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(188, 169);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(100, 23);
            this.txtAlan.TabIndex = 9;
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(188, 198);
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Size = new System.Drawing.Size(100, 23);
            this.txtSemt.TabIndex = 10;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(343, 115);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 11;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(343, 77);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // EvKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 323);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtSemt);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtKatNo);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.txtIlanNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHosgeldin);
            this.Name = "EvKayitFormu";
            this.Text = "EvKayitFormu";
            this.Load += new System.EventHandler(this.EvKayitFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TextBox txtIlanNo;
        public System.Windows.Forms.TextBox txtOdaSayisi;
        public System.Windows.Forms.TextBox txtKatNo;
        public System.Windows.Forms.TextBox txtAlan;
        public System.Windows.Forms.TextBox txtSemt;
        public System.Windows.Forms.Label lblHosgeldin;
    }
}