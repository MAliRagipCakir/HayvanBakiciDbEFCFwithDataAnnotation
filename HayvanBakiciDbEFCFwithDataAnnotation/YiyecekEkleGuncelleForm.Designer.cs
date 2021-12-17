
namespace HayvanBakiciDbEFCFwithDataAnnotation
{
    partial class YiyecekEkleGuncelleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtYiyecekAd = new System.Windows.Forms.TextBox();
            this.txtYiyecekResimYolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSonKullanmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.nudKalori = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yiyecek Adı";
            // 
            // txtYiyecekAd
            // 
            this.txtYiyecekAd.Location = new System.Drawing.Point(206, 39);
            this.txtYiyecekAd.Name = "txtYiyecekAd";
            this.txtYiyecekAd.Size = new System.Drawing.Size(247, 26);
            this.txtYiyecekAd.TabIndex = 1;
            // 
            // txtYiyecekResimYolu
            // 
            this.txtYiyecekResimYolu.Location = new System.Drawing.Point(206, 247);
            this.txtYiyecekResimYolu.Name = "txtYiyecekResimYolu";
            this.txtYiyecekResimYolu.Size = new System.Drawing.Size(247, 26);
            this.txtYiyecekResimYolu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yiyecek Resim Yolu";
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Location = new System.Drawing.Point(206, 91);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(247, 26);
            this.dtpUretimTarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üretim Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Son Kullanma Tarihi";
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(206, 143);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(247, 26);
            this.dtpSonKullanmaTarihi.TabIndex = 6;
            // 
            // nudKalori
            // 
            this.nudKalori.Location = new System.Drawing.Point(206, 195);
            this.nudKalori.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudKalori.Name = "nudKalori";
            this.nudKalori.Size = new System.Drawing.Size(120, 26);
            this.nudKalori.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kalori";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(336, 322);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(117, 49);
            this.btnIptal.TabIndex = 33;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(213, 322);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(117, 49);
            this.btnTamam.TabIndex = 32;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // YiyecekEkleGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 393);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudKalori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSonKullanmaTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.txtYiyecekResimYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYiyecekAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YiyecekEkleGuncelleForm";
            this.Text = "YiyecekEkleGuncelleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYiyecekAd;
        private System.Windows.Forms.TextBox txtYiyecekResimYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSonKullanmaTarihi;
        private System.Windows.Forms.NumericUpDown nudKalori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
    }
}