
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Doktor_Bilgi_Düzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Doktor_Bilgi_Düzenle));
            this.buttonKayitYap = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Brans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonKayitYap
            // 
            this.buttonKayitYap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKayitYap.Location = new System.Drawing.Point(257, 310);
            this.buttonKayitYap.Name = "buttonKayitYap";
            this.buttonKayitYap.Size = new System.Drawing.Size(204, 51);
            this.buttonKayitYap.TabIndex = 6;
            this.buttonKayitYap.Text = "Güncelle";
            this.buttonKayitYap.UseVisualStyleBackColor = false;
            this.buttonKayitYap.Click += new System.EventHandler(this.buttonKayitYap_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(257, 251);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(204, 36);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Şifre :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(257, 21);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(204, 36);
            this.textBoxAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ad :";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(257, 71);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(204, 36);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Soyad :";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(257, 188);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(204, 36);
            this.MaskedTC.TabIndex = 4;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Branş :";
            // 
            // comboBox_Brans
            // 
            this.comboBox_Brans.FormattingEnabled = true;
            this.comboBox_Brans.Location = new System.Drawing.Point(257, 125);
            this.comboBox_Brans.Name = "comboBox_Brans";
            this.comboBox_Brans.Size = new System.Drawing.Size(204, 36);
            this.comboBox_Brans.TabIndex = 3;
            // 
            // Form_Doktor_Bilgi_Düzenle
            // 
            this.AcceptButton = this.buttonKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(510, 403);
            this.Controls.Add(this.comboBox_Brans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKayitYap);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form_Doktor_Bilgi_Düzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.Form_Doktor_Bilgi_Düzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKayitYap;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Brans;
    }
}