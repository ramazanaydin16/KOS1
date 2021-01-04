namespace KSO
{
    partial class frmEmanetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmanetler));
            this.dataGridOkuyucular = new System.Windows.Forms.DataGridView();
            this.dataGridKitaplar = new System.Windows.Forms.DataGridView();
            this.txtOkuyucuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerilisTarihi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSure = new System.Windows.Forms.ComboBox();
            this.txtOkuyucuAra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridEmanetler = new System.Windows.Forms.DataGridView();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.imgAltaAl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOkuyucular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmanetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOkuyucular
            // 
            this.dataGridOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOkuyucular.Location = new System.Drawing.Point(372, 36);
            this.dataGridOkuyucular.MultiSelect = false;
            this.dataGridOkuyucular.Name = "dataGridOkuyucular";
            this.dataGridOkuyucular.ReadOnly = true;
            this.dataGridOkuyucular.RowHeadersVisible = false;
            this.dataGridOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOkuyucular.Size = new System.Drawing.Size(293, 176);
            this.dataGridOkuyucular.TabIndex = 21;
            this.dataGridOkuyucular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOkuyucular_CellClick);
            // 
            // dataGridKitaplar
            // 
            this.dataGridKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitaplar.Location = new System.Drawing.Point(671, 36);
            this.dataGridKitaplar.MultiSelect = false;
            this.dataGridKitaplar.Name = "dataGridKitaplar";
            this.dataGridKitaplar.ReadOnly = true;
            this.dataGridKitaplar.RowHeadersVisible = false;
            this.dataGridKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKitaplar.Size = new System.Drawing.Size(369, 176);
            this.dataGridKitaplar.TabIndex = 22;
            this.dataGridKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitaplar_CellClick);
            // 
            // txtOkuyucuID
            // 
            this.txtOkuyucuID.Enabled = false;
            this.txtOkuyucuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtOkuyucuID.Location = new System.Drawing.Point(145, 36);
            this.txtOkuyucuID.Name = "txtOkuyucuID";
            this.txtOkuyucuID.Size = new System.Drawing.Size(185, 24);
            this.txtOkuyucuID.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Okuyucu ID : ";
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.BackColor = System.Drawing.Color.Transparent;
            this.btnTeslimAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslimAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimAl.Location = new System.Drawing.Point(241, 228);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(89, 40);
            this.btnTeslimAl.TabIndex = 52;
            this.btnTeslimAl.Text = "TESLİM AL";
            this.btnTeslimAl.UseVisualStyleBackColor = false;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtAdSoyad.Location = new System.Drawing.Point(145, 66);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(185, 24);
            this.txtAdSoyad.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ad Soyad : ";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Enabled = false;
            this.txtKitapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtKitapID.Location = new System.Drawing.Point(145, 96);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(185, 24);
            this.txtKitapID.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Kitap ID : ";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Enabled = false;
            this.txtKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtKitapAdi.Location = new System.Drawing.Point(145, 126);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(185, 24);
            this.txtKitapAdi.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Kitap Adı : ";
            // 
            // txtVerilisTarihi
            // 
            this.txtVerilisTarihi.Enabled = false;
            this.txtVerilisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtVerilisTarihi.Location = new System.Drawing.Point(145, 156);
            this.txtVerilisTarihi.Name = "txtVerilisTarihi";
            this.txtVerilisTarihi.Size = new System.Drawing.Size(185, 24);
            this.txtVerilisTarihi.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Verilişi Tarihi : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(75, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Süre : ";
            // 
            // cmbSure
            // 
            this.cmbSure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSure.FormattingEnabled = true;
            this.cmbSure.Items.AddRange(new object[] {
            "1 HAFTA",
            "1 AY"});
            this.cmbSure.Location = new System.Drawing.Point(145, 186);
            this.cmbSure.Name = "cmbSure";
            this.cmbSure.Size = new System.Drawing.Size(185, 26);
            this.cmbSure.TabIndex = 64;
            // 
            // txtOkuyucuAra
            // 
            this.txtOkuyucuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOkuyucuAra.Location = new System.Drawing.Point(496, 228);
            this.txtOkuyucuAra.Name = "txtOkuyucuAra";
            this.txtOkuyucuAra.Size = new System.Drawing.Size(169, 24);
            this.txtOkuyucuAra.TabIndex = 65;
            this.txtOkuyucuAra.TextChanged += new System.EventHandler(this.txtOkuyucuAra_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(374, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 16);
            this.label13.TabIndex = 66;
            this.label13.Text = "OKUYUCU ARA : ";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAra.Location = new System.Drawing.Point(807, 225);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(169, 24);
            this.txtKitapAra.TabIndex = 67;
            this.txtKitapAra.TextChanged += new System.EventHandler(this.txtKitapAra_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(703, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "KİTAP ARA : ";
            // 
            // dataGridEmanetler
            // 
            this.dataGridEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmanetler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmanetler.Location = new System.Drawing.Point(32, 287);
            this.dataGridEmanetler.MultiSelect = false;
            this.dataGridEmanetler.Name = "dataGridEmanetler";
            this.dataGridEmanetler.ReadOnly = true;
            this.dataGridEmanetler.RowHeadersVisible = false;
            this.dataGridEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmanetler.Size = new System.Drawing.Size(1009, 244);
            this.dataGridEmanetler.TabIndex = 69;
            this.dataGridEmanetler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmanetler_CellClick);
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.BackColor = System.Drawing.Color.Transparent;
            this.btnTeslimEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEt.Location = new System.Drawing.Point(145, 228);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(89, 40);
            this.btnTeslimEt.TabIndex = 70;
            this.btnTeslimEt.Text = "TESLİM ET";
            this.btnTeslimEt.UseVisualStyleBackColor = false;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // imgKapat
            // 
            this.imgKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(1056, 4);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(30, 30);
            this.imgKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKapat.TabIndex = 71;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // imgAltaAl
            // 
            this.imgAltaAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("imgAltaAl.Image")));
            this.imgAltaAl.Location = new System.Drawing.Point(1023, 4);
            this.imgAltaAl.Name = "imgAltaAl";
            this.imgAltaAl.Size = new System.Drawing.Size(30, 30);
            this.imgAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAltaAl.TabIndex = 72;
            this.imgAltaAl.TabStop = false;
            this.imgAltaAl.Click += new System.EventHandler(this.imgAltaAl_Click);
            // 
            // frmEmanetler
            // 
            this.AcceptButton = this.btnTeslimEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1090, 560);
            this.Controls.Add(this.imgAltaAl);
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.dataGridEmanetler);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOkuyucuAra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbSure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVerilisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOkuyucuID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.dataGridKitaplar);
            this.Controls.Add(this.dataGridOkuyucular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmanetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP EMANET İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmEmanetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOkuyucular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmanetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOkuyucular;
        private System.Windows.Forms.DataGridView dataGridKitaplar;
        private System.Windows.Forms.TextBox txtOkuyucuID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerilisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSure;
        private System.Windows.Forms.TextBox txtOkuyucuAra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridEmanetler;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.PictureBox imgKapat;
        private System.Windows.Forms.PictureBox imgAltaAl;
    }
}