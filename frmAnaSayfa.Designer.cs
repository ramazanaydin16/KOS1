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
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.benOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYetkiliEkle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridEmanetKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridOkuyucular = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmanetKitaplar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOkuyucular)).BeginInit();
            this.SuspendLayout();
            // 
            // lblK_ad
            // 
            this.lblK_ad.AutoSize = true;
            this.lblK_ad.Location = new System.Drawing.Point(690, 41);
            this.lblK_ad.Name = "lblK_ad";
            this.lblK_ad.Size = new System.Drawing.Size(19, 13);
            this.lblK_ad.TabIndex = 0;
            this.lblK_ad.Text = "ad";
            this.lblK_ad.Visible = false;
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.BackgroundImage")));
            this.btnEmanetIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmanetIslem.Location = new System.Drawing.Point(11, 9);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Size = new System.Drawing.Size(120, 96);
            this.btnEmanetIslem.TabIndex = 1;
            this.btnEmanetIslem.Text = "Emanet İşlemleri";
            this.btnEmanetIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.BackgroundImage")));
            this.btnKitapEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKitapEkle.Location = new System.Drawing.Point(137, 9);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(120, 96);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // benOkuyucuEkle
            // 
            this.benOkuyucuEkle.BackColor = System.Drawing.Color.Transparent;
            this.benOkuyucuEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("benOkuyucuEkle.BackgroundImage")));
            this.benOkuyucuEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.benOkuyucuEkle.Location = new System.Drawing.Point(263, 9);
            this.benOkuyucuEkle.Name = "benOkuyucuEkle";
            this.benOkuyucuEkle.Size = new System.Drawing.Size(120, 96);
            this.benOkuyucuEkle.TabIndex = 3;
            this.benOkuyucuEkle.Text = "Okuyucu Ekle";
            this.benOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.benOkuyucuEkle.UseVisualStyleBackColor = false;
            this.benOkuyucuEkle.Click += new System.EventHandler(this.benOkuyucuEkle_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.BackgroundImage")));
            this.btnIstatistik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIstatistik.Location = new System.Drawing.Point(389, 9);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(120, 96);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIstatistik.UseVisualStyleBackColor = true;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.BackgroundImage")));
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyarlar.Location = new System.Drawing.Point(515, 9);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(120, 96);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCikis.Location = new System.Drawing.Point(767, 9);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 96);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnYetkiliEkle
            // 
            this.btnYetkiliEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYetkiliEkle.BackgroundImage")));
            this.btnYetkiliEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYetkiliEkle.Location = new System.Drawing.Point(641, 9);
            this.btnYetkiliEkle.Name = "btnYetkiliEkle";
            this.btnYetkiliEkle.Size = new System.Drawing.Size(120, 96);
            this.btnYetkiliEkle.TabIndex = 7;
            this.btnYetkiliEkle.Text = "YETKİLİ EKLE";
            this.btnYetkiliEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYetkiliEkle.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 390);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridEmanetKitaplar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emanet Edilen Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridEmanetKitaplar
            // 
            this.dataGridEmanetKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmanetKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEmanetKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dataGridEmanetKitaplar.Name = "dataGridEmanetKitaplar";
            this.dataGridEmanetKitaplar.Size = new System.Drawing.Size(862, 358);
            this.dataGridEmanetKitaplar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridMevcutKitaplar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridMevcutKitaplar
            // 
            this.dataGridMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMevcutKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dataGridMevcutKitaplar.Name = "dataGridMevcutKitaplar";
            this.dataGridMevcutKitaplar.Size = new System.Drawing.Size(862, 358);
            this.dataGridMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridOkuyucular);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(868, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridOkuyucular
            // 
            this.dataGridOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOkuyucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOkuyucular.Location = new System.Drawing.Point(3, 3);
            this.dataGridOkuyucular.Name = "dataGridOkuyucular";
            this.dataGridOkuyucular.Size = new System.Drawing.Size(862, 358);
            this.dataGridOkuyucular.TabIndex = 0;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnYetkiliEkle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.benOkuyucuEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetIslem);
            this.Controls.Add(this.lblK_ad);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmanetKitaplar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOkuyucular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblK_ad;
        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button benOkuyucuEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYetkiliEkle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridEmanetKitaplar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridMevcutKitaplar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridOkuyucular;
    }
}