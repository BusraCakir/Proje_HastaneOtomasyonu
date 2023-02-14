
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Doktor_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Doktor_Giris));
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.TextBoxSifre = new System.Windows.Forms.TextBox();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(262, 269);
            this.buttonGirisYap.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(306, 55);
            this.buttonGirisYap.TabIndex = 3;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // TextBoxSifre
            // 
            this.TextBoxSifre.Location = new System.Drawing.Point(264, 214);
            this.TextBoxSifre.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxSifre.Name = "TextBoxSifre";
            this.TextBoxSifre.Size = new System.Drawing.Size(304, 36);
            this.TextBoxSifre.TabIndex = 2;
            this.TextBoxSifre.UseSystemPasswordChar = true;
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(264, 149);
            this.MaskedTC.Margin = new System.Windows.Forms.Padding(5);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(304, 36);
            this.MaskedTC.TabIndex = 1;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // Form_Doktor_Giris
            // 
            this.AcceptButton = this.buttonGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(593, 403);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.TextBoxSifre);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Doktor_Giris";
            this.Text = "Doktor Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.TextBox TextBoxSifre;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}