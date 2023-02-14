
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Hasta_Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hasta_Kayit));
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(230, 145);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(204, 32);
            this.MaskedTC.TabIndex = 3;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(230, 96);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(204, 32);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hasta Soyadı :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(230, 51);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(204, 32);
            this.textBoxAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta Adı :";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(230, 238);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(204, 32);
            this.textBoxSifre.TabIndex = 5;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Şifre :";
            // 
            // maskedTextTel
            // 
            this.maskedTextTel.Location = new System.Drawing.Point(230, 194);
            this.maskedTextTel.Mask = "(999) 000-0000";
            this.maskedTextTel.Name = "maskedTextTel";
            this.maskedTextTel.Size = new System.Drawing.Size(204, 32);
            this.maskedTextTel.TabIndex = 4;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(230, 295);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(204, 32);
            this.comboBoxCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet :";
            // 
            // buttonKayitYap
            // 
            this.buttonKayitYap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKayitYap.Location = new System.Drawing.Point(230, 356);
            this.buttonKayitYap.Name = "buttonKayitYap";
            this.buttonKayitYap.Size = new System.Drawing.Size(204, 37);
            this.buttonKayitYap.TabIndex = 18;
            this.buttonKayitYap.Text = "Kayıt Yap";
            this.buttonKayitYap.UseVisualStyleBackColor = false;
            this.buttonKayitYap.Click += new System.EventHandler(this.buttonKayitYap_Click);
            // 
            // Form_Hasta_Kayit
            // 
            this.AcceptButton = this.buttonKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(491, 466);
            this.Controls.Add(this.buttonKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCinsiyet);
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
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Hasta_Kayit";
            this.Text = "Hasta Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextTel;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKayitYap;
    }
}