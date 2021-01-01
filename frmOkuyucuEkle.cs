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
            SqlDataAdapter dataAdapterOkuyucular = new SqlDataAdapter("SELECT [okuyucuID] 'ID',[adi] 'AD',[soyadi] 'SOYAD',[cinsiyeti] 'CİNSİYET',[okulno] 'OKUL NO',[sinifi] 'SINIF',[ceptel] 'TELEFON',[adres] 'ADRES' FROM okuyucular where Aktif = 1", baglan.sql_baglantisi());
            dataAdapterOkuyucular.Fill(dataTableOkuyucular);
            dataGridOkuyucular.DataSource = dataTableOkuyucular;
        }

        //TEMİZLEME METHODU
        void Temizle()
        {
            txtOkyucuID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSinif.Text = "";
            txtOkulNo.Text = "";
            txtAdres.Text = "";
            mskTel.Text = "";
            radioBay.Checked = false;
            radioBayan.Checked = false;
        }

        private void frmOkuyucuEkle_Load(object sender, EventArgs e)
        {
            Okuyucular();
        }

        // OKUYUCU EKLEME VE GÜNCELLEME
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //OKUYUCU EKLEME
            if (txtOkyucuID.Text == "")
            {
                SqlCommand komutOkuyucuEkle = new SqlCommand("INSERT INTO okuyucular([adi],[soyadi],[cinsiyeti],[okulno],[sinifi],[ceptel],[adres]) " +
                "VALUES (@o1, @o2, @o3,@o4,@o5,@o6,@o7)", baglan.sql_baglantisi());
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
                Okuyucular();
                Temizle();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Okuyucu Ekleme işlemi başarıyla gerçekleşmiştir.", "Okuyucu Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //OKUYUCU GÜNCELLEME
            else
            {
                SqlCommand komutOkuyucuGuncelle = new SqlCommand("UPDATE okuyucular set adi=@u1,soyadi=@u2,cinsiyeti=@u3,okulno=@u4,sinifi=@u5,ceptel=@u6,adres=@u7 where okuyucuID = @u8 ", baglan.sql_baglantisi());
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u1", txtAd.Text);
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u2", txtSoyad.Text);
                if (radioBay.Checked)
                {
                    komutOkuyucuGuncelle.Parameters.AddWithValue("@u3", radioBay.Text);
                }
                else if (radioBayan.Checked)
                {
                    komutOkuyucuGuncelle.Parameters.AddWithValue("@u3", radioBayan.Text);
                }
                else
                {
                    komutOkuyucuGuncelle.Parameters.AddWithValue("@u3", "-");
                }

                komutOkuyucuGuncelle.Parameters.AddWithValue("@u4", txtOkulNo.Text);
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u5", txtSinif.Text);
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u6", mskTel.Text);
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u7", txtAdres.Text);
                komutOkuyucuGuncelle.Parameters.AddWithValue("@u8", txtOkyucuID.Text);
                komutOkuyucuGuncelle.ExecuteNonQuery();
                Okuyucular();
                Temizle();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Okuyucu Güncelleme işlemi başarıyla gerçekleşmiştir.", "Okyucu Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //TIKLANAN SATIRI HÜCRELERE DOLDURMA
        private void dataGridOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridOkuyucular.SelectedCells[0].RowIndex;
            txtOkyucuID.Text = dataGridOkuyucular.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridOkuyucular.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridOkuyucular.Rows[secilen].Cells[2].Value.ToString();
            if (dataGridOkuyucular.Rows[secilen].Cells[3].Value.ToString() == "Bay")
            {
                radioBay.Checked = true;
            }
            else if (dataGridOkuyucular.Rows[secilen].Cells[3].Value.ToString() == "Bayan")
            {
                radioBayan.Checked = true;
            }
            txtOkulNo.Text = dataGridOkuyucular.Rows[secilen].Cells[4].Value.ToString();
            txtSinif.Text = dataGridOkuyucular.Rows[secilen].Cells[5].Value.ToString();
            mskTel.Text = dataGridOkuyucular.Rows[secilen].Cells[6].Value.ToString();
            txtAdres.Text = dataGridOkuyucular.Rows[secilen].Cells[7].Value.ToString();

        }

        // TEXTBOX VE DİĞER VERİLERİ TEMİZLEME
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        // OKUYUCU SİLME İŞLEMİ
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOkyucuID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Okuyucu Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtOkyucuID.Text) > 0)
            {
                DialogResult okuyucuSilCevap = MessageBox.Show("Seçtiğiniz Okuyucuyu Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (okuyucuSilCevap == DialogResult.Yes)
                {
                    SqlCommand komutOkuyucuSil = new SqlCommand("UPDATE okuyucular SET Aktif = 0 where okuyucuID = @s1", baglan.sql_baglantisi());
                    komutOkuyucuSil.Parameters.AddWithValue("@s1", txtOkyucuID.Text);
                    komutOkuyucuSil.ExecuteNonQuery();
                    Okuyucular();
                    baglan.sql_baglantisi().Close();
                    MessageBox.Show("Okuyucu Silme işlemi başarıyla gerçekleşmiştir.", "Okuyucu Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Okuyucu Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //OKUYUCU ARA
        private void txtOkuyucuAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTableOkuyucuAra = new DataTable();
            SqlDataAdapter dataAdapterOkuyucuAra = new SqlDataAdapter("select * from okuyucular where Aktif = 1 and adi like @k1", baglan.sql_baglantisi());
            dataAdapterOkuyucuAra.SelectCommand.Parameters.AddWithValue("@k1", "%" + txtOkuyucuAra.Text + "%");
            dataAdapterOkuyucuAra.Fill(dataTableOkuyucuAra);
            dataGridOkuyucular.DataSource = dataTableOkuyucuAra;
        }
    }
}
