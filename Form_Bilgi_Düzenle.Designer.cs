
using System;

namespace Proje_HastaneOtomasyonu
{
    partial class Form_Bilgi_Düzenle
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
            this.BilgileriGüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BilgileriGüncelle
            // 
            this.BilgileriGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BilgileriGüncelle.Location = new System.Drawing.Point(226, 361);
            this.BilgileriGüncelle.Name = "BilgileriGüncelle";
            this.BilgileriGüncelle.Size = new System.Drawing.Size(204, 51);
            this.BilgileriGüncelle.TabIndex = 31;
            this.BilgileriGüncelle.Text = "Bilgileri Güncelle";
            this.BilgileriGüncelle.UseVisualStyleBackColor = false;
            this.BilgileriGüncelle.Click += new System.EventHandler(this.BilgileriGüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet :";
            // 
            // ComboBox_Cinsiyet
            // 
            this.ComboBox_Cinsiyet.FormattingEnabled = true;
            this.ComboBox_Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.ComboBox_Cinsiyet.Location = new System.Drawing.Point(226, 300);
            this.ComboBox_Cinsiyet.Name = "ComboBox_Cinsiyet";
            this.ComboBox_Cinsiyet.Size = new System.Drawing.Size(204, 36);
            this.ComboBox_Cinsiyet.TabIndex = 6;
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(226, 199);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.Size = new System.Drawing.Size(204, 36);
            this.maskedTextTel.TabIndex = 4;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(226, 243);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(204, 36);
            this.textBoxSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Şifre :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(226, 56);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(204, 36);
            this.textBoxAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hasta Adı :";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(226, 101);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(204, 36);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hasta Soyadı :";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(226, 150);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(204, 36);
            this.MaskedTC.TabIndex = 3;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // HastaID
            // 
            this.HastaID.Enabled = false;
            this.HastaID.Location = new System.Drawing.Point(225, 14);
            this.HastaID.Name = "HastaID";
            this.HastaID.Size = new System.Drawing.Size(204, 36);
            this.HastaID.TabIndex = 32;
            this.HastaID.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hasta ID :";
            this.label7.Visible = false;
            // 
            // Form_Bilgi_Düzenle
            // 
            this.AcceptButton = this.BilgileriGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(464, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HastaID);
            this.Controls.Add(this.BilgileriGüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComboBox_Cinsiyet);
            this.Controls.Add(this.maskedTextTel);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Bilgi_Düzenle";
            this.Text = "Bilgileri Düzenle";
            this.Load += new System.EventHandler(this.Form_Bilgi_Düzenle_Load);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Button BilgileriGüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_Cinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HastaID;
        private System.Windows.Forms.Label label7;
    }
}