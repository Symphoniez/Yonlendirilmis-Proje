namespace YönlendirilmisProje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kullaniciRadio = new System.Windows.Forms.RadioButton();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.sifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciSifre = new System.Windows.Forms.TextBox();
            this.kullaniciAd = new System.Windows.Forms.TextBox();
            this.kayıtOl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kullaniciRadio);
            this.groupBox1.Controls.Add(this.adminRadio);
            this.groupBox1.Controls.Add(this.sifreTekrar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kullaniciSifre);
            this.groupBox1.Controls.Add(this.kullaniciAd);
            this.groupBox1.Controls.Add(this.kayıtOl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(239, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // kullaniciRadio
            // 
            this.kullaniciRadio.AutoSize = true;
            this.kullaniciRadio.Checked = true;
            this.kullaniciRadio.Location = new System.Drawing.Point(220, 173);
            this.kullaniciRadio.Name = "kullaniciRadio";
            this.kullaniciRadio.Size = new System.Drawing.Size(81, 21);
            this.kullaniciRadio.TabIndex = 9;
            this.kullaniciRadio.TabStop = true;
            this.kullaniciRadio.Text = "Kullanıcı";
            this.kullaniciRadio.UseVisualStyleBackColor = true;
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(31, 173);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(68, 21);
            this.adminRadio.TabIndex = 8;
            this.adminRadio.Text = "Admin";
            this.adminRadio.UseVisualStyleBackColor = true;
            this.adminRadio.CheckedChanged += new System.EventHandler(this.adminRadio_CheckedChanged);
            // 
            // sifreTekrar
            // 
            this.sifreTekrar.Location = new System.Drawing.Point(122, 133);
            this.sifreTekrar.Name = "sifreTekrar";
            this.sifreTekrar.Size = new System.Drawing.Size(127, 22);
            this.sifreTekrar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar";
            // 
            // kullaniciSifre
            // 
            this.kullaniciSifre.Location = new System.Drawing.Point(122, 89);
            this.kullaniciSifre.Name = "kullaniciSifre";
            this.kullaniciSifre.Size = new System.Drawing.Size(127, 22);
            this.kullaniciSifre.TabIndex = 5;
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.Location = new System.Drawing.Point(122, 46);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(127, 22);
            this.kullaniciAd.TabIndex = 4;
            // 
            // kayıtOl
            // 
            this.kayıtOl.Location = new System.Drawing.Point(131, 233);
            this.kayıtOl.Name = "kayıtOl";
            this.kayıtOl.Size = new System.Drawing.Size(75, 23);
            this.kayıtOl.TabIndex = 2;
            this.kayıtOl.Text = "Kayıt";
            this.kayıtOl.UseVisualStyleBackColor = true;
            this.kayıtOl.Click += new System.EventHandler(this.KayıtOl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kullaniciSifre;
        private System.Windows.Forms.TextBox kullaniciAd;
        private System.Windows.Forms.Button kayıtOl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton kullaniciRadio;
        private System.Windows.Forms.RadioButton adminRadio;
    }
}