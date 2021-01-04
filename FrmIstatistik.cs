using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KSO
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        sql_baglanti baglan = new sql_baglanti();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            cmbTablo.SelectedIndex = 0;
        }

        private void cmbTablo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablo.SelectedIndex == 0)
            {
                chart2.Visible = false;
                chart1.Visible = true;
                SqlCommand komutEnCokOkuyanlar = new SqlCommand("SELECT top 5 okuyucular.adi + ' ' + okuyucular.soyadi 'Ad Soyad', count(*) 'Okuduğu Kitap Sayısı ' FROM emanetler inner join okuyucular on emanetler.okuyucuID = okuyucular.okuyucuID group by okuyucular.adi + ' ' + okuyucular.soyadi order by count(*) desc", baglan.sql_baglantisi());
                SqlDataReader verileriOku = komutEnCokOkuyanlar.ExecuteReader();
                while (verileriOku.Read())
                {
                    chart1.Series["En Çok Kitap Okuyanlar"].Points.AddXY(verileriOku[0], verileriOku[1]);
                }
                baglan.sql_baglantisi().Close();
            }
            else if (cmbTablo.SelectedIndex == 1)
            {
                chart1.Visible = false;
                chart2.Visible = true;
                SqlCommand komutEnCokOkunanKitaplar = new SqlCommand("SELECT top 5 kitaplar.KitapAdi 'Kitap Adı', count(*) 'Kaç kere okunmuştur ? ' FROM emanetler inner join kitaplar on emanetler.kitapID = kitaplar.KitapID group by kitaplar.KitapAdi order by count(*) desc", baglan.sql_baglantisi());
                SqlDataReader verileriOku = komutEnCokOkunanKitaplar.ExecuteReader();
                while (verileriOku.Read())
                {
                    chart2.Series["En Çok Okunan Kitaplar"].Points.AddXY(verileriOku[0], verileriOku[1]);
                }
                baglan.sql_baglantisi().Close();
            }
            
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
