
namespace Proje_HastaneOtomasyonu
{
    partial class Form_Brans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Brans));
            this.button_Güncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_BransAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_BransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Güncelle
            // 
            this.button_Güncelle.Location = new System.Drawing.Point(159, 207);
            this.button_Güncelle.Name = "button_Güncelle";
            this.button_Güncelle.Size = new System.Drawing.Size(258, 42);
            this.button_Güncelle.TabIndex = 5;
            this.button_Güncelle.Text = "Güncelle";
            this.button_Güncelle.UseVisualStyleBackColor = true;
            this.button_Güncelle.Click += new System.EventHandler(this.button_Güncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(303, 150);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(114, 42);
            this.button_Sil.TabIndex = 4;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(159, 150);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(114, 42);
            this.button_Ekle.TabIndex = 3;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 209);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_BransAd
            // 
            this.textBox_BransAd.Location = new System.Drawing.Point(159, 88);
            this.textBox_BransAd.Name = "textBox_BransAd";
            this.textBox_BransAd.Size = new System.Drawing.Size(258, 38);
            this.textBox_BransAd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Branş Ad :";
            // 
            // textBox_BransID
            // 
            this.textBox_BransID.Location = new System.Drawing.Point(159, 40);
            this.textBox_BransID.Name = "textBox_BransID";
            this.textBox_BransID.Size = new System.Drawing.Size(258, 38);
            this.textBox_BransID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Branş ID :";
            // 
            // Form_Brans
            // 
            this.AcceptButton = this.button_Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(914, 283);
            this.Controls.Add(this.button_Güncelle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_BransAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_BransID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form_Brans";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.Form_Brans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Güncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_BransAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_BransID;
        private System.Windows.Forms.Label label2;
    }
}