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
    public partial class Form_Hasta_Detay : Form
    {
        public Form_Hasta_Detay()
        {
            InitializeComponent();
        }
        public string TC;

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Form_Hasta_Detay_Load(object sender, EventArgs e)
        {
            label_TC.Text = TC;

            //HAsta Detay ekranına Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select HastaAdi,HastaSoyad From Tabel_HastaBilgi Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) //while direk listelemek için kullanılıyor..
            {
                label_AdSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            //Randevu geçmişi çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Randevular Where HastaTC=" + TC, bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tabel_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_Brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }



        private void comboBox_Brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Doktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tabel_DoktorBilgi Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox_Brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox_Doktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();

        }

        private void comboBox_Doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Randevular Where RandevuBrans='" + comboBox_Brans.Text + "'" + " and RandevuDoktor='" + comboBox_Doktor.Text + "' and RandevuDurum=0 order by RandevuTarih ", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void linkLabel_BilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Bilgi_Düzenle fr = new Form_Bilgi_Düzenle();
            fr.tcno = label_TC.Text;
            fr.Show(); 

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenhucre = dataGridView2.SelectedCells[0].RowIndex;
            textBox_RandevuID.Text = dataGridView2.Rows[secilenhucre].Cells[0].Value.ToString();
            
        }

        private void button_RandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand RandevuAl = new SqlCommand("update Tabel_Randevular set  RandevuDurum=1, HastaTC=@r1,HastaSikayet=@r2 where RandevuID=@r3", bgl.baglanti());
            RandevuAl.Parameters.AddWithValue("@r1", label_TC.Text);
            RandevuAl.Parameters.AddWithValue("@r2", richTextBox_Sikayet.Text);
            RandevuAl.Parameters.AddWithValue("@r3", textBox_RandevuID.Text);
            RandevuAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
