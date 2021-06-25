namespace UPS_Periyodik_Bakım_Takip
{
    partial class UpsList
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
            this.ups1DataGridView = new System.Windows.Forms.DataGridView();
            this.SıraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BulunduğuYerleşke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BulunduğuYerBölüm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpsMarkaModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Güç = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BakımTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirSonrakiBakimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SorumluKişi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Açıklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ups1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ups1DataGridView
            // 
            this.ups1DataGridView.AllowUserToAddRows = false;
            this.ups1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ups1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ups1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SıraNo,
            this.BulunduğuYerleşke,
            this.BulunduğuYerBölüm,
            this.UpsMarkaModel,
            this.Güç,
            this.SeriNo,
            this.BakımTarihi,
            this.BirSonrakiBakimTarihi,
            this.SorumluKişi,
            this.Açıklama});
            this.ups1DataGridView.Location = new System.Drawing.Point(12, 42);
            this.ups1DataGridView.Name = "ups1DataGridView";
            this.ups1DataGridView.Size = new System.Drawing.Size(1132, 469);
            this.ups1DataGridView.TabIndex = 0;
            this.ups1DataGridView.DoubleClick += new System.EventHandler(this.ups1DataGridView_DoubleClick);
            // 
            // SıraNo
            // 
            this.SıraNo.HeaderText = "Sıra No";
            this.SıraNo.Name = "SıraNo";
            // 
            // BulunduğuYerleşke
            // 
            this.BulunduğuYerleşke.HeaderText = "Bulunduğu Yerleşke";
            this.BulunduğuYerleşke.Name = "BulunduğuYerleşke";
            // 
            // BulunduğuYerBölüm
            // 
            this.BulunduğuYerBölüm.HeaderText = "Bulunduğu Yer Bölüm";
            this.BulunduğuYerBölüm.Name = "BulunduğuYerBölüm";
            // 
            // UpsMarkaModel
            // 
            this.UpsMarkaModel.HeaderText = "Ups Marka Model";
            this.UpsMarkaModel.Name = "UpsMarkaModel";
            // 
            // Güç
            // 
            this.Güç.HeaderText = "Güç";
            this.Güç.Name = "Güç";
            // 
            // SeriNo
            // 
            this.SeriNo.HeaderText = "Seri No";
            this.SeriNo.Name = "SeriNo";
            // 
            // BakımTarihi
            // 
            this.BakımTarihi.HeaderText = "Bakım Tarihi";
            this.BakımTarihi.Name = "BakımTarihi";
            // 
            // BirSonrakiBakimTarihi
            // 
            this.BirSonrakiBakimTarihi.HeaderText = "Bir Sonraki Bakım Tarihi";
            this.BirSonrakiBakimTarihi.Name = "BirSonrakiBakimTarihi";
            // 
            // SorumluKişi
            // 
            this.SorumluKişi.HeaderText = "Sorumlu Kişi";
            this.SorumluKişi.Name = "SorumluKişi";
            // 
            // Açıklama
            // 
            this.Açıklama.HeaderText = "Açıklama";
            this.Açıklama.Name = "Açıklama";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(13, 13);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(75, 23);
            this.buttonGeri.TabIndex = 1;
            this.buttonGeri.Text = "GERİ";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // UpsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 523);
            this.Controls.Add(this.buttonGeri);
            this.Controls.Add(this.ups1DataGridView);
            this.Name = "UpsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpsList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ups1DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ups1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SıraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BulunduğuYerleşke;
        private System.Windows.Forms.DataGridViewTextBoxColumn BulunduğuYerBölüm;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpsMarkaModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Güç;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BakımTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirSonrakiBakimTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SorumluKişi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Açıklama;
        private System.Windows.Forms.Button buttonGeri;
    }
}