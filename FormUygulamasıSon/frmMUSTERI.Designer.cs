namespace FormUygulamasıSon
{
    partial class frmMUSTERI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_dogumTarihi = new System.Windows.Forms.Label();
            this.lbl_TCNo = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_TCNo = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.lbl_ara = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.lbl_pathBilgi = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_idBilgi = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(675, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.Location = new System.Drawing.Point(26, 43);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(22, 13);
            this.lbl_adi.TabIndex = 1;
            this.lbl_adi.Text = "Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 251);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Location = new System.Drawing.Point(26, 107);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(39, 13);
            this.lbl_soyadi.TabIndex = 3;
            this.lbl_soyadi.Text = "Soyadı";
            // 
            // lbl_dogumTarihi
            // 
            this.lbl_dogumTarihi.AutoSize = true;
            this.lbl_dogumTarihi.Location = new System.Drawing.Point(304, 22);
            this.lbl_dogumTarihi.Name = "lbl_dogumTarihi";
            this.lbl_dogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lbl_dogumTarihi.TabIndex = 4;
            this.lbl_dogumTarihi.Text = "Doğum Tarihi";
            // 
            // lbl_TCNo
            // 
            this.lbl_TCNo.AutoSize = true;
            this.lbl_TCNo.Location = new System.Drawing.Point(26, 72);
            this.lbl_TCNo.Name = "lbl_TCNo";
            this.lbl_TCNo.Size = new System.Drawing.Size(35, 13);
            this.lbl_TCNo.TabIndex = 5;
            this.lbl_TCNo.Text = "TCNo";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(26, 136);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(29, 13);
            this.lbl_path.TabIndex = 6;
            this.lbl_path.Text = "Path";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(121, 40);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(147, 20);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(121, 104);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(147, 20);
            this.txt_soyad.TabIndex = 8;
            // 
            // txt_TCNo
            // 
            this.txt_TCNo.Location = new System.Drawing.Point(121, 72);
            this.txt_TCNo.Name = "txt_TCNo";
            this.txt_TCNo.Size = new System.Drawing.Size(147, 20);
            this.txt_TCNo.TabIndex = 9;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(130, 252);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(232, 252);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(29, 252);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 14;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(342, 252);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(628, 252);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 17;
            // 
            // lbl_ara
            // 
            this.lbl_ara.AutoSize = true;
            this.lbl_ara.Location = new System.Drawing.Point(533, 252);
            this.lbl_ara.Name = "lbl_ara";
            this.lbl_ara.Size = new System.Drawing.Size(60, 13);
            this.lbl_ara.TabIndex = 16;
            this.lbl_ara.Text = "Müşteri Ara";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(750, 252);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 18;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // lbl_pathBilgi
            // 
            this.lbl_pathBilgi.AutoSize = true;
            this.lbl_pathBilgi.Location = new System.Drawing.Point(118, 136);
            this.lbl_pathBilgi.Name = "lbl_pathBilgi";
            this.lbl_pathBilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_pathBilgi.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(675, 171);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(150, 23);
            this.btn_resimSec.TabIndex = 20;
            this.btn_resimSec.Text = "Resim Seç";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(397, 22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            // 
            // lbl_idBilgi
            // 
            this.lbl_idBilgi.AutoSize = true;
            this.lbl_idBilgi.Location = new System.Drawing.Point(127, 19);
            this.lbl_idBilgi.Name = "lbl_idBilgi";
            this.lbl_idBilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_idBilgi.TabIndex = 23;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(26, 19);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 22;
            this.lbl_id.Text = "ID";
            // 
            // frmMUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 558);
            this.Controls.Add(this.lbl_idBilgi);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_resimSec);
            this.Controls.Add(this.lbl_pathBilgi);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.lbl_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_TCNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lbl_TCNo);
            this.Controls.Add(this.lbl_dogumTarihi);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_adi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMUSTERI";
            this.Text = "MUSTERI";
            this.Load += new System.EventHandler(this.frmMUSTERI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_dogumTarihi;
        private System.Windows.Forms.Label lbl_TCNo;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_TCNo;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label lbl_ara;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label lbl_pathBilgi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_idBilgi;
        private System.Windows.Forms.Label lbl_id;
    }
}

