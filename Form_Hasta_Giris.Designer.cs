
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Hasta_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hasta_Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxSifre = new System.Windows.Forms.TextBox();
            this.linkLabelÜyeOl = new System.Windows.Forms.LinkLabel();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(307, 142);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(204, 36);
            this.MaskedTC.TabIndex = 1;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // TextBoxSifre
            // 
            this.TextBoxSifre.Location = new System.Drawing.Point(307, 208);
            this.TextBoxSifre.Name = "TextBoxSifre";
            this.TextBoxSifre.Size = new System.Drawing.Size(204, 36);
            this.TextBoxSifre.TabIndex = 2;
            this.TextBoxSifre.UseSystemPasswordChar = true;
            // 
            // linkLabelÜyeOl
            // 
            this.linkLabelÜyeOl.AutoSize = true;
            this.linkLabelÜyeOl.Location = new System.Drawing.Point(361, 354);
            this.linkLabelÜyeOl.Name = "linkLabelÜyeOl";
            this.linkLabelÜyeOl.Size = new System.Drawing.Size(81, 29);
            this.linkLabelÜyeOl.TabIndex = 5;
            this.linkLabelÜyeOl.TabStop = true;
            this.linkLabelÜyeOl.Text = "Üye Ol";
            this.linkLabelÜyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelÜyeOl_LinkClicked);
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(307, 281);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(204, 36);
            this.buttonGirisYap.TabIndex = 6;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // Form_Hasta_Giris
            // 
            this.AcceptButton = this.buttonGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(593, 403);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.linkLabelÜyeOl);
            this.Controls.Add(this.TextBoxSifre);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Hasta_Giris";
            this.Text = "Hasta Girişi";
            this.Load += new System.EventHandler(this.Form_Hasta_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.TextBox TextBoxSifre;
        private System.Windows.Forms.LinkLabel linkLabelÜyeOl;
        private System.Windows.Forms.Button buttonGirisYap;
    }
}