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

namespace Proje_HastaneOtomasyonu
{
    public partial class Form_Sekreter_Detay : Form
    {
        public Form_Sekreter_Detay()
        {
            InitializeComponent();
        }

        public string TCNumara;
        
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Form_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            label_TC.Text = TCNumara;
            
            //Ad Soyad 

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tabel_SekreterBilgi Where  SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label_AdSoyad.Text = dr[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları datagride aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları datagride aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+ ' '+ DoktorSoyad) as 'Doktor', DoktorBrans From Tabel_DoktorBilgi", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransları Comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tabel_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_Brans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into Tabel_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTextBox_Tarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", maskedTextBox_Saat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBox_Brans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", comboBox_Doktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz tanımlanmıştır.");
        }

        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tabel_DoktorBilgi Where DoktorBrans=@dr1", bgl.baglanti());
            komut.Parameters.AddWithValue("@dr1", comboBox_Brans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox_Doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button_DuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tabel_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RichTextBox_Duyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void button_Doktor_Click(object sender, EventArgs e)
        {
            Form_DoktorPaneli drp = new Form_DoktorPaneli();
            drp.Show();
        }

        private void button_Brans_Click(object sender, EventArgs e)
        {
            Form_Brans frb = new Form_Brans();
            frb.Show();
        }

        private void button_Randevu_Click(object sender, EventArgs e)
        {
            Form_RandevuListesi frb = new Form_RandevuListesi();
            frb.Show();
        }

        private void button_Duyurular_Click(object sender, EventArgs e)
        {
            Form_Duyurular frb = new Form_Duyurular();
            frb.Show();
        }
    }
}
