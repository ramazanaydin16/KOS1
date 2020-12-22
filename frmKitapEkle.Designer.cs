namespace KSO
{
    partial class frmKitapEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this.cmbKitapTuru = new System.Windows.Forms.ComboBox();
            this.cmbDolap = new System.Windows.Forms.ComboBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridKitap = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYazarAra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayın Evi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basım Yılı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(72, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Türü : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Açıklama : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(61, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dolap : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(79, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Raf : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(75, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sıra : ";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Enabled = false;
            this.txtKitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapID.Location = new System.Drawing.Point(152, 20);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(152, 24);
            this.txtKitapID.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(152, 48);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(152, 24);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtRaf
            // 
            this.txtRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRaf.Location = new System.Drawing.Point(152, 266);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(152, 24);
            this.txtRaf.TabIndex = 9;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(152, 172);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(152, 24);
            this.txtSayfaSayisi.TabIndex = 6;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasimYili.Location = new System.Drawing.Point(152, 142);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(152, 24);
            this.txtBasimYili.TabIndex = 5;
            // 
            // cmbYazar
            // 
            this.cmbYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(152, 78);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(152, 26);
            this.cmbYazar.TabIndex = 3;
            // 
            // cmbYayinEvi
            // 
            this.cmbYayinEvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYayinEvi.FormattingEnabled = true;
            this.cmbYayinEvi.Location = new System.Drawing.Point(152, 110);
            this.cmbYayinEvi.Name = "cmbYayinEvi";
            this.cmbYayinEvi.Size = new System.Drawing.Size(152, 26);
            this.cmbYayinEvi.TabIndex = 4;
            // 
            // cmbKitapTuru
            // 
            this.cmbKitapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitapTuru.FormattingEnabled = true;
            this.cmbKitapTuru.Location = new System.Drawing.Point(152, 202);
            this.cmbKitapTuru.Name = "cmbKitapTuru";
            this.cmbKitapTuru.Size = new System.Drawing.Size(152, 26);
            this.cmbKitapTuru.TabIndex = 7;
            // 
            // cmbDolap
            // 
            this.cmbDolap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDolap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDolap.FormattingEnabled = true;
            this.cmbDolap.Location = new System.Drawing.Point(152, 234);
            this.cmbDolap.Name = "cmbDolap";
            this.cmbDolap.Size = new System.Drawing.Size(152, 26);
            this.cmbDolap.TabIndex = 8;
            // 
            // txtSira
            // 
            this.txtSira.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSira.Location = new System.Drawing.Point(152, 296);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(152, 24);
            this.txtSira.TabIndex = 10;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(152, 326);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(152, 24);
            this.txtAciklama.TabIndex = 11;
            // 
            // dataGridKitap
            // 
            this.dataGridKitap.AllowUserToAddRows = false;
            this.dataGridKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitap.Location = new System.Drawing.Point(332, 18);
            this.dataGridKitap.MultiSelect = false;
            this.dataGridKitap.Name = "dataGridKitap";
            this.dataGridKitap.ReadOnly = true;
            this.dataGridKitap.RowHeadersVisible = false;
            this.dataGridKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKitap.Size = new System.Drawing.Size(756, 373);
            this.dataGridKitap.TabIndex = 23;
            this.dataGridKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitap_CellClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(31, 377);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 44);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(124, 377);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 44);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(217, 377);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(87, 44);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.Location = new System.Drawing.Point(459, 400);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(224, 24);
            this.txtKitapAra.TabIndex = 28;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(355, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "KİTAP ARA : ";
            // 
            // txtYazarAra
            // 
            this.txtYazarAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAra.Location = new System.Drawing.Point(832, 400);
            this.txtYazarAra.Name = "txtYazarAra";
            this.txtYazarAra.Size = new System.Drawing.Size(224, 24);
            this.txtYazarAra.TabIndex = 30;
            this.txtYazarAra.TextChanged += new System.EventHandler(this.txtYazarAra_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(728, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "YAZAR ARA : ";
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1100, 444);
            this.Controls.Add(this.txtYazarAra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridKitap);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.cmbDolap);
            this.Controls.Add(this.cmbKitapTuru);
            this.Controls.Add(this.cmbYayinEvi);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.txtBasimYili);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtRaf);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP EKLE";
            this.Load += new System.EventHandler(this.frmKitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBasimYili;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.ComboBox cmbYayinEvi;
        private System.Windows.Forms.ComboBox cmbKitapTuru;
        private System.Windows.Forms.ComboBox cmbDolap;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridKitap;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYazarAra;
        private System.Windows.Forms.Label label13;
    }
}