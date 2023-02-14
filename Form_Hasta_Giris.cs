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
    public partial class Form_Hasta_Giris : Form
    {
        public Form_Hasta_Giris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void linkLabelÜyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Hasta_Kayit frm = new Form_Hasta_Kayit();
            frm.Show();

        }
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tabel_HastaBilgi Where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskedTC.Text);
            komut.Parameters.AddWithValue("@p2", TextBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form_Hasta_Detay fr = new Form_Hasta_Detay();
                fr.TC = MaskedTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre girdiniz. Lütfen tekrar kontrol ediniz..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }

        private void Form_Hasta_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
