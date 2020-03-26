namespace YönlendirilmisProje
{
    partial class malz_ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.TextBox();
            this.malz_adi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.malz_adet = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_ekle = new System.Windows.Forms.Button();
            this.ekle_vazgec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(38, 59);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(140, 22);
            this.kategori.TabIndex = 1;
            // 
            // malz_adi
            // 
            this.malz_adi.AutoSize = true;
            this.malz_adi.Location = new System.Drawing.Point(35, 105);
            this.malz_adi.Name = "malz_adi";
            this.malz_adi.Size = new System.Drawing.Size(28, 17);
            this.malz_adi.TabIndex = 2;
            this.malz_adi.Text = "Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 3;
            // 
            // malz_adet
            // 
            this.malz_adet.AutoSize = true;
            this.malz_adet.Location = new System.Drawing.Point(35, 190);
            this.malz_adet.Name = "malz_adet";
            this.malz_adet.Size = new System.Drawing.Size(37, 17);
            this.malz_adet.TabIndex = 4;
            this.malz_adet.Text = "Adet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 22);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.malz_adet);
            this.groupBox1.Controls.Add(this.kategori);
            this.groupBox1.Controls.Add(this.malz_adi);
            this.groupBox1.Location = new System.Drawing.Point(149, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 267);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // e_ekle
            // 
            this.e_ekle.Location = new System.Drawing.Point(284, 321);
            this.e_ekle.Name = "e_ekle";
            this.e_ekle.Size = new System.Drawing.Size(75, 23);
            this.e_ekle.TabIndex = 7;
            this.e_ekle.Text = "Ekle";
            this.e_ekle.UseVisualStyleBackColor = true;
            this.e_ekle.Click += new System.EventHandler(this.e_ekle_Click);
            // 
            // ekle_vazgec
            // 
            this.ekle_vazgec.Location = new System.Drawing.Point(149, 321);
            this.ekle_vazgec.Name = "ekle_vazgec";
            this.ekle_vazgec.Size = new System.Drawing.Size(75, 23);
            this.ekle_vazgec.TabIndex = 8;
            this.ekle_vazgec.Text = "Vazgeç";
            this.ekle_vazgec.UseVisualStyleBackColor = true;
            this.ekle_vazgec.Click += new System.EventHandler(this.ekle_vazgec_Click);
            // 
            // malz_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.ekle_vazgec);
            this.Controls.Add(this.e_ekle);
            this.Controls.Add(this.groupBox1);
            this.Name = "malz_ekle";
            this.Text = "malz_ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.Label malz_adi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label malz_adet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button e_ekle;
        private System.Windows.Forms.Button ekle_vazgec;
    }
}