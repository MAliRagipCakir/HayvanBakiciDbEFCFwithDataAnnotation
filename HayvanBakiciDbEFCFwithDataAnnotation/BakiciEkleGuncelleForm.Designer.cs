
namespace HayvanBakiciDbEFCFwithDataAnnotation
{
    partial class BakiciEkleGuncelleForm
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
            this.txtBakiciAd = new System.Windows.Forms.TextBox();
            this.txtBakiciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTumHayvanlar = new System.Windows.Forms.DataGridView();
            this.btnBakiciyaHayvanEkle = new System.Windows.Forms.Button();
            this.btnBakicidanHayvanCikart = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dgvBakiciHayvanlar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakiciHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtBakiciAd
            // 
            this.txtBakiciAd.Location = new System.Drawing.Point(94, 147);
            this.txtBakiciAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBakiciAd.Name = "txtBakiciAd";
            this.txtBakiciAd.Size = new System.Drawing.Size(148, 26);
            this.txtBakiciAd.TabIndex = 1;
            // 
            // txtBakiciSoyad
            // 
            this.txtBakiciSoyad.Location = new System.Drawing.Point(94, 257);
            this.txtBakiciSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBakiciSoyad.Name = "txtBakiciSoyad";
            this.txtBakiciSoyad.Size = new System.Drawing.Size(148, 26);
            this.txtBakiciSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // dgvTumHayvanlar
            // 
            this.dgvTumHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTumHayvanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTumHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumHayvanlar.Location = new System.Drawing.Point(290, 103);
            this.dgvTumHayvanlar.MultiSelect = false;
            this.dgvTumHayvanlar.Name = "dgvTumHayvanlar";
            this.dgvTumHayvanlar.RowHeadersVisible = false;
            this.dgvTumHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTumHayvanlar.Size = new System.Drawing.Size(445, 192);
            this.dgvTumHayvanlar.TabIndex = 4;
            // 
            // btnBakiciyaHayvanEkle
            // 
            this.btnBakiciyaHayvanEkle.Location = new System.Drawing.Point(761, 103);
            this.btnBakiciyaHayvanEkle.Name = "btnBakiciyaHayvanEkle";
            this.btnBakiciyaHayvanEkle.Size = new System.Drawing.Size(117, 49);
            this.btnBakiciyaHayvanEkle.TabIndex = 5;
            this.btnBakiciyaHayvanEkle.Text = "Ekle";
            this.btnBakiciyaHayvanEkle.UseVisualStyleBackColor = true;
            this.btnBakiciyaHayvanEkle.Click += new System.EventHandler(this.btnBakiciyaHayvanEkle_Click);
            // 
            // btnBakicidanHayvanCikart
            // 
            this.btnBakicidanHayvanCikart.Location = new System.Drawing.Point(761, 367);
            this.btnBakicidanHayvanCikart.Name = "btnBakicidanHayvanCikart";
            this.btnBakicidanHayvanCikart.Size = new System.Drawing.Size(117, 49);
            this.btnBakicidanHayvanCikart.TabIndex = 6;
            this.btnBakicidanHayvanCikart.Text = "Çıkart";
            this.btnBakicidanHayvanCikart.UseVisualStyleBackColor = true;
            this.btnBakicidanHayvanCikart.Click += new System.EventHandler(this.btnBakicidanHayvanCikart_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(495, 635);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(117, 49);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(618, 635);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(117, 49);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dgvBakiciHayvanlar
            // 
            this.dgvBakiciHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBakiciHayvanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBakiciHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBakiciHayvanlar.Location = new System.Drawing.Point(290, 367);
            this.dgvBakiciHayvanlar.MultiSelect = false;
            this.dgvBakiciHayvanlar.Name = "dgvBakiciHayvanlar";
            this.dgvBakiciHayvanlar.RowHeadersVisible = false;
            this.dgvBakiciHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBakiciHayvanlar.Size = new System.Drawing.Size(445, 192);
            this.dgvBakiciHayvanlar.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tüm Hayvanlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bakıcının İlgilendiği Hayvanlar";
            // 
            // BakiciEkleGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 734);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBakiciHayvanlar);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnBakicidanHayvanCikart);
            this.Controls.Add(this.btnBakiciyaHayvanEkle);
            this.Controls.Add(this.dgvTumHayvanlar);
            this.Controls.Add(this.txtBakiciSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBakiciAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BakiciEkleGuncelleForm";
            this.Text = "BakiciEkleGuncelleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakiciHayvanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBakiciAd;
        private System.Windows.Forms.TextBox txtBakiciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTumHayvanlar;
        private System.Windows.Forms.Button btnBakiciyaHayvanEkle;
        private System.Windows.Forms.Button btnBakicidanHayvanCikart;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dgvBakiciHayvanlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}