
namespace Proje_HastaneOtomasyonu
{
    partial class Form_DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DoktorPaneli));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Brans = new System.Windows.Forms.ComboBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.maskedTextBox_TC = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Güncelle = new System.Windows.Forms.Button();
            this.textBox_DoktorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad :";
            // 
            // comboBox_Brans
            // 
            this.comboBox_Brans.FormattingEnabled = true;
            this.comboBox_Brans.Location = new System.Drawing.Point(264, 192);
            this.comboBox_Brans.Name = "comboBox_Brans";
            this.comboBox_Brans.Size = new System.Drawing.Size(258, 39);
            this.comboBox_Brans.TabIndex = 3;
            //this.comboBox_Brans.SelectedIndexChanged += new System.EventHandler(this.comboBox_Brans_SelectedIndexChanged);
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(264, 97);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(258, 38);
            this.textBox_Ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Branş :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "T.C. Kimlik Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soyad :";
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(264, 145);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(258, 38);
            this.textBox_Soyad.TabIndex = 2;
            // 
            // maskedTextBox_TC
            // 
            this.maskedTextBox_TC.Location = new System.Drawing.Point(264, 247);
            this.maskedTextBox_TC.Mask = "00000000000";
            this.maskedTextBox_TC.Name = "maskedTextBox_TC";
            this.maskedTextBox_TC.Size = new System.Drawing.Size(258, 38);
            this.maskedTextBox_TC.TabIndex = 4;
            this.maskedTextBox_TC.ValidatingType = typeof(int);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(264, 296);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '*';
            this.textBox_Sifre.Size = new System.Drawing.Size(258, 38);
            this.textBox_Sifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 236);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(264, 349);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(114, 42);
            this.button_Ekle.TabIndex = 6;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(408, 349);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(114, 42);
            this.button_Sil.TabIndex = 7;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click_1);
            // 
            // button_Güncelle
            // 
            this.button_Güncelle.Location = new System.Drawing.Point(264, 397);
            this.button_Güncelle.Name = "button_Güncelle";
            this.button_Güncelle.Size = new System.Drawing.Size(258, 42);
            this.button_Güncelle.TabIndex = 8;
            this.button_Güncelle.Text = "Güncelle";
            this.button_Güncelle.UseVisualStyleBackColor = true;
            this.button_Güncelle.Click += new System.EventHandler(this.button_Güncelle_Click);
            // 
            // textBox_DoktorID
            // 
            this.textBox_DoktorID.Location = new System.Drawing.Point(264, 53);
            this.textBox_DoktorID.Name = "textBox_DoktorID";
            this.textBox_DoktorID.Size = new System.Drawing.Size(258, 38);
            this.textBox_DoktorID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "DoktorID :";
            // 
            // Form_DoktorPaneli
            // 
            this.AcceptButton = this.button_Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1129, 481);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_DoktorID);
            this.Controls.Add(this.button_Güncelle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.maskedTextBox_TC);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Brans);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form_DoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.Form_DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Brans;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_TC;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Güncelle;
        private System.Windows.Forms.TextBox textBox_DoktorID;
        private System.Windows.Forms.Label label6;
    }
}