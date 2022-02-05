using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamasıSon
{
    public partial class frmMUSTERI : Form
    {
        public frmMUSTERI()
        {
            InitializeComponent();
        }
        //global
        DLL.MODELS.Musteri _musteri = new DLL.MODELS.Musteri();

        private void frmMUSTERI_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource= _musteri.MusteriListele();
        }

        public void MusteriEkle() 
        {
            txt_ad.Text = _musteri.adi;
            txt_soyad.Text = _musteri.soyadi;
            txt_TCNo.Text= _musteri.TCNo.ToString();
            lbl_pathBilgi.Text = _musteri.profilResimYolu;
            monthCalendar1.SelectionStart = _musteri.dogumTarihi;

            //string _hedefDosyaYolu = @"C:\Users\ISKUR\Desktop\FormUygulamasıSon\DLL\IMAGES\" + Path.GetFileName(lbl_pathBilgi.Text);
            //File.Copy(lbl_pathBilgi.Text, _hedefDosyaYolu);

            
            bool sonuc = _musteri.MusteriEkle(_musteri);

            if (sonuc == true)
            {
                MusteriListele();
            }
        }
        public void MusteriListele()
        {
            txt_ad.Text = _musteri.adi;
            txt_soyad.Text = _musteri.soyadi;
            txt_TCNo.Text = _musteri.TCNo.ToString();
            lbl_pathBilgi.Text = _musteri.profilResimYolu;
            monthCalendar1.SelectionStart = _musteri.dogumTarihi;
            _musteri.MusteriListele();
        }

        public void MusteriGuncelle()
        {
            lbl_idBilgi.Text = _musteri.id.ToString();
            txt_ad.Text = _musteri.adi;
            txt_soyad.Text = _musteri.soyadi;
            txt_TCNo.Text = _musteri.TCNo.ToString();
            lbl_pathBilgi.Text = _musteri.profilResimYolu;
            monthCalendar1.SelectionStart = _musteri.dogumTarihi;
            
            bool sonuc = _musteri.MusteriGuncelle(_musteri);

            if (sonuc == true)
            {
                MusteriListele();
            }
        }

        public void MusteriSil()
        {
            lbl_idBilgi.Text = _musteri.id.ToString();
            bool sonuc = _musteri.MusteriSil(_musteri);

            if (sonuc == true)
            {
                MusteriListele();
            }
        }
        public void MusteriAra()
        {
            txt_ara.Text = _musteri.aranacakDeger;
            _musteri.MusteriAra(_musteri);
            dataGridView1.DataSource = _musteri.MusteriAra(_musteri);

            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow _row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell _cell in _row.Cells)
                    {
                        if (_cell.Value.ToString().Contains(txt_ara.Text) == true)
                        {
                            _cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            _cell.Style.BackColor = Color.White;
                        }

                    }
                }
            }
        }
        public void ResimSec()
        {
            openFileDialog1.ShowDialog();
            lbl_pathBilgi.Text = openFileDialog1.FileName;
            string _hedefDosyaYolu = @"C:\Users\ISKUR\Desktop\FormUygulamasıSon\DLL\IMAGES\" + Path.GetFileName(lbl_pathBilgi.Text);
            File.Copy(lbl_pathBilgi.Text, _hedefDosyaYolu);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(_hedefDosyaYolu);
            pictureBox1.ImageLocation = _hedefDosyaYolu;
        }

        // form actions
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            MusteriEkle();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
        }        
       
        private void btn_ara_Click(object sender, EventArgs e)
        {
            MusteriAra();
        }
        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_idBilgi.Text= dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            txt_ad.Text = dataGridView1.SelectedRows[0].Cells["adi"].Value.ToString();
            txt_soyad.Text = dataGridView1.SelectedRows[0].Cells["soyadi"].Value.ToString();
            txt_TCNo.Text = dataGridView1.SelectedRows[0].Cells["TCNo"].Value.ToString();
            //monthCalendar1.SelectionStart = dataGridView1.SelectedRows[0].Cells["dogumTarihi"].Value.ToString();
            //lbl_pathBilgi.Text = dataGridView1.SelectedRows[0].Cells["profilResimYolu"].Value.ToString();
        }
    }
}
