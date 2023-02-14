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
    public partial class Form_Doktor_Bilgi_Düzenle : Form
    {
        public Form_Doktor_Bilgi_Düzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TC;
        private void Form_Doktor_Bilgi_Düzenle_Load(object sender, EventArgs e)
        {
            MaskedTC.Text = TC;

            SqlCommand komut = new SqlCommand("Select * From Tabel_DoktorBilgi Where DoktorTC=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) //while direk listelemek için kullanılıyor.. (if sadece girişlerde parametreler eşit mi diye kontrol ediyor.)
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                comboBox_Brans.Text = dr[3].ToString();
                textBoxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }

        private void buttonKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand doktorguncelle = new SqlCommand("update Tabel_DoktorBilgi set  DoktorAd=@d1, DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d4 where DoktorTC=@d5", bgl.baglanti());
            doktorguncelle.Parameters.AddWithValue("@d1", textBoxAd.Text);
            doktorguncelle.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            doktorguncelle.Parameters.AddWithValue("@d3", comboBox_Brans.Text);
            doktorguncelle.Parameters.AddWithValue("@d4", textBoxSifre.Text);
            doktorguncelle.Parameters.AddWithValue("@d5", MaskedTC.Text);
            doktorguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
