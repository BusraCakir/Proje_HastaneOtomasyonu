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
    public partial class Form_Doktor_Giris : Form
    {
        public Form_Doktor_Giris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tabel_DoktorBilgi Where DoktorTC=@d1 and DoktorSifre=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", MaskedTC.Text);
            komut.Parameters.AddWithValue("@d2", TextBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form_Doktor_Detay fr = new Form_Doktor_Detay();
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

        
    }
}
