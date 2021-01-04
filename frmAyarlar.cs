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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        sql_baglanti baglan = new sql_baglanti();

        void tabloYazarlar() // YAZARLAR VERİLERİNİ ÇEK
        {
            DataTable dataTableYazarlar = new DataTable();
            SqlDataAdapter dataAdapterYazarlar = new SqlDataAdapter("SELECT id 'YAZAR ID',Adi'YAZAR ADI' FROM yazarlar", baglan.sql_baglantisi());
            dataAdapterYazarlar.Fill(dataTableYazarlar);
            dataGridAyarlar.DataSource = dataTableYazarlar;
        }

        void tabloYayinEvleri() // YAYIN EVLERİ VERİLERİNİ ÇEK
        {
            DataTable dataTableYayinEvleri = new DataTable();
            SqlDataAdapter dataAdapterYayinEvleri = new SqlDataAdapter("SELECT id 'YAYIN EVİ ID',Adi'YAYIN EVİ ADI' FROM yayinevleri", baglan.sql_baglantisi());
            dataAdapterYayinEvleri.Fill(dataTableYayinEvleri);
            dataGridAyarlar.DataSource = dataTableYayinEvleri;
        }

        void tabloTurler() // TÜRLER VERİLERİNİ ÇEK
        {
            DataTable dataTableTurler = new DataTable();
            SqlDataAdapter dataAdapterTurler = new SqlDataAdapter("SELECT id 'TÜR ID',Adi'TÜR ADI' FROM turler", baglan.sql_baglantisi());
            dataAdapterTurler.Fill(dataTableTurler);
            dataGridAyarlar.DataSource = dataTableTurler;
        }
        void tabloDolaplar() // DOLAPLAR VERİLERİNİ ÇEK
        {
            DataTable dataTableDolaplar = new DataTable();
            SqlDataAdapter dataAdapterDolaplar = new SqlDataAdapter("SELECT id 'DOLAP ID',Adi'DOLAP ADI' FROM dolaplar", baglan.sql_baglantisi());
            dataAdapterDolaplar.Fill(dataTableDolaplar);
            dataGridAyarlar.DataSource = dataTableDolaplar;
        }

        void Temizle() // TEMİZLEME METHODU
        {
            txtID.Text = "";
            txtisim.Text = "";
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            
            cmbTabloAdi.Items.Add("Yazarlar");
            cmbTabloAdi.Items.Add("Yayın Evleri");
            cmbTabloAdi.Items.Add("Türler");
            cmbTabloAdi.Items.Add("Dolaplar");
            cmbTabloAdi.SelectedIndex = 0;          
        }

        // SEÇİLEN TABLO ADININ VERİLERİNİ ÇEKME
        private void cmbTabloAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTabloAdi.SelectedIndex == 0)
            {
                tabloYazarlar();
                Temizle();
            }

            else if (cmbTabloAdi.SelectedIndex == 1)
            {
                tabloYayinEvleri();
                Temizle();
            }

            else if (cmbTabloAdi.SelectedIndex == 2)
            {
                tabloTurler();
                Temizle();
            }

            else if (cmbTabloAdi.SelectedIndex == 3)
            {
                tabloDolaplar();
                Temizle();
            }       

        }

        //TABLODAN SEÇİLEN SATIRDAKİ VERİLERİ AKTARMA
        private void dataGridAyarlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridAyarlar.SelectedCells[0].RowIndex;
            txtID.Text = dataGridAyarlar.Rows[secilen].Cells[0].Value.ToString();
            txtisim.Text = dataGridAyarlar.Rows[secilen].Cells[1].Value.ToString();

        }


        // YENİ KAYIT EKLEME VE GÜNCELLEME
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") //YENİKAYIT
            {
                if (cmbTabloAdi.SelectedIndex == 0)
                {
                    SqlCommand komutAyarlarKaydet = new SqlCommand("INSERT INTO yazarlar(adi) values (@k1)", baglan.sql_baglantisi());
                    komutAyarlarKaydet.Parameters.AddWithValue("@k1", txtisim.Text);
                    komutAyarlarKaydet.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloYazarlar();
                    Temizle();
                    MessageBox.Show("Yazar Ekleme işlemi başarıyla gerçekleşmiştir.", "Yazar Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbTabloAdi.SelectedIndex == 1)
                {
                    SqlCommand komutAyarlarKaydet = new SqlCommand("INSERT INTO yayinevleri(adi) values (@k1)", baglan.sql_baglantisi());
                    komutAyarlarKaydet.Parameters.AddWithValue("@k1", txtisim.Text);
                    komutAyarlarKaydet.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloYayinEvleri();
                    Temizle();
                    MessageBox.Show("Yayın Evi Ekleme işlemi başarıyla gerçekleşmiştir.", "Yayın Evi Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (cmbTabloAdi.SelectedIndex == 2)
                {
                    SqlCommand komutAyarlarKaydet = new SqlCommand("INSERT INTO turler(adi) values (@k1)", baglan.sql_baglantisi());
                    komutAyarlarKaydet.Parameters.AddWithValue("@k1", txtisim.Text);
                    komutAyarlarKaydet.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloTurler();
                    Temizle();
                    MessageBox.Show("Tür Ekleme işlemi başarıyla gerçekleşmiştir.", "Tür Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (cmbTabloAdi.SelectedIndex == 3)
                {
                    SqlCommand komutAyarlarKaydet = new SqlCommand("INSERT INTO dolaplar(adi) values (@k1)", baglan.sql_baglantisi());
                    komutAyarlarKaydet.Parameters.AddWithValue("@k1", txtisim.Text);
                    komutAyarlarKaydet.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloDolaplar();
                    Temizle();
                    MessageBox.Show("Dolap işlemi başarıyla gerçekleşmiştir.", "Dolap Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else //GÜNCELLEME
            {
                if (cmbTabloAdi.SelectedIndex == 0)
                {
                    SqlCommand komutAyarlarGuncelle = new SqlCommand("UPDATE yazarlar SET adi = @u1 where id = @u2", baglan.sql_baglantisi());
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u1", txtisim.Text);
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u2", txtID.Text);
                    komutAyarlarGuncelle.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloYazarlar();
                    Temizle();
                    MessageBox.Show("Yazar Güncelle işlemi başarıyla gerçekleşmiştir.", "Yazar Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbTabloAdi.SelectedIndex == 1)
                {
                    SqlCommand komutAyarlarGuncelle = new SqlCommand("UPDATE yayinevleri SET adi = @u1 where id = @u2", baglan.sql_baglantisi());
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u1", txtisim.Text);
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u2", txtID.Text);
                    komutAyarlarGuncelle.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloYayinEvleri();
                    Temizle();
                    MessageBox.Show("Yayın Evi Güncelle işlemi başarıyla gerçekleşmiştir.", "Yayın Evi Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbTabloAdi.SelectedIndex == 2)
                {
                    SqlCommand komutAyarlarGuncelle = new SqlCommand("UPDATE turler SET adi = @u1 where id = @u2", baglan.sql_baglantisi());
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u1", txtisim.Text);
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u2", txtID.Text);
                    komutAyarlarGuncelle.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloTurler();
                    Temizle();
                    MessageBox.Show("Tür Güncelle işlemi başarıyla gerçekleşmiştir.", "Tür Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbTabloAdi.SelectedIndex == 3)
                {
                    SqlCommand komutAyarlarGuncelle = new SqlCommand("UPDATE dolaplar SET adi = @u1 where id = @u2", baglan.sql_baglantisi());
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u1", txtisim.Text);
                    komutAyarlarGuncelle.Parameters.AddWithValue("@u2", txtID.Text);
                    komutAyarlarGuncelle.ExecuteNonQuery();
                    baglan.sql_baglantisi().Close();
                    tabloDolaplar();
                    Temizle();
                    MessageBox.Show("Dolap Güncelle işlemi başarıyla gerçekleşmiştir.", "Dolap Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        //SİLME İŞLEMİ
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Seçim Yapınız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtID.Text) > 0)
            {
                if (cmbTabloAdi.SelectedIndex == 0)
                {
                    DialogResult SilCevap = MessageBox.Show("Seçtiğiniz Yazarı Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (SilCevap == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("DELETE FROM yazarlar where id = @s1", baglan.sql_baglantisi());
                        komutSil.Parameters.AddWithValue("@s1", txtID.Text);
                        komutSil.ExecuteNonQuery();
                        tabloYazarlar();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Yazar Silme işlemi başarıyla gerçekleşmiştir.", "Yazar Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.");
                    }
                }

                else if (cmbTabloAdi.SelectedIndex == 1)
                {
                    DialogResult SilCevap = MessageBox.Show("Seçtiğiniz Yayın Evini Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (SilCevap == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("DELETE FROM yayinevleri where id = @s1", baglan.sql_baglantisi());
                        komutSil.Parameters.AddWithValue("@s1", txtID.Text);
                        komutSil.ExecuteNonQuery();
                        tabloYayinEvleri();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Yayın Evi Silme işlemi başarıyla gerçekleşmiştir.", "Yayın Evi Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.");
                    }
                }

                else if (cmbTabloAdi.SelectedIndex == 2)
                {
                    DialogResult SilCevap = MessageBox.Show("Seçtiğiniz Türü Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (SilCevap == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("DELETE FROM turler where id = @s1", baglan.sql_baglantisi());
                        komutSil.Parameters.AddWithValue("@s1", txtID.Text);
                        komutSil.ExecuteNonQuery();
                        tabloTurler();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Tür Silme işlemi başarıyla gerçekleşmiştir.", "Tür Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.");
                    }
                }

                else if (cmbTabloAdi.SelectedIndex == 3)
                {
                    DialogResult SilCevap = MessageBox.Show("Seçtiğiniz Dolabı Silmek İstediğinize Emin misiniz ?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (SilCevap == DialogResult.Yes)
                    {
                        SqlCommand komutSil = new SqlCommand("DELETE FROM dolaplar where id = @s1", baglan.sql_baglantisi());
                        komutSil.Parameters.AddWithValue("@s1", txtID.Text);
                        komutSil.ExecuteNonQuery();
                        tabloDolaplar();
                        baglan.sql_baglantisi().Close();
                        MessageBox.Show("Dolap Silme işlemi başarıyla gerçekleşmiştir.", "Dolap Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen Listeden Seçim Yapınız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
