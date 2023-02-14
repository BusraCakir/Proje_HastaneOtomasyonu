
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Girisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Girisler));
            this.button_HastaGirisi = new System.Windows.Forms.Button();
            this.button_DoktorGirisi = new System.Windows.Forms.Button();
            this.button_SekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_HastaGirisi
            // 
            this.button_HastaGirisi.BackColor = System.Drawing.Color.White;
            this.button_HastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HastaGirisi.BackgroundImage")));
            this.button_HastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_HastaGirisi.Location = new System.Drawing.Point(18, 402);
            this.button_HastaGirisi.Name = "button_HastaGirisi";
            this.button_HastaGirisi.Size = new System.Drawing.Size(271, 232);
            this.button_HastaGirisi.TabIndex = 0;
            this.button_HastaGirisi.UseVisualStyleBackColor = false;
            this.button_HastaGirisi.Click += new System.EventHandler(this.button_HastaGirisi_Click);
            // 
            // button_DoktorGirisi
            // 
            this.button_DoktorGirisi.BackColor = System.Drawing.Color.White;
            this.button_DoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_DoktorGirisi.BackgroundImage")));
            this.button_DoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DoktorGirisi.Location = new System.Drawing.Point(373, 402);
            this.button_DoktorGirisi.Name = "button_DoktorGirisi";
            this.button_DoktorGirisi.Size = new System.Drawing.Size(271, 232);
            this.button_DoktorGirisi.TabIndex = 1;
            this.button_DoktorGirisi.UseVisualStyleBackColor = false;
            this.button_DoktorGirisi.Click += new System.EventHandler(this.button_DoktorGirisi_Click);
            // 
            // button_SekreterGirisi
            // 
            this.button_SekreterGirisi.BackColor = System.Drawing.Color.White;
            this.button_SekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SekreterGirisi.BackgroundImage")));
            this.button_SekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SekreterGirisi.Location = new System.Drawing.Point(716, 402);
            this.button_SekreterGirisi.Name = "button_SekreterGirisi";
            this.button_SekreterGirisi.Size = new System.Drawing.Size(271, 232);
            this.button_SekreterGirisi.TabIndex = 2;
            this.button_SekreterGirisi.UseVisualStyleBackColor = false;
            this.button_SekreterGirisi.Click += new System.EventHandler(this.button_SekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(969, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(-6, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(993, 140);
            this.label4.TabIndex = 7;
            this.label4.Text = "BAYINDIR HASTANESİ";
            // 
            // Form_Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1023, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SekreterGirisi);
            this.Controls.Add(this.button_DoktorGirisi);
            this.Controls.Add(this.button_HastaGirisi);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Girisler";
            this.Text = "BAYINDIR HASTANESİNE HOŞ GELDİNİZ ! SAĞLIKLA KALIN :)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_HastaGirisi;
        private System.Windows.Forms.Button button_DoktorGirisi;
        private System.Windows.Forms.Button button_SekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

