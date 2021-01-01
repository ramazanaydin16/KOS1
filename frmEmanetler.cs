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
    public partial class frmEmanetler : Form
    {
        public frmEmanetler()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtKitapID.Text = "";
            txtKitapAdi.Text = "";
            txtOkuyucuID.Text = "";
            txtAdSoyad.Text = "";
        }
        void kitaplar()  // KİTAPLAR LİSTESİNİ ÖZELLEŞMİŞ ŞEKİLDE GRIDE ÇEKME
        {
            DataTable dataTableKitaplar = new DataTable();
            SqlDataAdapter dataAdapterKitaplar = new SqlDataAdapter("SELECT [KitapID] 'ID',[KitapAdi] 'KİTAP ADI',[YazarAdi] 'YAZAR ADI', [durum] 'DURUM' FROM kitaplar where Aktif = 1 and durum = 1", baglan.sql_baglantisi());
            dataAdapterKitaplar.Fill(dataTableKitaplar);
            dataGridKitaplar.DataSource = dataTableKitaplar;
        }
        void emanetler() // EMANETLER LİSTESİNİ ÖZELLEŞMİŞ ŞEKİLDE GRIDE ÇEKME LEFT JOIN KULLANILDI
        {
            DataTable dataTableEmanetler = new DataTable();
            SqlDataAdapter dataAdapterEmanetler = new SqlDataAdapter("SELECT kitaplar.KitapID 'KİTAP ID', kitaplar.KitapAdi 'KİTAP ADI', kitaplar.YazarAdi 'KİTAP YAZAR ADI', okuyucular.okuyucuID 'OKUYUCU ID',okuyucular.adi + ' ' + okuyucular.soyadi 'OKUYUCU ADI SOYADI', okuyucular.sinifi +' '+ okuyucular.okulno 'SINIF - NO', okuyucular.ceptel 'TELEFON', emanetler.verilisTarihi 'VERİLİŞ TARİHİ', emanetler.geriAlmaTarihi 'GERİ ALMA TARİHİ', emanetler.durum 'DURUM' FROM emanetler LEFT JOIN kitaplar ON emanetler.kitapID = kitaplar.KitapID LEFT JOIN okuyucular ON emanetler.okuyucuID = okuyucular.okuyucuID where emanetler.durum = 0", baglan.sql_baglantisi());
            dataAdapterEmanetler.Fill(dataTableEmanetler);
            dataGridEmanetler.DataSource = dataTableEmanetler;
        }
        void okuyucular() // OKUYUCULAR LİSTESİNİ ÖZELLEŞMİŞ ŞEKİLDE GRIDE ÇEKME
        {
            DataTable dataTableOkuyucular = new DataTable();
            SqlDataAdapter dataAdapterOkuyucular = new SqlDataAdapter("SELECT [okuyucuID] 'ID',[adi]+' '+[soyadi] 'AD SOYAD',[sinifi] + ' - ' + [okulno] 'SINIF - OKUL NO' FROM okuyucular where Aktif = 1 ", baglan.sql_baglantisi());
            dataAdapterOkuyucular.Fill(dataTableOkuyucular);
            dataGridOkuyucular.DataSource = dataTableOkuyucular;
        }

        sql_baglanti baglan = new sql_baglanti(); // SQL BAĞLANTISI

        string GeriAlmaTarihi1 = DateTime.Now.Date.AddDays(7).ToString().TrimEnd('0', ':'); // +7 GÜNLÜK SÜRE
        string GeriAlmaTarihi2 = DateTime.Now.Date.AddDays(30).ToString().TrimEnd('0', ':'); // +30 GÜNLÜK SÜRE
        

        private void frmEmanetler_Load(object sender, EventArgs e)
        {
            okuyucular();
            kitaplar();
            emanetler();
            temizle();

            txtVerilisTarihi.Text = DateTime.Now.Date.ToString().TrimEnd('0', ':'); // FORM YÜKLENDİĞİNDE VERİLİŞ TARİHİNİ OTOMATİK YÜKLE
        }

        private void dataGridEmanetler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // EMANETLER GRIDIN DE TIKLANAN SATIRI TEXTBOXLARA AKTARMA
            int secilen = dataGridEmanetler.SelectedCells[0].RowIndex;
            txtKitapID.Text = dataGridEmanetler.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridEmanetler.Rows[secilen].Cells[1].Value.ToString();
            txtOkuyucuID.Text = dataGridEmanetler.Rows[secilen].Cells[3].Value.ToString();
            txtAdSoyad.Text = dataGridEmanetler.Rows[secilen].Cells[4].Value.ToString();
            txtVerilisTarihi.Text = dataGridEmanetler.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridOkuyucular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // OKUYUCULAR GRIDIN DE TIKLANAN SATIRI TEXTBOXLARA AKTARMA
            int secilen = dataGridOkuyucular.SelectedCells[0].RowIndex;
            txtOkuyucuID.Text = dataGridOkuyucular.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridOkuyucular.Rows[secilen].Cells[1].Value.ToString();

        }

        private void dataGridKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // KİTAPLAR GRIDIN DE TIKLANAN SATIRI TEXTBOXLARA AKTARMA
            int secilen = dataGridKitaplar.SelectedCells[0].RowIndex;
            txtKitapID.Text = dataGridKitaplar.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridKitaplar.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            // TESLİM ETME KODLARI
            if (txtKitapID.Text == "" || txtOkuyucuID.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanların dolu olduğundan emin olun.", "HATA !.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutEmanet = new SqlCommand("INSERT INTO emanetler(kitapID, okuyucuID, verilisTarihi, geriAlmaTarihi) VALUES (@a1,@a2,@a3,@a4)", baglan.sql_baglantisi());
                komutEmanet.Parameters.AddWithValue("@a1", txtKitapID.Text);
                komutEmanet.Parameters.AddWithValue("@a2", txtOkuyucuID.Text);
                komutEmanet.Parameters.AddWithValue("@a3", txtVerilisTarihi.Text.ToString().Trim());
                if (cmbSure.SelectedIndex == 0)
                {
                    komutEmanet.Parameters.AddWithValue("@a4", GeriAlmaTarihi1);
                }

                else if ((cmbSure.SelectedIndex == 1))
                {
                    komutEmanet.Parameters.AddWithValue("@a4", GeriAlmaTarihi2);
                }
                komutEmanet.ExecuteNonQuery();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Kitap Emanet Edildi.", "İşlem Yapıldı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand komutKitapDurumGuncelle = new SqlCommand("UPDATE kitaplar SET durum = 0 where KitapID = @k1", baglan.sql_baglantisi());
                komutKitapDurumGuncelle.Parameters.AddWithValue("@k1", txtKitapID.Text);
                komutKitapDurumGuncelle.ExecuteNonQuery();
                baglan.sql_baglantisi().Close();
                emanetler();
                kitaplar();
                temizle();

            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            // TESLİM ALMA KODLARI
            if (txtKitapID.Text == "" || txtOkuyucuID.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanların dolu olduğundan emin olun.", "HATA !.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutEmanetAl = new SqlCommand("update emanetler SET durum=1 where okuyucuID = @s1 and kitapID=@s2", baglan.sql_baglantisi());
                komutEmanetAl.Parameters.AddWithValue("@s1", txtOkuyucuID.Text);
                komutEmanetAl.Parameters.AddWithValue("@s2", txtKitapID.Text);
                komutEmanetAl.ExecuteNonQuery();
                baglan.sql_baglantisi().Close();
                MessageBox.Show("Kitap Geri Alındı.", "İşlem Yapıldı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand komutKitapDurumGuncelle = new SqlCommand("UPDATE kitaplar SET durum = 1 where KitapID = @k1", baglan.sql_baglantisi());
                komutKitapDurumGuncelle.Parameters.AddWithValue("@k1", txtKitapID.Text);
                komutKitapDurumGuncelle.ExecuteNonQuery();
                baglan.sql_baglantisi().Close();
                emanetler();
                kitaplar();
                temizle();
            }

        }

        private void txtOkuyucuAra_TextChanged(object sender, EventArgs e)
        {
            //OKUYUCU ARAMA ÖZELLİĞİ

            DataTable dataTableOkuyucuAra = new DataTable();
            SqlDataAdapter dataAdapterOkuyucuAra = new SqlDataAdapter("SELECT [okuyucuID] 'ID',[adi]+' '+[soyadi] 'AD SOYAD',[sinifi] + ' - ' + [okulno] 'SINIF - OKUL NO' FROM okuyucular where Aktif = 1 and adi like @k1", baglan.sql_baglantisi());
            dataAdapterOkuyucuAra.SelectCommand.Parameters.AddWithValue("@k1", "%" + txtOkuyucuAra.Text + "%");
            dataAdapterOkuyucuAra.Fill(dataTableOkuyucuAra);
            dataGridOkuyucular.DataSource = dataTableOkuyucuAra;
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            // KİTAP ARAMA ÖZELLİĞİ

            DataTable dataTableKitapAra = new DataTable();
            SqlDataAdapter dataAdapterKitapAra = new SqlDataAdapter("SELECT [KitapID] 'ID',[KitapAdi] 'KİTAP ADI',[YazarAdi] 'YAZAR ADI', [durum] 'DURUM' FROM kitaplar where Aktif = 1 and durum = 1 and KitapAdi like @k1", baglan.sql_baglantisi());
            dataAdapterKitapAra.SelectCommand.Parameters.AddWithValue("@k1", "%" + txtKitapAra.Text + "%");
            dataAdapterKitapAra.Fill(dataTableKitapAra);
            dataGridKitaplar.DataSource = dataTableKitapAra;
        }
    }
}
