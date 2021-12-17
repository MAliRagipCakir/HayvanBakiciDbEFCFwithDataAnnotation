
namespace HayvanBakiciDbEFCFwithDataAnnotation
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
            }
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
            this.cboBakici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHayvan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pboHayvan = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboYiyecek = new System.Windows.Forms.ComboBox();
            this.btnSeciliEkle = new System.Windows.Forms.Button();
            this.rdbBakici = new System.Windows.Forms.RadioButton();
            this.rdbHayvan = new System.Windows.Forms.RadioButton();
            this.rdbYiyecek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pboFavoriYiyecek = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYiyecekGuncelle = new System.Windows.Forms.Button();
            this.btnYiyecekSil = new System.Windows.Forms.Button();
            this.btnBakiciGuncelle = new System.Windows.Forms.Button();
            this.btnBakiciSil = new System.Windows.Forms.Button();
            this.btnHayvanSil = new System.Windows.Forms.Button();
            this.pboYiyecek = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHayvan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFavoriYiyecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboYiyecek)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBakici
            // 
            this.cboBakici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBakici.FormattingEnabled = true;
            this.cboBakici.Location = new System.Drawing.Point(19, 32);
            this.cboBakici.Name = "cboBakici";
            this.cboBakici.Size = new System.Drawing.Size(304, 28);
            this.cboBakici.TabIndex = 0;
            this.cboBakici.SelectedIndexChanged += new System.EventHandler(this.cboBakici_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bakıcı Hayvanları";
            // 
            // dgvHayvan
            // 
            this.dgvHayvan.AllowUserToAddRows = false;
            this.dgvHayvan.AllowUserToDeleteRows = false;
            this.dgvHayvan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHayvan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHayvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvan.Location = new System.Drawing.Point(333, 32);
            this.dgvHayvan.MultiSelect = false;
            this.dgvHayvan.Name = "dgvHayvan";
            this.dgvHayvan.ReadOnly = true;
            this.dgvHayvan.RowHeadersVisible = false;
            this.dgvHayvan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvan.Size = new System.Drawing.Size(594, 334);
            this.dgvHayvan.TabIndex = 4;
            this.dgvHayvan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHayvan_CellMouseDoubleClick);
            this.dgvHayvan.SelectionChanged += new System.EventHandler(this.dgvHayvan_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hayvan Türü";
            this.label3.Visible = false;
            // 
            // pboHayvan
            // 
            this.pboHayvan.Location = new System.Drawing.Point(333, 462);
            this.pboHayvan.Name = "pboHayvan";
            this.pboHayvan.Size = new System.Drawing.Size(294, 202);
            this.pboHayvan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHayvan.TabIndex = 6;
            this.pboHayvan.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(929, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yiyecekler";
            // 
            // cboYiyecek
            // 
            this.cboYiyecek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYiyecek.FormattingEnabled = true;
            this.cboYiyecek.Location = new System.Drawing.Point(933, 32);
            this.cboYiyecek.Name = "cboYiyecek";
            this.cboYiyecek.Size = new System.Drawing.Size(304, 28);
            this.cboYiyecek.TabIndex = 9;
            this.cboYiyecek.SelectedIndexChanged += new System.EventHandler(this.cboYiyecek_SelectedIndexChanged);
            // 
            // btnSeciliEkle
            // 
            this.btnSeciliEkle.Location = new System.Drawing.Point(188, 110);
            this.btnSeciliEkle.Name = "btnSeciliEkle";
            this.btnSeciliEkle.Size = new System.Drawing.Size(92, 54);
            this.btnSeciliEkle.TabIndex = 10;
            this.btnSeciliEkle.Text = "Ekle";
            this.btnSeciliEkle.UseVisualStyleBackColor = true;
            this.btnSeciliEkle.Click += new System.EventHandler(this.btnSeciliEkle_Click);
            // 
            // rdbBakici
            // 
            this.rdbBakici.AutoSize = true;
            this.rdbBakici.Checked = true;
            this.rdbBakici.Location = new System.Drawing.Point(33, 58);
            this.rdbBakici.Name = "rdbBakici";
            this.rdbBakici.Size = new System.Drawing.Size(69, 24);
            this.rdbBakici.TabIndex = 11;
            this.rdbBakici.TabStop = true;
            this.rdbBakici.Text = "Bakıcı";
            this.rdbBakici.UseVisualStyleBackColor = true;
            // 
            // rdbHayvan
            // 
            this.rdbHayvan.AutoSize = true;
            this.rdbHayvan.Location = new System.Drawing.Point(33, 100);
            this.rdbHayvan.Name = "rdbHayvan";
            this.rdbHayvan.Size = new System.Drawing.Size(80, 24);
            this.rdbHayvan.TabIndex = 12;
            this.rdbHayvan.Text = "Hayvan";
            this.rdbHayvan.UseVisualStyleBackColor = true;
            // 
            // rdbYiyecek
            // 
            this.rdbYiyecek.AutoSize = true;
            this.rdbYiyecek.Location = new System.Drawing.Point(33, 139);
            this.rdbYiyecek.Name = "rdbYiyecek";
            this.rdbYiyecek.Size = new System.Drawing.Size(82, 24);
            this.rdbYiyecek.TabIndex = 13;
            this.rdbYiyecek.Text = "Yiyecek";
            this.rdbYiyecek.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBakici);
            this.groupBox1.Controls.Add(this.btnSeciliEkle);
            this.groupBox1.Controls.Add(this.rdbHayvan);
            this.groupBox1.Controls.Add(this.rdbYiyecek);
            this.groupBox1.Location = new System.Drawing.Point(19, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili\'den Ekle";
            // 
            // pboFavoriYiyecek
            // 
            this.pboFavoriYiyecek.Location = new System.Drawing.Point(633, 462);
            this.pboFavoriYiyecek.Name = "pboFavoriYiyecek";
            this.pboFavoriYiyecek.Size = new System.Drawing.Size(294, 202);
            this.pboFavoriYiyecek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFavoriYiyecek.TabIndex = 18;
            this.pboFavoriYiyecek.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Favori Yiyeceği";
            this.label5.Visible = false;
            // 
            // btnYiyecekGuncelle
            // 
            this.btnYiyecekGuncelle.Location = new System.Drawing.Point(1100, 98);
            this.btnYiyecekGuncelle.Name = "btnYiyecekGuncelle";
            this.btnYiyecekGuncelle.Size = new System.Drawing.Size(137, 54);
            this.btnYiyecekGuncelle.TabIndex = 23;
            this.btnYiyecekGuncelle.Text = "Güncelle";
            this.btnYiyecekGuncelle.UseVisualStyleBackColor = true;
            this.btnYiyecekGuncelle.Click += new System.EventHandler(this.btnYiyecekGuncelle_Click);
            // 
            // btnYiyecekSil
            // 
            this.btnYiyecekSil.Location = new System.Drawing.Point(933, 98);
            this.btnYiyecekSil.Name = "btnYiyecekSil";
            this.btnYiyecekSil.Size = new System.Drawing.Size(137, 54);
            this.btnYiyecekSil.TabIndex = 22;
            this.btnYiyecekSil.Text = "Sil";
            this.btnYiyecekSil.UseVisualStyleBackColor = true;
            this.btnYiyecekSil.Click += new System.EventHandler(this.btnYiyecekSil_Click);
            // 
            // btnBakiciGuncelle
            // 
            this.btnBakiciGuncelle.Location = new System.Drawing.Point(186, 98);
            this.btnBakiciGuncelle.Name = "btnBakiciGuncelle";
            this.btnBakiciGuncelle.Size = new System.Drawing.Size(137, 54);
            this.btnBakiciGuncelle.TabIndex = 25;
            this.btnBakiciGuncelle.Text = "Güncelle";
            this.btnBakiciGuncelle.UseVisualStyleBackColor = true;
            this.btnBakiciGuncelle.Click += new System.EventHandler(this.btnBakiciGuncelle_Click);
            // 
            // btnBakiciSil
            // 
            this.btnBakiciSil.Location = new System.Drawing.Point(19, 98);
            this.btnBakiciSil.Name = "btnBakiciSil";
            this.btnBakiciSil.Size = new System.Drawing.Size(137, 54);
            this.btnBakiciSil.TabIndex = 24;
            this.btnBakiciSil.Text = "Sil";
            this.btnBakiciSil.UseVisualStyleBackColor = true;
            this.btnBakiciSil.Click += new System.EventHandler(this.btnBakiciSil_Click);
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.Location = new System.Drawing.Point(564, 372);
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(137, 54);
            this.btnHayvanSil.TabIndex = 26;
            this.btnHayvanSil.Text = "Hayvanı Doğaya Sal";
            this.btnHayvanSil.UseVisualStyleBackColor = true;
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // pboYiyecek
            // 
            this.pboYiyecek.Location = new System.Drawing.Point(937, 178);
            this.pboYiyecek.Name = "pboYiyecek";
            this.pboYiyecek.Size = new System.Drawing.Size(294, 188);
            this.pboYiyecek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboYiyecek.TabIndex = 28;
            this.pboYiyecek.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(933, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Yiyecek Resmi";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 692);
            this.Controls.Add(this.pboYiyecek);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHayvanSil);
            this.Controls.Add(this.btnBakiciGuncelle);
            this.Controls.Add(this.btnBakiciSil);
            this.Controls.Add(this.btnYiyecekGuncelle);
            this.Controls.Add(this.btnYiyecekSil);
            this.Controls.Add(this.pboFavoriYiyecek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboYiyecek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pboHayvan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvHayvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBakici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboHayvan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFavoriYiyecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboYiyecek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBakici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHayvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboHayvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboYiyecek;
        private System.Windows.Forms.Button btnSeciliEkle;
        private System.Windows.Forms.RadioButton rdbBakici;
        private System.Windows.Forms.RadioButton rdbHayvan;
        private System.Windows.Forms.RadioButton rdbYiyecek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pboFavoriYiyecek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYiyecekGuncelle;
        private System.Windows.Forms.Button btnYiyecekSil;
        private System.Windows.Forms.Button btnBakiciGuncelle;
        private System.Windows.Forms.Button btnBakiciSil;
        private System.Windows.Forms.Button btnHayvanSil;
        private System.Windows.Forms.PictureBox pboYiyecek;
        private System.Windows.Forms.Label label6;
    }
}

