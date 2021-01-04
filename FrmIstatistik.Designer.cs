namespace KSO
{
    partial class FrmIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIstatistik));
            this.cmbTablo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.imgAltaAl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTablo
            // 
            this.cmbTablo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTablo.FormattingEnabled = true;
            this.cmbTablo.Items.AddRange(new object[] {
            "EN ÇOK KİTAP OKUYANLAR",
            "EN ÇOK OKUNAN KİTAPLAR"});
            this.cmbTablo.Location = new System.Drawing.Point(128, 15);
            this.cmbTablo.Name = "cmbTablo";
            this.cmbTablo.Size = new System.Drawing.Size(328, 26);
            this.cmbTablo.TabIndex = 66;
            this.cmbTablo.SelectedIndexChanged += new System.EventHandler(this.cmbTablo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "TABLO SEÇ : ";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(16, 56);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.LabelBorderWidth = 2;
            series3.Legend = "Legend1";
            series3.Name = "En Çok Kitap Okuyanlar";
            series3.YValuesPerPoint = 3;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(776, 382);
            this.chart1.TabIndex = 67;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(16, 56);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.LabelBorderWidth = 2;
            series4.Legend = "Legend1";
            series4.Name = "En Çok Okunan Kitaplar";
            series4.YValuesPerPoint = 3;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(776, 382);
            this.chart2.TabIndex = 68;
            this.chart2.Text = "chart2";
            // 
            // imgKapat
            // 
            this.imgKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(769, 3);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(30, 30);
            this.imgKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKapat.TabIndex = 69;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // imgAltaAl
            // 
            this.imgAltaAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAltaAl.Image = ((System.Drawing.Image)(resources.GetObject("imgAltaAl.Image")));
            this.imgAltaAl.Location = new System.Drawing.Point(735, 3);
            this.imgAltaAl.Name = "imgAltaAl";
            this.imgAltaAl.Size = new System.Drawing.Size(30, 30);
            this.imgAltaAl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAltaAl.TabIndex = 70;
            this.imgAltaAl.TabStop = false;
            this.imgAltaAl.Click += new System.EventHandler(this.imgAltaAl_Click);
            // 
            // FrmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.imgAltaAl);
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cmbTablo);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İSTATİSTİKLER";
            this.Load += new System.EventHandler(this.FrmIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAltaAl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTablo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox imgKapat;
        private System.Windows.Forms.PictureBox imgAltaAl;
    }
}