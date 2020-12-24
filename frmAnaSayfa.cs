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
            lblK_ad.Text = k_ad; //GİRİŞ YAPILAN KULLANICIYI ANA SAYFADA GÖRMEK İÇİN YÖNETİCİ VE YETKİLİYİ AYIRMAK İÇİN
            if (k_ad == "rmznaydin")
            {
                btnYetkiliEkle.Visible = true;
            }
            else
            {
                btnYetkiliEkle.Visible = false;
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
    }
}
