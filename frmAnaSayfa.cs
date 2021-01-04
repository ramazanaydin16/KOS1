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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        public string k_ad;

        sql_baglanti baglan = new sql_baglanti();

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            lblK_ad.Text = k_ad; //GİRİŞ YAPILAN KULLANICIYI ANA SAYFADA GÖRMEK İÇİN YÖNETİCİ VE YETKİLİYİ AYIRMAK İÇİN
            if (k_ad == "rmznaydin")
            {            
                btnKullaniciAyarlari.Visible = true;
            }
            else
            {
                btnKullaniciAyarlari.Visible = false;
            }
            
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            frmKitapEkle KitapEkle = new frmKitapEkle();
            KitapEkle.Show();
        }

        private void benOkuyucuEkle_Click(object sender, EventArgs e)
        {
            frmOkuyucuEkle OkuyucuEkle = new frmOkuyucuEkle();
            OkuyucuEkle.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar Ayarlar = new frmAyarlar();
            Ayarlar.Show();
        }

        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            frmEmanetler Emanetler = new frmEmanetler();
            Emanetler.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistik = new FrmIstatistik();
            istatistik.Show();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            frmKullanicilar kullanicilar = new frmKullanicilar();
            kullanicilar.Show();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
