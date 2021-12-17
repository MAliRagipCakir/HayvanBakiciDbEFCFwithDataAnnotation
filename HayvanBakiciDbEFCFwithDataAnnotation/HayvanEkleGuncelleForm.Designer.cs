
namespace HayvanBakiciDbEFCFwithDataAnnotation
{
    partial class HayvanEkleGuncelleForm
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
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkSahibiVarMi = new System.Windows.Forms.CheckBox();
            this.nudKutle = new System.Windows.Forms.NumericUpDown();
            this.cboCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHayvanAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvHayvanBakicilar = new System.Windows.Forms.DataGridView();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnHayvandanBakiciCikart = new System.Windows.Forms.Button();
            this.btnHayvanaBakiciEkle = new System.Windows.Forms.Button();
            this.dgvTumBakicilar = new System.Windows.Forms.DataGridView();
            this.txtTurResimYolu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFavoriYiyecek = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanBakicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumBakicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(178, 149);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpDogumTarihi.TabIndex = 26;
            // 
            // chkSahibiVarMi
            // 
            this.chkSahibiVarMi.AutoSize = true;
            this.chkSahibiVarMi.Location = new System.Drawing.Point(178, 309);
            this.chkSahibiVarMi.Name = "chkSahibiVarMi";
            this.chkSahibiVarMi.Size = new System.Drawing.Size(126, 24);
            this.chkSahibiVarMi.TabIndex = 25;
            this.chkSahibiVarMi.Text = "Sahibi var mı?";
            this.chkSahibiVarMi.UseVisualStyleBackColor = true;
            // 
            // nudKutle
            // 
            this.nudKutle.DecimalPlaces = 2;
            this.nudKutle.Location = new System.Drawing.Point(178, 205);
            this.nudKutle.Name = "nudKutle";
            this.nudKutle.Size = new System.Drawing.Size(100, 26);
            this.nudKutle.TabIndex = 24;
            // 
            // cboCinsiyet
            // 
            this.cboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCinsiyet.FormattingEnabled = true;
            this.cboCinsiyet.Location = new System.Drawing.Point(179, 99);
            this.cboCinsiyet.Name = "cboCinsiyet";
            this.cboCinsiyet.Size = new System.Drawing.Size(199, 28);
            this.cboCinsiyet.TabIndex = 23;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(178, 257);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(270, 26);
            this.txtTur.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kütle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cinsiyet";
            // 
            // txtHayvanAd
            // 
            this.txtHayvanAd.Location = new System.Drawing.Point(178, 45);
            this.txtHayvanAd.Name = "txtHayvanAd";
            this.txtHayvanAd.Size = new System.Drawing.Size(200, 26);
            this.txtHayvanAd.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Hayvanla ilgilenen Bakıcılar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tüm Bakıcılar";
            // 
            // dgvHayvanBakicilar
            // 
            this.dgvHayvanBakicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHayvanBakicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHayvanBakicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanBakicilar.Location = new System.Drawing.Point(495, 331);
            this.dgvHayvanBakicilar.MultiSelect = false;
            this.dgvHayvanBakicilar.Name = "dgvHayvanBakicilar";
            this.dgvHayvanBakicilar.RowHeadersVisible = false;
            this.dgvHayvanBakicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanBakicilar.Size = new System.Drawing.Size(445, 192);
            this.dgvHayvanBakicilar.TabIndex = 32;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(823, 599);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(117, 49);
            this.btnIptal.TabIndex = 31;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(700, 599);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(117, 49);
            this.btnTamam.TabIndex = 30;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnHayvandanBakiciCikart
            // 
            this.btnHayvandanBakiciCikart.Location = new System.Drawing.Point(966, 331);
            this.btnHayvandanBakiciCikart.Name = "btnHayvandanBakiciCikart";
            this.btnHayvandanBakiciCikart.Size = new System.Drawing.Size(117, 49);
            this.btnHayvandanBakiciCikart.TabIndex = 29;
            this.btnHayvandanBakiciCikart.Text = "Çıkart";
            this.btnHayvandanBakiciCikart.UseVisualStyleBackColor = true;
            this.btnHayvandanBakiciCikart.Click += new System.EventHandler(this.btnHayvandanBakiciCikart_Click);
            // 
            // btnHayvanaBakiciEkle
            // 
            this.btnHayvanaBakiciEkle.Location = new System.Drawing.Point(966, 67);
            this.btnHayvanaBakiciEkle.Name = "btnHayvanaBakiciEkle";
            this.btnHayvanaBakiciEkle.Size = new System.Drawing.Size(117, 49);
            this.btnHayvanaBakiciEkle.TabIndex = 28;
            this.btnHayvanaBakiciEkle.Text = "Ekle";
            this.btnHayvanaBakiciEkle.UseVisualStyleBackColor = true;
            this.btnHayvanaBakiciEkle.Click += new System.EventHandler(this.btnHayvanaBakiciEkle_Click);
            // 
            // dgvTumBakicilar
            // 
            this.dgvTumBakicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTumBakicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTumBakicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumBakicilar.Location = new System.Drawing.Point(495, 67);
            this.dgvTumBakicilar.MultiSelect = false;
            this.dgvTumBakicilar.Name = "dgvTumBakicilar";
            this.dgvTumBakicilar.RowHeadersVisible = false;
            this.dgvTumBakicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTumBakicilar.Size = new System.Drawing.Size(445, 192);
            this.dgvTumBakicilar.TabIndex = 27;
            // 
            // txtTurResimYolu
            // 
            this.txtTurResimYolu.Location = new System.Drawing.Point(178, 379);
            this.txtTurResimYolu.Name = "txtTurResimYolu";
            this.txtTurResimYolu.Size = new System.Drawing.Size(270, 26);
            this.txtTurResimYolu.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tür Resim Yolu";
            // 
            // cboFavoriYiyecek
            // 
            this.cboFavoriYiyecek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFavoriYiyecek.FormattingEnabled = true;
            this.cboFavoriYiyecek.Items.AddRange(new object[] {
            "---",
            "Dişi",
            "Erkek"});
            this.cboFavoriYiyecek.Location = new System.Drawing.Point(179, 450);
            this.cboFavoriYiyecek.Name = "cboFavoriYiyecek";
            this.cboFavoriYiyecek.Size = new System.Drawing.Size(269, 28);
            this.cboFavoriYiyecek.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Favori Yiyecek";
            // 
            // HayvanEkleGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 692);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboFavoriYiyecek);
            this.Controls.Add(this.txtTurResimYolu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvHayvanBakicilar);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnHayvandanBakiciCikart);
            this.Controls.Add(this.btnHayvanaBakiciEkle);
            this.Controls.Add(this.dgvTumBakicilar);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.chkSahibiVarMi);
            this.Controls.Add(this.nudKutle);
            this.Controls.Add(this.cboCinsiyet);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHayvanAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HayvanEkleGuncelleForm";
            this.Text = "HayvanEkleGuncelleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanBakicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumBakicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.CheckBox chkSahibiVarMi;
        private System.Windows.Forms.NumericUpDown nudKutle;
        private System.Windows.Forms.ComboBox cboCinsiyet;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHayvanAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHayvanBakicilar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnHayvandanBakiciCikart;
        private System.Windows.Forms.Button btnHayvanaBakiciEkle;
        private System.Windows.Forms.DataGridView dgvTumBakicilar;
        private System.Windows.Forms.TextBox txtTurResimYolu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFavoriYiyecek;
        private System.Windows.Forms.Label label9;
    }
}