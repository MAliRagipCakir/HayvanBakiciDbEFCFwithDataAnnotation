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
    public partial class YiyecekEkleGuncelleForm : Form
    {
        private readonly HayvanBakiciDbContext db;
        private readonly Yiyecek yiyecek;

        public YiyecekEkleGuncelleForm(HayvanBakiciDbContext db, Yiyecek yiyecek)
        {
            this.db = db;
            this.yiyecek = yiyecek;
            InitializeComponent();
            YiyecekBilgileriGetir();
        }

        private void YiyecekBilgileriGetir()
        {
            if(yiyecek.Id > 0)
            {
                Text = "\"" + yiyecek.Ad + "\" isimli Yiyecek Güncelleniyor.";
                txtYiyecekAd.Text = yiyecek.Ad;
                txtYiyecekResimYolu.Text = yiyecek.YiyecekResimYolu;
                nudKalori.Value = (decimal)yiyecek.Kalori;
                dtpUretimTarihi.Value = yiyecek.UretimTarihi;
                dtpSonKullanmaTarihi.Value = (DateTime)yiyecek.SonKullanmaTarihi;
            }
            else
            {
                Text = "Yeni Yiyecek Oluşturuluyor.";
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string ad = txtYiyecekAd.Text.Trim();
            if(ad == "")
            {
                MessageBox.Show("Yiyecek Ad alanı boş bırakılamaz.");
                return;
            }

            yiyecek.Ad = ad;
            yiyecek.Kalori = nudKalori.Value;
            yiyecek.UretimTarihi = dtpUretimTarihi.Value;
            yiyecek.SonKullanmaTarihi = dtpSonKullanmaTarihi.Value;
            yiyecek.YiyecekResimYolu = txtYiyecekResimYolu.Text.Trim();

            if(yiyecek.SonKullanmaTarihi < yiyecek.UretimTarihi)
            {
                MessageBox.Show("Üretim Tarihi Son Kullanma Tarihin'den sonra olamaz.");
                return;
            }

            if (yiyecek.Id == 0)
            {
                db.Yiyecekler.Add(yiyecek);
                MessageBox.Show("Yiyecek eklendi");
            }
            else
                MessageBox.Show("Yiyecek güncellendi.");
            db.SaveChanges();
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
