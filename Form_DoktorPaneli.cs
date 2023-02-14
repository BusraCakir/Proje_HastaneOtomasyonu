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
    public partial class Form_DoktorPaneli : Form
    {
        public Form_DoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Form_DoktorPaneli_Load(object sender, EventArgs e)
        {
            refresh();

            //Branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tabel_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_Brans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand doktorekle = new SqlCommand("Insert into Tabel_DoktorBilgi (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            doktorekle.Parameters.AddWithValue("@d1", textBox_Ad.Text);
            doktorekle.Parameters.AddWithValue("@d2", textBox_Soyad.Text);
            doktorekle.Parameters.AddWithValue("@d3", comboBox_Brans.Text);
            doktorekle.Parameters.AddWithValue("@d4", maskedTextBox_TC.Text);
            doktorekle.Parameters.AddWithValue("@d5", textBox_Sifre.Text);

            doktorekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Doktor sisteme eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenhucre = dataGridView1.SelectedCells[0].RowIndex;
            textBox_DoktorID.Text = dataGridView1.Rows[secilenhucre].Cells[0].Value.ToString();
            textBox_Ad.Text = dataGridView1.Rows[secilenhucre].Cells[1].Value.ToString();
            textBox_Soyad.Text = dataGridView1.Rows[secilenhucre].Cells[2].Value.ToString();
            comboBox_Brans.Text = dataGridView1.Rows[secilenhucre].Cells[3].Value.ToString();
            maskedTextBox_TC.Text = dataGridView1.Rows[secilenhucre].Cells[4].Value.ToString();
            textBox_Sifre.Text = dataGridView1.Rows[secilenhucre].Cells[5].Value.ToString();
        }
        private void button_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Tabel_DoktorBilgi set  DoktorAd=@d2,DoktorSoyad=@d3,DoktorBrans=@d4,DoktorTC=@d5,DoktorSifre=@d6 where DoktorID=@d1", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@d1", textBox_DoktorID.Text);
            guncelle.Parameters.AddWithValue("@d2", textBox_Ad.Text);
            guncelle.Parameters.AddWithValue("@d3", textBox_Soyad.Text);
            guncelle.Parameters.AddWithValue("@d4", comboBox_Brans.Text);
            guncelle.Parameters.AddWithValue("@d5", maskedTextBox_TC.Text);
            guncelle.Parameters.AddWithValue("@d6", textBox_Sifre.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor bilgileri güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

        public void refresh()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tabel_DoktorBilgi Order by DoktorID ASC", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void button_Sil_Click_1(object sender, EventArgs e)
        {
            SqlCommand doktorsil = new SqlCommand("DELETE FROM Tabel_DoktorBilgi WHERE DoktorID = @d1", bgl.baglanti());
            doktorsil.Parameters.AddWithValue("@d1", textBox_DoktorID.Text);
            doktorsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor sistemden silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            refresh();
        }
    }
}
