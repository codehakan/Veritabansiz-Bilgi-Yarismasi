namespace Veritabansız_Bilgi_Yarışması
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.basla = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cevap1 = new System.Windows.Forms.Button();
            this.cevap2 = new System.Windows.Forms.Button();
            this.cevap3 = new System.Windows.Forms.Button();
            this.cevap4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dogru_sayisi = new System.Windows.Forms.Label();
            this.yanlis_sayisi = new System.Windows.Forms.Label();
            this.zaman = new System.Windows.Forms.Label();
            this.bilgilendirme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basla
            // 
            this.basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla.Location = new System.Drawing.Point(12, 12);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(107, 51);
            this.basla.TabIndex = 0;
            this.basla.Text = "BAŞLA";
            this.basla.UseVisualStyleBackColor = true;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(125, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 108);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Yarışmamıza Hoş Geldiniz..!!";
            // 
            // cevap1
            // 
            this.cevap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap1.Location = new System.Drawing.Point(125, 139);
            this.cevap1.Name = "cevap1";
            this.cevap1.Size = new System.Drawing.Size(107, 51);
            this.cevap1.TabIndex = 2;
            this.cevap1.Text = "Cevap 1";
            this.cevap1.UseVisualStyleBackColor = true;
            this.cevap1.Click += new System.EventHandler(this.cevap1_Click);
            // 
            // cevap2
            // 
            this.cevap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap2.Location = new System.Drawing.Point(354, 139);
            this.cevap2.Name = "cevap2";
            this.cevap2.Size = new System.Drawing.Size(107, 51);
            this.cevap2.TabIndex = 3;
            this.cevap2.Text = "Cevap 2";
            this.cevap2.UseVisualStyleBackColor = true;
            this.cevap2.Click += new System.EventHandler(this.cevap2_Click);
            // 
            // cevap3
            // 
            this.cevap3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap3.Location = new System.Drawing.Point(125, 200);
            this.cevap3.Name = "cevap3";
            this.cevap3.Size = new System.Drawing.Size(107, 51);
            this.cevap3.TabIndex = 4;
            this.cevap3.Text = "Cevap 3";
            this.cevap3.UseVisualStyleBackColor = true;
            this.cevap3.Click += new System.EventHandler(this.cevap3_Click);
            // 
            // cevap4
            // 
            this.cevap4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevap4.Location = new System.Drawing.Point(354, 200);
            this.cevap4.Name = "cevap4";
            this.cevap4.Size = new System.Drawing.Size(107, 51);
            this.cevap4.TabIndex = 5;
            this.cevap4.Text = "Cevap 4";
            this.cevap4.UseVisualStyleBackColor = true;
            this.cevap4.Click += new System.EventHandler(this.cevap4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zaman);
            this.groupBox1.Controls.Add(this.yanlis_sayisi);
            this.groupBox1.Controls.Add(this.dogru_sayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(467, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 239);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistik Göstergesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğru Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yanlış Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Süre:";
            // 
            // dogru_sayisi
            // 
            this.dogru_sayisi.AutoSize = true;
            this.dogru_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogru_sayisi.Location = new System.Drawing.Point(127, 31);
            this.dogru_sayisi.Name = "dogru_sayisi";
            this.dogru_sayisi.Size = new System.Drawing.Size(19, 20);
            this.dogru_sayisi.TabIndex = 3;
            this.dogru_sayisi.Text = "0";
            // 
            // yanlis_sayisi
            // 
            this.yanlis_sayisi.AutoSize = true;
            this.yanlis_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlis_sayisi.Location = new System.Drawing.Point(127, 57);
            this.yanlis_sayisi.Name = "yanlis_sayisi";
            this.yanlis_sayisi.Size = new System.Drawing.Size(19, 20);
            this.yanlis_sayisi.TabIndex = 4;
            this.yanlis_sayisi.Text = "0";
            // 
            // zaman
            // 
            this.zaman.AutoSize = true;
            this.zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaman.Location = new System.Drawing.Point(127, 88);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(19, 20);
            this.zaman.TabIndex = 5;
            this.zaman.Text = "0";
            // 
            // bilgilendirme
            // 
            this.bilgilendirme.AutoSize = true;
            this.bilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgilendirme.Location = new System.Drawing.Point(237, 154);
            this.bilgilendirme.Name = "bilgilendirme";
            this.bilgilendirme.Size = new System.Drawing.Size(111, 20);
            this.bilgilendirme.TabIndex = 6;
            this.bilgilendirme.Text = "Bilgilendirme";
            this.bilgilendirme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bilgilendirme.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(669, 263);
            this.Controls.Add(this.bilgilendirme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cevap4);
            this.Controls.Add(this.cevap3);
            this.Controls.Add(this.cevap2);
            this.Controls.Add(this.cevap1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.basla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bilgi Yarışması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cevap1;
        private System.Windows.Forms.Button cevap2;
        private System.Windows.Forms.Button cevap3;
        private System.Windows.Forms.Button cevap4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label zaman;
        private System.Windows.Forms.Label yanlis_sayisi;
        private System.Windows.Forms.Label dogru_sayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bilgilendirme;
        private System.Windows.Forms.Timer timer1;
    }
}

