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
    public partial class Form_Doktor_Detay : Form
    {
        public Form_Doktor_Detay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TC;
        private void Form_Doktor_Detay_Load(object sender, EventArgs e)
        {
            label_TC.Text = TC;

            //Doktor Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tabel_DoktorBilgi Where DoktorTC=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) //while direk listelemek için kullanılıyor.. (if sadece girişlerde parametreler eşit mi diye kontrol ediyor.)
            {
                label_AdSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            //Randevuları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Randevular Where RandevuDoktor='"+ label_AdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları çekme
            //SqlCommand komut2 = new SqlCommand("Select BransAd From Tabel_Branslar", bgl.baglanti());
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{
            //    combobox_.Items.Add(dr2[0]);
            //}
            //bgl.baglanti().Close();
        }

        private void button_BilgiDüzenle_Click(object sender, EventArgs e)
        {
            Form_Doktor_Bilgi_Düzenle frm = new Form_Doktor_Bilgi_Düzenle();
            frm.TC = label_TC.Text;
            frm.Show();
        }

        private void button_Duyurular_Click(object sender, EventArgs e)
        {
            Form_Duyurular frm = new Form_Duyurular();
            frm.Show();
        }

        private void button_Çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenhucre = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox_Sikayet.Text = dataGridView1.Rows[secilenhucre].Cells[7].Value.ToString();
        }
    }
}
