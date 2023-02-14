using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Proje_HastaneOtomasyonu
{
    public partial class Form_Brans : Form
    {
        public Form_Brans()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void Form_Brans_Load(object sender, EventArgs e)
        {
            bransGetir();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand bransekle = new SqlCommand("Insert into Tabel_Branslar (BransAd) values (@bransekle)", bgl.baglanti());
            bransekle.Parameters.AddWithValue("@bransekle", textBox_BransAd.Text);
            bransekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Branş sisteme eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransGetir();
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenhucre = dataGridView1.SelectedCells[0].RowIndex;
            textBox_BransID.Text = dataGridView1.Rows[secilenhucre].Cells[0].Value.ToString();
            textBox_BransAd.Text = dataGridView1.Rows[secilenhucre].Cells[1].Value.ToString();
            
        }


        private void button_Sil_Click(object sender, EventArgs e)
        {
            
                SqlCommand branssil = new SqlCommand("DELETE FROM Tabel_Branslar WHERE BransID = @b1", bgl.baglanti());
                branssil.Parameters.AddWithValue("@b1", textBox_BransID.Text);
                branssil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Branş sistemden silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bransGetir();

        }

        public void bransGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tabel_Branslar Order by BransID ASC", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update Tabel_Branslar set  BransAd=@d2 where BransID=@d1", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@d1", textBox_BransID.Text);
            guncelle.Parameters.AddWithValue("@d2", textBox_BransAd.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş bilgileri güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransGetir();
        }
    }
}
