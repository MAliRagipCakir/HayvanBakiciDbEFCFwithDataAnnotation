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
    public partial class HayvanEkleGuncelleForm : Form
    {
        private readonly HayvanBakiciDbContext db;
        private readonly Hayvan hayvan;

        public HayvanEkleGuncelleForm(HayvanBakiciDbContext db, Hayvan hayvan)
        {
            this.db = db;
            this.hayvan = hayvan;
            InitializeComponent();
            CinsiyetleriYukle();
            HayvanBilgileriGetir();
        }

        private void CinsiyetleriYukle()
        {
            cboCinsiyet.DataSource = null;
            cboCinsiyet.DataSource = Enum.GetNames(typeof(CinsiyetEnum)).ToArray();// Foreach Enum.GetValues ile cbo'ya yükleyince güncelleme yaparken selected item'ı hayvan.Cinsiyet yapılmadı o yüzden string olarak tutunca çözüldü
        }

        private void YiyecekleriYukle()
        {
            cboFavoriYiyecek.DataSource = null;
            cboFavoriYiyecek.DataSource = db.Yiyecekler.ToList();
            cboFavoriYiyecek.DisplayMember = "Ad";
            cboFavoriYiyecek.SelectedIndex = -1;
        }

        private void HayvanBilgileriGetir()
        {


            if (hayvan.Id > 0)
            {
                Text = "\"" + hayvan.Ad + "\" isimli Hayvan Güncelleniyor.";

                txtHayvanAd.Text = hayvan.Ad;
                dtpDogumTarihi.Value = (DateTime)hayvan.DogumTarihi;
                nudKutle.Value = (decimal)hayvan.Kutle;
                txtTur.Text = hayvan.Tur;
                txtTurResimYolu.Text = hayvan.TurResimYolu;
                chkSahibiVarMi.Checked = hayvan.SahibiVarMi;
                cboCinsiyet.SelectedItem = Enum.GetName(typeof(CinsiyetEnum), hayvan.Cinsiyet);

                YiyecekleriYukle();
                if (hayvan.Yiyecek != null)
                {
                    cboFavoriYiyecek.SelectedItem = hayvan.Yiyecek;
                }

                HayvanınBakicilariListele();
            }
            else
            {
                Text = "Yeni Hayvan oluşturuluyor";
                cboCinsiyet.SelectedIndex = -1;
                YiyecekleriYukle();
            }
            HayvanaBakmayanBakicilariListele();
        }

        private void HayvanaBakmayanBakicilariListele()
        {
            dgvTumBakicilar.DataSource = null;
            if (hayvan.Bakicilar.Count != 0)
            {
                dgvTumBakicilar.DataSource = db.Bakicilar.ToList().Where(x => hayvan.Bakicilar.All(x2 => x2.Id != x.Id)).ToList();
            }
            else
                dgvTumBakicilar.DataSource = db.Bakicilar.ToList();
        }

        private void HayvanınBakicilariListele()
        {
            dgvHayvanBakicilar.DataSource = null;
            if (hayvan.Bakicilar.Count > 0)
                dgvHayvanBakicilar.DataSource = hayvan.Bakicilar.ToList();
        }

        private void btnHayvanaBakiciEkle_Click(object sender, EventArgs e)
        {
            if (dgvTumBakicilar.SelectedRows.Count == 0) return;
            int id = (int)dgvTumBakicilar.SelectedRows[0].Cells[0].Value;
            Bakici eklenecekBakici = db.Bakicilar.Find(id);
            hayvan.Bakicilar.Add(eklenecekBakici);                          //Tekrar tekrar aynı bakıcı eklenmeye çalışsılsa da eklemiyor hata da vermiyor neden??
            HayvanınBakicilariListele();
            HayvanaBakmayanBakicilariListele();
        }

        private void btnHayvandanBakiciCikart_Click(object sender, EventArgs e)
        {
            if (dgvHayvanBakicilar.SelectedRows.Count == 0) return;
            int id = (int)dgvHayvanBakicilar.SelectedRows[0].Cells[0].Value;
            Bakici silinecekBakici = db.Bakicilar.Find(id);
            hayvan.Bakicilar.Remove(silinecekBakici);
            HayvanınBakicilariListele();
            HayvanaBakmayanBakicilariListele();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string ad = txtHayvanAd.Text.Trim();
            string tur = txtTur.Text.Trim();
            string turResimYolu = txtTurResimYolu.Text.Trim();

            if (ad == "" || tur == "")
            {
                MessageBox.Show("Ad ve Tür alanı boş bırakılamaz.");
                return;
            }

            hayvan.Ad = ad;
            hayvan.Tur = tur;
            hayvan.Kutle = (double)nudKutle.Value;
            hayvan.SahibiVarMi = chkSahibiVarMi.Checked;
            hayvan.DogumTarihi = dtpDogumTarihi.Value;
            if (cboCinsiyet.SelectedIndex != -1)
            {
                string cinsiyet = (string)cboCinsiyet.SelectedItem;
                hayvan.Cinsiyet = (CinsiyetEnum)Enum.Parse(typeof(CinsiyetEnum), cinsiyet);
            }
            else
            {
                MessageBox.Show("Cinsiyet seçeneği boş bırakılamaz");
                return;
            }

            if (cboFavoriYiyecek.SelectedIndex != -1)
                hayvan.Yiyecek = (Yiyecek)cboFavoriYiyecek.SelectedItem;

            if (turResimYolu != "")
                hayvan.TurResimYolu = turResimYolu;

            if (hayvan.Id == 0)
            {
                db.Hayvanlar.Add(hayvan);
                MessageBox.Show("Hayvan eklendi.");
            }
            else
                MessageBox.Show("Hayvan güncellendi.");
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
