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
    public partial class Form_Hasta_Kayit : Form
    {
        public Form_Hasta_Kayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void buttonKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tabel_HastaBilgi (HastaAdi,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTC.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextTel.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir." , "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';

        }
    }
}
