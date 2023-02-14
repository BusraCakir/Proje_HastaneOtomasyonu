
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Hasta_Detay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hasta_Detay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_RandevuID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_BilgiDüzenle = new System.Windows.Forms.LinkLabel();
            this.button_RandevuAl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_Sikayet = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Doktor = new System.Windows.Forms.ComboBox();
            this.comboBox_Brans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label_AdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_TC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri :";
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Location = new System.Drawing.Point(205, 98);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(82, 24);
            this.label_AdSoyad.TabIndex = 13;
            this.label_AdSoyad.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hasta Ad Soyad :";
            // 
            // label_TC
            // 
            this.label_TC.AutoSize = true;
            this.label_TC.Location = new System.Drawing.Point(205, 60);
            this.label_TC.Name = "label_TC";
            this.label_TC.Size = new System.Drawing.Size(120, 24);
            this.label_TC.TabIndex = 13;
            this.label_TC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.textBox_RandevuID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel_BilgiDüzenle);
            this.groupBox2.Controls.Add(this.button_RandevuAl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.richTextBox_Sikayet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_Doktor);
            this.groupBox2.Controls.Add(this.comboBox_Brans);
            this.groupBox2.Location = new System.Drawing.Point(10, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli : ";
            // 
            // textBox_RandevuID
            // 
            this.textBox_RandevuID.Enabled = false;
            this.textBox_RandevuID.Location = new System.Drawing.Point(119, 60);
            this.textBox_RandevuID.Name = "textBox_RandevuID";
            this.textBox_RandevuID.Size = new System.Drawing.Size(225, 32);
            this.textBox_RandevuID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Randevu ID :";
            // 
            // linkLabel_BilgiDüzenle
            // 
            this.linkLabel_BilgiDüzenle.AutoSize = true;
            this.linkLabel_BilgiDüzenle.Location = new System.Drawing.Point(10, 510);
            this.linkLabel_BilgiDüzenle.Name = "linkLabel_BilgiDüzenle";
            this.linkLabel_BilgiDüzenle.Size = new System.Drawing.Size(147, 24);
            this.linkLabel_BilgiDüzenle.TabIndex = 7;
            this.linkLabel_BilgiDüzenle.TabStop = true;
            this.linkLabel_BilgiDüzenle.Text = "Bilgileri Düzenle";
            this.linkLabel_BilgiDüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BilgiDüzenle_LinkClicked);
            // 
            // button_RandevuAl
            // 
            this.button_RandevuAl.Location = new System.Drawing.Point(119, 443);
            this.button_RandevuAl.Name = "button_RandevuAl";
            this.button_RandevuAl.Size = new System.Drawing.Size(225, 42);
            this.button_RandevuAl.TabIndex = 3;
            this.button_RandevuAl.Text = "Randevu Al";
            this.button_RandevuAl.UseVisualStyleBackColor = true;
            this.button_RandevuAl.Click += new System.EventHandler(this.button_RandevuAl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şikayet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doktor :";
            // 
            // richTextBox_Sikayet
            // 
            this.richTextBox_Sikayet.Location = new System.Drawing.Point(119, 237);
            this.richTextBox_Sikayet.Name = "richTextBox_Sikayet";
            this.richTextBox_Sikayet.Size = new System.Drawing.Size(225, 188);
            this.richTextBox_Sikayet.TabIndex = 4;
            this.richTextBox_Sikayet.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branş :";
            // 
            // comboBox_Doktor
            // 
            this.comboBox_Doktor.FormattingEnabled = true;
            this.comboBox_Doktor.Location = new System.Drawing.Point(119, 176);
            this.comboBox_Doktor.Name = "comboBox_Doktor";
            this.comboBox_Doktor.Size = new System.Drawing.Size(225, 32);
            this.comboBox_Doktor.TabIndex = 3;
            this.comboBox_Doktor.SelectedIndexChanged += new System.EventHandler(this.comboBox_Doktor_SelectedIndexChanged);
            // 
            // comboBox_Brans
            // 
            this.comboBox_Brans.FormattingEnabled = true;
            this.comboBox_Brans.Location = new System.Drawing.Point(119, 114);
            this.comboBox_Brans.Name = "comboBox_Brans";
            this.comboBox_Brans.Size = new System.Drawing.Size(225, 32);
            this.comboBox_Brans.TabIndex = 2;
            this.comboBox_Brans.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(366, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 410);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Lavender;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(366, 436);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(712, 282);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Form_Hasta_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1105, 761);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Hasta_Detay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.Form_Hasta_Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Doktor;
        private System.Windows.Forms.ComboBox comboBox_Brans;
        private System.Windows.Forms.RichTextBox richTextBox_Sikayet;
        private System.Windows.Forms.Button button_RandevuAl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel_BilgiDüzenle;
        private System.Windows.Forms.TextBox textBox_RandevuID;
        private System.Windows.Forms.Label label1;
    }
}