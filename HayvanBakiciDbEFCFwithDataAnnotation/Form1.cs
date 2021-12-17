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
    //https://www.entityframeworktutorial.net/code-first/dataannotation-in-code-first.aspx
    public partial class Form1 : Form
    {
        HayvanBakiciDbContext db = new HayvanBakiciDbContext();
        public Form1()
        {
            InitializeComponent();
            BakicilariYukle();
            YiyecekleriYukle();
        }

        private void YiyecekleriYukle()
        {
            cboYiyecek.DataSource = null;
            cboYiyecek.DataSource = db.Yiyecekler.ToList();
            cboYiyecek.DisplayMember = "Ad";
            cboYiyecek.SelectedIndex = -1;
        }

        private void BakicilariYukle()
        {
            cboBakici.DataSource = null;

            #region Deneme1(HayvanGüncellede sıkıntı verebilir)(Vermedi)
            var takimListesi = db.Bakicilar.ToList();
            takimListesi.Insert(0, new Bakici()
            {
                Ad = "Bakıcısı Olmayanlar",
                Soyad = "Hayvanlar",
                Hayvanlar = db.Hayvanlar.Where(k => k.Bakicilar.Count == 0).ToList()
            });
            cboBakici.DataSource = takimListesi;
            #endregion

            #region DENEME2(Gerek Kalmadı Deneme1 çalıştı)
            //cboBakici.Items.Clear();
            //cboBakici.Items.Add("Tüm Hayvanlar");
            //foreach (var item in db.Bakicilar)
            //{
            //    cboBakici.Items.Add(item);
            //}
            #endregion

            cboBakici.DisplayMember = "Ad";         //'DisplayMember =' işlemi çalışınca selectedIndex'i 0 yapıyor dikkat(selectedindexchanged eventi varsa tetiklenir)
            cboBakici.SelectedIndex = -1;
        }

        private void btnSeciliEkle_Click(object sender, EventArgs e)
        {
            if (!rdbBakici.Checked && !rdbHayvan.Checked && !rdbYiyecek.Checked)
            {
                MessageBox.Show("Eklenecek bir eleman seçin");
                return;
            }
            if (rdbBakici.Checked)
            {
                //Bakici Ekle
                Bakici yeniBakici = new Bakici() { Hayvanlar = new List<Hayvan>() };
                DialogResult dr = new BakiciEkleGuncelleForm(db, yeniBakici).ShowDialog();
                BakicilariYukle();
                HayvanlariYükle();
                HayvanVeYiyecekResimleriYukle();
                //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
            }
            else if (rdbHayvan.Checked)
            {
                //Hayvan Ekle
                Hayvan yeniHayvan = new Hayvan() { Bakicilar = new List<Bakici>() };
                DialogResult dr = new HayvanEkleGuncelleForm(db, yeniHayvan).ShowDialog();
                BakicilariYukle();
                HayvanlariYükle();
                HayvanVeYiyecekResimleriYukle();
                //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
            }
            else if (rdbYiyecek.Checked)
            {
                //Yiyecek Ekle
                Yiyecek yeniYiyecek = new Yiyecek() { };
                DialogResult dr = new YiyecekEkleGuncelleForm(db, yeniYiyecek).ShowDialog();
                YiyecekleriYukle();
                HayvanlariYükle();
                HayvanVeYiyecekResimleriYukle();
                //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
            }
            //else durumu yok çünkü rdbBakici F4 ile checked = true yaptım yani 3 ünün'de seçili olmama durumu ortadan kalktı
        }

        private void btnBakiciSil_Click(object sender, EventArgs e)
        {
            if (cboBakici.SelectedItem == null || cboBakici.SelectedIndex == 0) return;
            Bakici silinecekBakici = (Bakici)cboBakici.SelectedItem;
            db.Bakicilar.Remove(silinecekBakici);
            db.SaveChanges();
            BakicilariYukle();
            HayvanVeYiyecekResimleriYukle();
        }

        private void btnBakiciGuncelle_Click(object sender, EventArgs e)
        {
            if (cboBakici.SelectedItem == null || cboBakici.SelectedIndex < 1) return;
            Bakici guncellenecekBakici = (Bakici)cboBakici.SelectedItem;
            DialogResult dr = new BakiciEkleGuncelleForm(db, guncellenecekBakici).ShowDialog();
            BakicilariYukle();
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
            //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
        }

        private void cboBakici_SelectedIndexChanged(object sender, EventArgs e)
        {
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
        }

        private void HayvanlariYükle()
        {
            dgvHayvan.DataSource = null;
            if (cboBakici.SelectedIndex == -1) return;
            Bakici seciliBakici = (Bakici)cboBakici.SelectedItem;
            //var seciliBakicininHayvanlari = seciliBakici.Hayvanlar.ToList();  //Gerek kalmadı
            dgvHayvan.DataSource = seciliBakici.Hayvanlar.Select(x => new
            {
                x.Id,
                x.Ad,
                x.Cinsiyet,
                x.DogumTarihi,
                x.Kutle,
                x.SahibiVarMi,
                FavoriYiyecek = x.Yiyecek != null ? x.Yiyecek.Ad : "",
                Bakicilar = x.Bakicilar != null ?string.Join(", ",x.Bakicilar.Select(p=>p.Ad)):""
            }).ToList();
        }

        private void dgvHayvan_SelectionChanged(object sender, EventArgs e)
        {
            HayvanVeYiyecekResimleriYukle();
        }

        private void HayvanVeYiyecekResimleriYukle()
        {
            if (dgvHayvan.SelectedRows.Count != 1)
            {
                pboHayvan.ImageLocation = null;
                pboFavoriYiyecek.ImageLocation = null;
                return;
            }
            int id = (int)dgvHayvan.SelectedRows[0].Cells[0].Value;
            Hayvan hayvan = db.Hayvanlar.Find(id);
            pboHayvan.ImageLocation = null;
            pboHayvan.ImageLocation = hayvan.TurResimYolu;
            if(hayvan.Yiyecek != null)
            {
                pboFavoriYiyecek.ImageLocation = null;
                pboFavoriYiyecek.ImageLocation = hayvan.Yiyecek.YiyecekResimYolu;
            }
            #region Eski hali(gereksiz kontroller var ama silmeye kıyamadım belki hata çıkar)
            //if (string.IsNullOrEmpty(hayvan.TurResimYolu))
            //{
            //    pboHayvan.ImageLocation = null;
            //    pboHayvan.Image = null;
            //}
            //else
            //    pboHayvan.ImageLocation = hayvan.TurResimYolu;

            //if (hayvan.Yiyecek != null)
            //{
            //    if (string.IsNullOrEmpty(hayvan.Yiyecek.YiyecekResimYolu))
            //    {
            //        pboFavoriYiyecek.ImageLocation = null;
            //        pboFavoriYiyecek.Image = null;
            //    }
            //    else
            //        pboFavoriYiyecek.ImageLocation = hayvan.Yiyecek.YiyecekResimYolu;
            //}
            //else
            //{
            //    pboFavoriYiyecek.ImageLocation = null;
            //    pboFavoriYiyecek.Image = null;
            //} 
            #endregion
        }

        private void dgvHayvan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHayvan.SelectedRows.Count != 1)return;
            if (e.RowIndex == -1)return;

            int id = (int)dgvHayvan.SelectedRows[0].Cells[0].Value;
            Hayvan guncellenecekHayvan = db.Hayvanlar.Find(id);
            DialogResult dr = new HayvanEkleGuncelleForm(db, guncellenecekHayvan).ShowDialog();
            BakicilariYukle();
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
            //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            if (dgvHayvan.SelectedRows.Count != 1) return;
            int id = (int)dgvHayvan.SelectedRows[0].Cells[0].Value;
            Hayvan silinecekHayvan = db.Hayvanlar.Find(id);
            db.Hayvanlar.Remove(silinecekHayvan);
            db.SaveChanges();
            BakicilariYukle();
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
        }

        private void btnYiyecekGuncelle_Click(object sender, EventArgs e)
        {
            if (cboYiyecek.SelectedItem == null || cboYiyecek.SelectedIndex < 0) return;
            Yiyecek guncellenecekYiyecek = (Yiyecek)cboYiyecek.SelectedItem;
            DialogResult dr = new YiyecekEkleGuncelleForm(db,guncellenecekYiyecek).ShowDialog();
            YiyecekleriYukle();
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
            //if(dr == DialogResult.OK) ise yapılacak işlemler (Güncelleme form kapandıktan sonra Ana form'da seçiliyi tekrar işlem yapılan eleman'a geri getirmek için ekstra kod yazılabilir)
        }

        private void btnYiyecekSil_Click(object sender, EventArgs e)
        {
            if (cboYiyecek.SelectedItem ==null||cboYiyecek.SelectedIndex < 0) return;
            Yiyecek silinecekYiyecek = (Yiyecek)cboYiyecek.SelectedItem;
            db.Yiyecekler.Remove(silinecekYiyecek);
            db.SaveChanges();
            YiyecekleriYukle();
            HayvanlariYükle();
            HayvanVeYiyecekResimleriYukle();
        }

        private void cboYiyecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboYiyecek.SelectedIndex == -1)
            {
                pboYiyecek.ImageLocation = null;
                return;
            }
            pboYiyecek.ImageLocation = null;

            Yiyecek yiyecek = (Yiyecek)cboYiyecek.SelectedItem;
            pboYiyecek.ImageLocation = yiyecek.YiyecekResimYolu;
        }
    }
}
