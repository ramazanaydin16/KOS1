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
    public partial class frmOkuyucuEkle : Form
    {
        public frmOkuyucuEkle()
        {
            InitializeComponent();
        }

        //SQL BAGLANTISI
        sql_baglanti baglan = new sql_baglanti();

        void Okuyucular() // OKUYUCULAR LİSTESİNİ HERYERDEN ÇAĞIRMAK İÇİN METHOT VE DATAGRIDE VERİLERİ EKLEME METHODU
        {
            DataTable dataTableOkuyucular = new DataTable();
            SqlDataAdapter dataAdapterOkuyucular = new SqlDataAdapter("SELECT [adi],[soyadi],[cinsiyeti],[okulno],[sinifi],[ceptel],[adres] FROM okuyucular where Aktif = 1", baglan.sql_baglantisi());
            dataAdapterOkuyucular.Fill(dataTableOkuyucular);
            dataGridOkuyucular.DataSource = dataTableOkuyucular;
        }

        private void frmOkuyucuEkle_Load(object sender, EventArgs e)
        {
            Okuyucular();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int okuyucuID;
            SqlCommand komutOkuyucuEkle = new SqlCommand("INSERT INTO okuyucular([adi],[soyadi],[cinsiyeti],[okulno],[sinifi],[ceptel],[adres]) " +
                "VALUES (@o1, @o2, @o3,@o4,@o5,@o6,@o7) select @@IDENTITY", baglan.sql_baglantisi());
            komutOkuyucuEkle.Parameters.AddWithValue("@o1", txtAd.Text);
            komutOkuyucuEkle.Parameters.AddWithValue("@o2", txtSoyad.Text);
            if (radioBay.Checked)
            {
                komutOkuyucuEkle.Parameters.AddWithValue("@o3", radioBay.Text);
            }
            else if (radioBayan.Checked)
            {
                komutOkuyucuEkle.Parameters.AddWithValue("@o3", radioBayan.Text);
            }
            
            komutOkuyucuEkle.Parameters.AddWithValue("@o4", txtOkulNo.Text);
            komutOkuyucuEkle.Parameters.AddWithValue("@o5", txtSinif.Text);
            komutOkuyucuEkle.Parameters.AddWithValue("@o6", mskTel.Text);
            komutOkuyucuEkle.Parameters.AddWithValue("@o7", txtAdres.Text);
            komutOkuyucuEkle.ExecuteNonQuery();
            baglan.sql_baglantisi().Close();
            MessageBox.Show("Okuyucu Ekleme işlemi başarıyla gerçekleşmiştir.", "Okyucu Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSoyad.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridOkuyucular.Rows[e.RowIndex].Cells[2].Value.ToString() =="Bay")
            {
                radioBay.Checked = true;
            }
            else if (dataGridOkuyucular.Rows[e.RowIndex].Cells[2].Value.ToString() == "Bayan")
            {
                radioBayan.Checked = true;
            }
            txtSinif.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOkulNo.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTel.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAdres.Text = dataGridOkuyucular.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
