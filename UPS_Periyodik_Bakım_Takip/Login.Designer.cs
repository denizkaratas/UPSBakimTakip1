namespace UPS_Periyodik_Bakım_Takip
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.buttonKayıtOl = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞİ";
            // 
            // kAdi
            // 
            this.kAdi.Location = new System.Drawing.Point(34, 115);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(196, 20);
            this.kAdi.TabIndex = 3;
            this.kAdi.Text = "Kullanıcı Adınızı Giriniz...";
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(34, 167);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(196, 20);
            this.Sifre.TabIndex = 4;
            this.Sifre.Text = "Şifrenizi Giriniz...";
            // 
            // buttonKayıtOl
            // 
            this.buttonKayıtOl.Location = new System.Drawing.Point(34, 217);
            this.buttonKayıtOl.Name = "buttonKayıtOl";
            this.buttonKayıtOl.Size = new System.Drawing.Size(75, 23);
            this.buttonKayıtOl.TabIndex = 5;
            this.buttonKayıtOl.Text = "KAYIT OL";
            this.buttonKayıtOl.UseVisualStyleBackColor = true;
            this.buttonKayıtOl.Click += new System.EventHandler(this.buttonKayıtOl_Click);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(155, 217);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(75, 23);
            this.buttonGirisYap.TabIndex = 6;
            this.buttonGirisYap.Text = "GİRİŞ YAP";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 278);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.buttonKayıtOl);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Button buttonKayıtOl;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Timer timer1;
    }
}