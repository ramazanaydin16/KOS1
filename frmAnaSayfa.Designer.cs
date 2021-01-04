namespace KSO
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.lblK_ad = new System.Windows.Forms.Label();
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.btnKitapIslemleri = new System.Windows.Forms.Button();
            this.benOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnKullaniciAyarlari = new System.Windows.Forms.Button();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.imgAltaAl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblK_ad
            // 
            this.lblK_ad.AutoSize = true;
            this.lblK_ad.BackColor = System.Drawing.Color.Transparent;
            this.lblK_ad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblK_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_ad.Location = new System.Drawing.Point(491, 86);
            this.lblK_ad.Name = "lblK_ad";
            this.lblK_ad.Size = new System.Drawing.Size(24, 18);
            this.lblK_ad.TabIndex = 0;
            this.lblK_ad.Text = "ad";
            this.lblK_ad.Visible = false;
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.BackColor = System.Drawing.Color.Transparent;
            this.btnEmanetIslem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.BackgroundImage")));
            this.btnEmanetIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmanetIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIslem.Location = new System.Drawing.Point(25, 41);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Size = new System.Drawing.Size(183, 149);
            this.btnEmanetIslem.TabIndex = 1;
            this.btnEmanetIslem.Text = "Emanet İşlemleri";
            this.btnEmanetIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslem.UseVisualStyleBackColor = false;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click);
            // 
            // btnKitapIslemleri
            // 
            this.btnKitapIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKitapIslemleri.BackgroundImage")));
            this.btnKitapIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKitapIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapIslemleri.Location = new System.Drawing.Point(214, 41);
            this.btnKitapIslemleri.Name = "btnKitapIslemleri";
            this.btnKitapIslemleri.Size = new System.Drawing.Size(183, 149);
            this.btnKitapIslemleri.TabIndex = 2;
            this.btnKitapIslemleri.Text = "Kitap İşlemleri";
            this.btnKitapIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapIslemleri.UseVisualStyleBackColor = false;
            this.btnKitapIslemleri.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // benOkuyucuEkle
            // 
            this.benOkuyucuEkle.BackColor = System.Drawing.Color.Transparent;
            this.benOkuyucuEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("benOkuyucuEkle.BackgroundImage")));
            this.benOkuyucuEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.benOkuyucuEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.benOkuyucuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.benOkuyucuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.benOkuyucuEkle.Location = new System.Drawing.Point(214, 196);
            this.benOkuyucuEkle.Name = "benOkuyucuEkle";
            this.benOkuyucuEkle.Size = new System.Drawing.Size(183, 149);
            this.benOkuyucuEkle.TabIndex = 3;
            this.benOkuyucuEkle.Text = "Okuyucu İşlemleri";
            this.benOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.benOkuyucuEkle.UseVisualStyleBackColor = false;
            this.benOkuyucuEkle.Click += new System.EventHandler(this.benOkuyucuEkle_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.btnIstatistik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.BackgroundImage")));
            this.btnIstatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIstatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistik.Location = new System.Drawing.Point(25, 197);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(183, 149);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistikler";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIstatistik.UseVisualStyleBackColor = false;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.BackgroundImage")));
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.Location = new System.Drawing.Point(403, 41);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(183, 149);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "Tablo Ayarları";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnKullaniciAyarlari
            // 
            this.btnKullaniciAyarlari.BackColor = System.Drawing.Color.Transparent;
            this.btnKullaniciAyarlari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciAyarlari.BackgroundImage")));
            this.btnKullaniciAyarlari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKullaniciAyarlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAyarlari.Location = new System.Drawing.Point(403, 196);
            this.btnKullaniciAyarlari.Name = "btnKullaniciAyarlari";
            this.btnKullaniciAyarlari.Size = new System.Drawing.Size(183, 149);
            this.btnKullaniciAyarlari.TabIndex = 8;
            this.btnKullaniciAyarlari.Text = "Kullanıcı İşlemleri";
            this.btnKullaniciAyarlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullaniciAyarlari.UseVisualStyleBackColor = false;
            this.btnKullaniciAyarlari.Click += new System.EventHandler(this.btnKullaniciAyarlari_Click);
            // 
            // imgKapat
            // 
            this.imgKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(583, 5);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(30, 30);
            this.imgKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKapat.TabIndex = 9;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // imgAltaAl
            // 
            this.imgAltaAl.BackColor = System.Drawing.Color.Transparent;
            this.imgAltaAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("imgAltaAl.Image")));
            this.imgAltaAl.Location = new System.Drawing.Point(550, 5);
            this.imgAltaAl.Name = "imgAltaAl";
            this.imgAltaAl.Size = new System.Drawing.Size(30, 30);
            this.imgAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAltaAl.TabIndex = 73;
            this.imgAltaAl.TabStop = false;
            this.imgAltaAl.Click += new System.EventHandler(this.imgAltaAl_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(628, 372);
            this.Controls.Add(this.imgAltaAl);
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.btnKullaniciAyarlari);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.benOkuyucuEkle);
            this.Controls.Add(this.btnKitapIslemleri);
            this.Controls.Add(this.btnEmanetIslem);
            this.Controls.Add(this.lblK_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblK_ad;
        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Button btnKitapIslemleri;
        private System.Windows.Forms.Button benOkuyucuEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnKullaniciAyarlari;
        private System.Windows.Forms.PictureBox imgKapat;
        private System.Windows.Forms.PictureBox imgAltaAl;
    }
}