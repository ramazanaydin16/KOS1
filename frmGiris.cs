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
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmAnaSayfa fr = new frmAnaSayfa();
                fr.k_ad = txtKullanciAdi.Text;
                fr.Show();
                this.Hide();               
            }
            else
            {
                MessageBox.Show("Bilgilieriniz Hatalıdır.");
            }
            baglan.sql_baglantisi().Close();

        }
    }
}
