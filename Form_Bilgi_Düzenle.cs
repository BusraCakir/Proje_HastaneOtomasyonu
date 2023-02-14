using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proje_HastaneOtomasyonu
{
    public partial class Form_Bilgi_Düzenle : Form
    {
        public Form_Bilgi_Düzenle()
        {
            InitializeComponent();
            //this.FormClosed += Form_Bilgi_Düzenle_OnClosed;
        }

        public string tcno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Form_Bilgi_Düzenle_Load(object sender, EventArgs e)
        {
            MaskedTC.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Tabel_HastaBilgi Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MaskedTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                HastaID.Text = dr[0].ToString();
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                maskedTextTel.Text = dr[4].ToString();
                textBoxSifre.Text = dr[5].ToString();
                ComboBox_Cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        //private void Form_Bilgi_Düzenle_OnClosed(object sender, EventArgs e)
        //{
        //    Form_Hasta_Detay fr = new Form_Hasta_Detay();
        //    fr.hastaBilgiGuncelle();
        //}

        private void BilgileriGüncelle_Click(object sender, EventArgs e)
        {     
            SqlCommand komut2 = new SqlCommand("update Tabel_HastaBilgi set HastaAdi=@p1,HastaSoyad=@p2,HastaTC=@p3,HastaTelefon=@p4,HastaSifre=@p5,HastaCinsiyet=@p6 Where HastaID=@p7", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MaskedTC.Text);
            komut2.Parameters.AddWithValue("@p4", maskedTextTel.Text);
            komut2.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p6", ComboBox_Cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p7", HastaID.Text); 
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
