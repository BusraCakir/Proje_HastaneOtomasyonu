
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Doktor_Detay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Doktor_Detay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Sikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Duyurular = new System.Windows.Forms.Button();
            this.button_Çıkış = new System.Windows.Forms.Button();
            this.button_BilgiDüzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_AdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_TC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Location = new System.Drawing.Point(209, 120);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(100, 29);
            this.label_AdSoyad.TabIndex = 3;
            this.label_AdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı Soyadı :";
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Location = new System.Drawing.Point(209, 67);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(145, 29);
            this.label_TC.TabIndex = 1;
            this.label_TC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_Sikayet);
            this.groupBox2.Location = new System.Drawing.Point(13, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // richTextBox_Sikayet
            // 
            this.richTextBox_Sikayet.Location = new System.Drawing.Point(6, 35);
            this.richTextBox_Sikayet.Name = "richTextBox_Sikayet";
            this.richTextBox_Sikayet.Size = new System.Drawing.Size(348, 286);
            this.richTextBox_Sikayet.TabIndex = 1;
            this.richTextBox_Sikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(397, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 710);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Liste ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 675);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Duyurular);
            this.groupBox4.Controls.Add(this.button_Çıkış);
            this.groupBox4.Controls.Add(this.button_BilgiDüzenle);
            this.groupBox4.Location = new System.Drawing.Point(13, 554);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Giriş";
            // 
            // button_Duyurular
            // 
            this.button_Duyurular.Location = new System.Drawing.Point(193, 49);
            this.button_Duyurular.Name = "button_Duyurular";
            this.button_Duyurular.Size = new System.Drawing.Size(161, 41);
            this.button_Duyurular.TabIndex = 3;
            this.button_Duyurular.Text = "Duyurular";
            this.button_Duyurular.UseVisualStyleBackColor = true;
            this.button_Duyurular.Click += new System.EventHandler(this.button_Duyurular_Click);
            // 
            // button_Çıkış
            // 
            this.button_Çıkış.Location = new System.Drawing.Point(6, 106);
            this.button_Çıkış.Name = "button_Çıkış";
            this.button_Çıkış.Size = new System.Drawing.Size(348, 41);
            this.button_Çıkış.TabIndex = 5;
            this.button_Çıkış.Text = "Çıkış";
            this.button_Çıkış.UseVisualStyleBackColor = true;
            this.button_Çıkış.Click += new System.EventHandler(this.button_Çıkış_Click);
            // 
            // button_BilgiDüzenle
            // 
            this.button_BilgiDüzenle.Location = new System.Drawing.Point(6, 49);
            this.button_BilgiDüzenle.Name = "button_BilgiDüzenle";
            this.button_BilgiDüzenle.Size = new System.Drawing.Size(161, 41);
            this.button_BilgiDüzenle.TabIndex = 2;
            this.button_BilgiDüzenle.Text = "Bilgi Düzenle";
            this.button_BilgiDüzenle.UseVisualStyleBackColor = true;
            this.button_BilgiDüzenle.Click += new System.EventHandler(this.button_BilgiDüzenle_Click);
            // 
            // Form_Doktor_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1105, 737);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Doktor_Detay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.Form_Doktor_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox_Sikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Duyurular;
        private System.Windows.Forms.Button button_Çıkış;
        private System.Windows.Forms.Button button_BilgiDüzenle;
    }
}