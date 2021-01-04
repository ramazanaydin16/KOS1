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
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        sql_baglanti baglan = new sql_baglanti();

        void kullanicilar()  // KULLANICILAR TABLOSUNU ÇEKME
        {
            DataTable dataTableKullanicilar = new DataTable();
            SqlDataAdapter dataAdapterKullanicilar = new SqlDataAdapter("select id 'ID', ad 'AD', soyad 'SOYAD', kullaniciAdi 'KULLANICI ADI', sifre 'ŞİFRE' from kullanicilar", baglan.sql_baglantisi());
            dataAdapterKullanicilar.Fill(dataTableKullanicilar);
            dataGridKullanicilar.DataSource= dataTableKullanicilar;
        }

        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            kullanicilar();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgAltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridKullanicilar.SelectedCells[0].RowIndex;
            txtID.Text = dataGridKullanicilar.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridKullanicilar.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridKullanicilar.Rows[secilen].Cells[2].Value.ToString();
            txtKullaniciAdi.Text = dataGridKullanicilar.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridKullanicilar.Rows[secilen].Cells[4].Value.ToString();
            txtSifreTekrar.Text = dataGridKullanicilar.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") // ID kutusu boş ise yeni kayıt
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz.","HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (txtSifreTekrar.Text == txtSifre.Text)
                    {
                        SqlCommand komutKullaniciEkle = new SqlCommand("INSERT INTO kullanicilar (ad,soyad,kullaniciAdi,sifre) VALUES (@a1,@a2,@a3,@a4)", baglan.sql_baglantisi());
                        komutKullaniciEkle.Parameters.AddWithValue("@a1", txtAd.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("@a2", txtSoyad.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("@a3", txtKullaniciAdi.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("@a4", txtSifre.Text);
                        komutKullaniciEkle.ExecuteNonQuery();
                        kullanicilar();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Kullanıcı Ekleme işlemi başarıyla gerçekleşmiştir.", "Kullanıcı Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Şifre uyuşmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else // ID KUTUSU DOLU İSE KUTUDA YAZAN ID NUMARASININ BİLGİLERİNİ GÜNCELLER
            {
                if (txtAd.Text == "" || txtSoyad.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm alanları doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtSifreTekrar.Text == txtSifre.Text)
                    {
                        SqlCommand komutKullaniciGuncelle = new SqlCommand("UPDATE kullanicilar SET ad = @u1, soyad = @u2, kullaniciAdi= @u3, sifre= @u4 where id = @u5", baglan.sql_baglantisi());
                        komutKullaniciGuncelle.Parameters.AddWithValue("@u1", txtAd.Text);
                        komutKullaniciGuncelle.Parameters.AddWithValue("@u2", txtSoyad.Text);
                        komutKullaniciGuncelle.Parameters.AddWithValue("@u3", txtKullaniciAdi.Text);
                        komutKullaniciGuncelle.Parameters.AddWithValue("@u4", txtSifre.Text);
                        komutKullaniciGuncelle.Parameters.AddWithValue("@u5", txtID.Text);
                        komutKullaniciGuncelle.ExecuteNonQuery();
                        kullanicilar();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Kullanıcı Güncelleme işlemi başarıyla gerçekleşmiştir.", "Kullanıcı Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Şifre uyuşmuyor.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }
    }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") 
            {
                MessageBox.Show("Lütfen Listeden Kullanıcı Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtID.Text) > 0)
            {
                DialogResult KullaniciSilCevap = MessageBox.Show("Seçtiğiniz Kullanıcıyı Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KullaniciSilCevap == DialogResult.Yes)
                {
                    SqlCommand komutKullaniciSil = new SqlCommand("delete from kullanicilar where id = @s1", baglan.sql_baglantisi());
                    komutKullaniciSil.Parameters.AddWithValue("@s1", txtID.Text);
                    komutKullaniciSil.ExecuteNonQuery();
                    kullanicilar();
                    baglan.sql_baglantisi().Close();
                    MessageBox.Show("Kullanıcı Silme işlemi başarıyla gerçekleşmiştir.", "Kullanıcı Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Kullanıcı Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
