using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_HastaneOtomasyonu
{
    public partial class Form_Girisler : Form
    {
        public Form_Girisler()
        {
            InitializeComponent();
        }

        private void button_HastaGirisi_Click(object sender, EventArgs e)
        {
            Form_Hasta_Giris frm = new Form_Hasta_Giris();
            frm.Show();
            this.Hide();
        }

        private void button_DoktorGirisi_Click(object sender, EventArgs e)
        {
            Form_Doktor_Giris frm = new Form_Doktor_Giris();
            frm.Show();
            this.Hide();

        }

        private void button_SekreterGirisi_Click(object sender, EventArgs e)
        {
            Form_Sekreter_Giriş frm = new Form_Sekreter_Giriş();
            frm.Show();
            this.Hide();

        }
    }
}
