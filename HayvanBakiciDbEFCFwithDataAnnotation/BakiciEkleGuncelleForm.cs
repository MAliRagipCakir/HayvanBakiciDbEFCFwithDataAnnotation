using HayvanBakiciDbEFCFwithDataAnnotation.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanBakiciDbEFCFwithDataAnnotation
{
    public partial class BakiciEkleGuncelleForm : Form
    {
        private readonly HayvanBakiciDbContext db;
        private readonly Bakici bakici;
        public List<Hayvan> BaktigiHayvanlar;

        public BakiciEkleGuncelleForm(HayvanBakiciDbContext db, Bakici bakici)
        {
            this.db = db;
            this.bakici = bakici;
            InitializeComponent();
            BakiciBilgileriGetir();
        }

        private void BakiciBilgileriGetir()
        {
            if (bakici.Id > 0)
            {
                Text = "\"" + bakici.Ad + "\" isimli Bakıcı Güncelleniyor";

                txtBakiciAd.Text = bakici.Ad;
                txtBakiciSoyad.Text = bakici.Soyad;
                BakiciHayvanlariListele();
            }
            else
            {
                Text = "Yeni Bakıcı oluşturuluyor";
            }
            BakmadigiHayvanlariListele();
        }

        private void BakmadigiHayvanlariListele()
        {
            dgvTumHayvanlar.DataSource = null;
            if (bakici.Hayvanlar.Count != 0)
            {
                dgvTumHayvanlar.DataSource = db.Hayvanlar.ToList().Where(x => bakici.Hayvanlar.All(x2 => x2.Id != x.Id)).ToList();
            }
            else
                dgvTumHayvanlar.DataSource = db.Hayvanlar.ToList();
        }

        private void BakiciHayvanlariListele()
        {
            dgvBakiciHayvanlar.DataSource = null;
            if (bakici.Hayvanlar.Count > 0)
                dgvBakiciHayvanlar.DataSource = bakici.Hayvanlar.ToList();
        }

        private void btnBakiciyaHayvanEkle_Click(object sender, EventArgs e)
        {
            if (dgvTumHayvanlar.SelectedRows.Count == 0) return;
            int id = (int)dgvTumHayvanlar.SelectedRows[0].Cells[0].Value;
            Hayvan eklenecekHayvan = db.Hayvanlar.Find(id);
            bakici.Hayvanlar.Add(eklenecekHayvan);
            BakiciHayvanlariListele();
            BakmadigiHayvanlariListele();
        }

        private void btnBakicidanHayvanCikart_Click(object sender, EventArgs e)
        {
            if (dgvBakiciHayvanlar.SelectedRows.Count == 0) return;
            int id = (int)dgvBakiciHayvanlar.SelectedRows[0].Cells[0].Value;
            Hayvan silinecekHayvan = db.Hayvanlar.Find(id);
            bakici.Hayvanlar.Remove(silinecekHayvan);
            BakiciHayvanlariListele();
            BakmadigiHayvanlariListele();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string ad = txtBakiciAd.Text.Trim();
            string soyad = txtBakiciSoyad.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Ad ve Soyad alanı zorunludur");
                return;
            }

            bakici.Ad = ad;
            bakici.Soyad = soyad;

            if (bakici.Id == 0)
            {
                db.Bakicilar.Add(bakici);
                MessageBox.Show("Bakıcı eklendi.");
            }
            else
                MessageBox.Show("Bakıcı güncellendi.");
            db.SaveChanges();
            DialogResult = DialogResult.OK;//şimdilik boşta
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
