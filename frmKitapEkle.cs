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
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }

        sql_baglanti baglan = new sql_baglanti();

        void KitaplarListesi() // KİTAPLAR LİSTESİNİ HERYERDEN ÇAĞIRMAK İÇİN METHOT VE DATAGRIDE VERİLERİ EKLEME METHODU
        {
            DataTable dataTableKitapListesi = new DataTable();
            SqlDataAdapter dataAdapterKitapListesi = new SqlDataAdapter("SELECT [KitapID] 'ID',[KitapAdi] 'KİTAP ADI',[YazarAdi] 'YAZAR ADI',[YayinEvi] 'YAYIN EVİ',[BasimYili] 'BASIM YILI',[SayfaSayisi] 'SAYFA SAYISI',[Tur] 'KİTAP TÜRÜ',[Dolap] 'DOLAP',[Raf] 'RAF',[Sira] 'SIRA',[Aciklama] 'ACIKLAMA' ,[durum] 'DURUM' FROM kitaplar where Aktif = 1", baglan.sql_baglantisi());
            dataAdapterKitapListesi.Fill(dataTableKitapListesi);
            dataGridKitap.DataSource = dataTableKitapListesi;
        }

        //TEMİZLEME METHODU
        void Temizle()
        {
            txtKitapID.Text = "";
            txtKitapAdi.Text = "";
            cmbYazar.SelectedIndex = -1;
            cmbYayinEvi.SelectedIndex = -1;
            txtBasimYili.Text = "";
            txtSayfaSayisi.Text = "";
            cmbKitapTuru.SelectedIndex = -1;
            cmbDolap.SelectedIndex = -1;
            txtRaf.Text = "";
            txtSira.Text = "";
            txtAciklama.Text = "";
        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            txtKitapID.Text = ""; // FORM YÜKLENDİĞİNDE VE İŞLEM YAPILMADAN ÖNCE BOŞ DURMASI İÇİN
            //COMBOBOX'A SQL'DEN YAZARLARI EKLEME
            SqlCommand komutYazar = new SqlCommand("select adi from yazarlar", baglan.sql_baglantisi());
            SqlDataReader readYazar = komutYazar.ExecuteReader();
            while (readYazar.Read())
            {
                cmbYazar.Items.Add(readYazar[0]);
            }
            baglan.sql_baglantisi();

            //COMBOBOX'A SQL'DEN YAYIN EVLERİNİ EKLEME
            SqlCommand komutYayinEvi = new SqlCommand("select adi from yayinevleri", baglan.sql_baglantisi());
            SqlDataReader readYayinEvi = komutYayinEvi.ExecuteReader();
            while (readYayinEvi.Read())
            {
                cmbYayinEvi.Items.Add(readYayinEvi[0]);
            }
            baglan.sql_baglantisi();

            //COMBOBOX'A SQL'DEN KİTAP TÜRLERİNİ EKLEME
            SqlCommand komutKitapTuru = new SqlCommand("select adi from turler", baglan.sql_baglantisi());
            SqlDataReader readKitapTuru = komutKitapTuru.ExecuteReader();
            while (readKitapTuru.Read())
            {
                cmbKitapTuru.Items.Add(readKitapTuru[0]);
            }
            baglan.sql_baglantisi();

            //COMBOBOX'A SQL'DEN DOLARP İSİMLERİNİ EKLEME
            SqlCommand komutDolaplar = new SqlCommand("select adi from dolaplar", baglan.sql_baglantisi());
            SqlDataReader readDolaplar = komutDolaplar.ExecuteReader();
            while (readDolaplar.Read())
            {
                cmbDolap.Items.Add(readDolaplar[0]);
            }
            baglan.sql_baglantisi();

            KitaplarListesi();// FORM YÜKLENDİĞİNDE DATAGRİDE KİTAPLARI EKLEMEK İÇİN
        }

        // KİTAP EKLEME VE GÜNCELLEME KODLARI
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKitapID.Text == "") // KİTAP ID'si BOŞ İSE YENİ KİTAP EKLER
            {
                SqlCommand komutKitapekle = new SqlCommand("INSERT INTO kitaplar (KitapAdi, YazarAdi, YayinEvi, BasimYili, SayfaSayisi, Tur, Dolap, Raf, Sira, Aciklama) VALUES (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan.sql_baglantisi());
                komutKitapekle.Parameters.AddWithValue("@p2", txtKitapAdi.Text);
                komutKitapekle.Parameters.AddWithValue("@p3", cmbYazar.Text);
                komutKitapekle.Parameters.AddWithValue("@p4", cmbYayinEvi.Text);
                komutKitapekle.Parameters.AddWithValue("@p5", txtBasimYili.Text);
                komutKitapekle.Parameters.AddWithValue("@p6", txtSayfaSayisi.Text);
                komutKitapekle.Parameters.AddWithValue("@p7", cmbKitapTuru.Text);
                komutKitapekle.Parameters.AddWithValue("@p8", cmbDolap.Text);
                komutKitapekle.Parameters.AddWithValue("@p9", txtRaf.Text);
                komutKitapekle.Parameters.AddWithValue("@p10", txtSira.Text);
                komutKitapekle.Parameters.AddWithValue("@p11", txtAciklama.Text);
                komutKitapekle.ExecuteNonQuery();
                KitaplarListesi();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Kitap Ekleme işlemi başarıyla gerçekleşmiştir.", "Kitap Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else // DİĞER DURUMLARDA KİTABI GÜNCELLER
            {
                SqlCommand komutKitapGuncelle = new SqlCommand("UPDATE kitaplar SET KitapAdi = @u1, YazarAdi = @u2, YayinEvi = @u3, BasimYili = @u4, SayfaSayisi = @u5, Tur = @u6, Dolap = @u7, Raf = @u8, Sira = @u9, Aciklama = @u10 where KitapID = @u11", baglan.sql_baglantisi());
                komutKitapGuncelle.Parameters.AddWithValue("@u1", txtKitapAdi.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u2", cmbYazar.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u3", cmbYayinEvi.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u4", txtBasimYili.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u5", txtSayfaSayisi.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u6", cmbKitapTuru.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u7", cmbDolap.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u8", txtRaf.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u9", txtSira.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u10", txtAciklama.Text);
                komutKitapGuncelle.Parameters.AddWithValue("@u11", txtKitapID.Text);
                komutKitapGuncelle.ExecuteNonQuery();
                KitaplarListesi();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Kitap Güncelleme işlemi başarıyla gerçekleşmiştir.", "Kitap Güncellendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }

        }

        //KİTAP SİLME İŞLEMİ
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKitapID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Kitap Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtKitapID.Text) > 0)
            {
                DialogResult KitapSilCevap = MessageBox.Show("Seçtiğiniz Kitabı Silmek İstediğinize Emin misiniz ?","Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (KitapSilCevap == DialogResult.Yes)
                {
                    SqlCommand komutKitapSil = new SqlCommand("UPDATE kitaplar SET Aktif = 0 where KitapID = @s1", baglan.sql_baglantisi());
                    komutKitapSil.Parameters.AddWithValue("@s1", txtKitapID.Text);
                    komutKitapSil.ExecuteNonQuery();
                    KitaplarListesi();
                    baglan.sql_baglantisi().Close();
                    MessageBox.Show("Kitap Silme işlemi başarıyla gerçekleşmiştir.", "Kitap Silindi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Kitap Seçiniz !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //HÜCRELERİ TEMİZLEME İŞLEMİ
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            MessageBox.Show("Tüm Hücreler Temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // DATAGRIDDEN SEÇİLEN SATIRI HÜCRELERE ÇEKME
        private void dataGridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridKitap.SelectedCells[0].RowIndex;
            txtKitapID.Text = dataGridKitap.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridKitap.Rows[secilen].Cells[1].Value.ToString();
            cmbYazar.Text = dataGridKitap.Rows[secilen].Cells[2].Value.ToString();
            cmbYayinEvi.Text = dataGridKitap.Rows[secilen].Cells[3].Value.ToString();
            txtBasimYili.Text = dataGridKitap.Rows[secilen].Cells[4].Value.ToString();
            txtSayfaSayisi.Text = dataGridKitap.Rows[secilen].Cells[5].Value.ToString();
            cmbKitapTuru.Text = dataGridKitap.Rows[secilen].Cells[6].Value.ToString();
            cmbDolap.Text = dataGridKitap.Rows[secilen].Cells[7].Value.ToString();
            txtRaf.Text = dataGridKitap.Rows[secilen].Cells[8].Value.ToString();
            txtSira.Text = dataGridKitap.Rows[secilen].Cells[9].Value.ToString();
            txtAciklama.Text = dataGridKitap.Rows[secilen].Cells[10].Value.ToString();
        }

        //YAZAR ARAMA KODLARI
        private void txtYazarAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTableYazarAra = new DataTable();
            SqlDataAdapter dataAdapterYazarAra = new SqlDataAdapter("select * from kitaplar where Aktif = 1 and YazarAdi like @s1", baglan.sql_baglantisi());
            dataAdapterYazarAra.SelectCommand.Parameters.AddWithValue("@s1", "%" + txtYazarAra.Text + "%");
            dataAdapterYazarAra.Fill(dataTableYazarAra);
            dataGridKitap.DataSource = dataTableYazarAra;
        }

        //KİTAP ARAMA KODLARI
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTableKitapAra = new DataTable();
            SqlDataAdapter dataAdapterKitapAra = new SqlDataAdapter("select * from kitaplar where Aktif = 1 and KitapAdi like @k1", baglan.sql_baglantisi());
            dataAdapterKitapAra.SelectCommand.Parameters.AddWithValue("@k1", "%" + txtKitapAra.Text + "%");
            dataAdapterKitapAra.Fill(dataTableKitapAra);
            dataGridKitap.DataSource = dataTableKitapAra;
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
