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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        sql_baglanti baglan = new sql_baglanti();

        private void frmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from kullanicilar where kullaniciAdi=@p1 and sifre=@p2", baglan.sql_baglantisi());
            komut.Parameters.AddWithValue("@p1", txtKullanciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                frmAnaSayfa fr = new frmAnaSayfa();
                fr.k_ad = txtKullanciAdi.Text;
                fr.Show();
                this.Hide();
                MessageBox.Show("Sayın : " + oku[1].ToString()+ " " + oku[2].ToString()  + " HOŞGELDİNİZ !", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalıdır.");
            }
            baglan.sql_baglantisi().Close();

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
