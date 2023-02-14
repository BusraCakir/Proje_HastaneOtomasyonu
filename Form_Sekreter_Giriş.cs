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
    public partial class Form_Sekreter_Giriş : Form
    {
        public Form_Sekreter_Giriş()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tabel_SekreterBilgi Where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskedTC.Text);
            komut.Parameters.AddWithValue("@p2", TextBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) //Okuma işleminin sorgulaması doğru mu diye bakıyoruz..
            {
                Form_Sekreter_Detay fr = new Form_Sekreter_Detay();
                fr.TCNumara = MaskedTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız !");
            }
            bgl.baglanti().Close();
        }
    }
}
