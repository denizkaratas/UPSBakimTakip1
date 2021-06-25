namespace UPS_Periyodik_Bakım_Takip
{
    partial class Register
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
            this.buttonKayıt = new System.Windows.Forms.Button();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKayıt
            // 
            this.buttonKayıt.Location = new System.Drawing.Point(102, 288);
            this.buttonKayıt.Name = "buttonKayıt";
            this.buttonKayıt.Size = new System.Drawing.Size(75, 23);
            this.buttonKayıt.TabIndex = 10;
            this.buttonKayıt.Text = "KAYIT OL";
            this.buttonKayıt.UseVisualStyleBackColor = true;
            this.buttonKayıt.Click += new System.EventHandler(this.buttonKayıt_Click);
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(46, 234);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(196, 20);
            this.Sifre.TabIndex = 9;
            this.Sifre.Text = "Şifrenizi Giriniz...";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(46, 182);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(196, 20);
            this.kAdi.TabIndex = 8;
            this.kAdi.Text = "Kullanıcı Adınızı Giriniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "KULLANICI KAYIT";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(13, 13);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 11;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 366);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.buttonKayıt);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKayıt;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGeri;
    }
}