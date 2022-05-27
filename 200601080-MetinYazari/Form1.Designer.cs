namespace MetinYazari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.txtMetinPath = new System.Windows.Forms.TextBox();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.lblDosyaPath = new System.Windows.Forms.Label();
            this.lblCumleSayi = new System.Windows.Forms.Label();
            this.txtCumleSayi = new System.Windows.Forms.TextBox();
            this.txtCumleKelimeSayi = new System.Windows.Forms.TextBox();
            this.txtOrtKelimeSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCumleKelim = new System.Windows.Forms.Label();
            this.btnAgacAktar = new System.Windows.Forms.Button();
            this.btnHashTabloOlustur = new System.Windows.Forms.Button();
            this.btnSikKullanilanKelimeler = new System.Windows.Forms.Button();
            this.lboxSikKullanilanKelimeler = new System.Windows.Forms.ListBox();
            this.lblSikKullanilanKelimeler = new System.Windows.Forms.Label();
            this.btnHashDene = new System.Windows.Forms.Button();
            this.txtHashDeneme = new System.Windows.Forms.TextBox();
            this.lblascii = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(122, 68);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(275, 45);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yukle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // txtMetinPath
            // 
            this.txtMetinPath.Location = new System.Drawing.Point(122, 31);
            this.txtMetinPath.Name = "txtMetinPath";
            this.txtMetinPath.Size = new System.Drawing.Size(275, 31);
            this.txtMetinPath.TabIndex = 1;
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(122, 119);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(275, 34);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Stack Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // lblDosyaPath
            // 
            this.lblDosyaPath.AutoSize = true;
            this.lblDosyaPath.Location = new System.Drawing.Point(12, 34);
            this.lblDosyaPath.Name = "lblDosyaPath";
            this.lblDosyaPath.Size = new System.Drawing.Size(104, 25);
            this.lblDosyaPath.TabIndex = 4;
            this.lblDosyaPath.Text = "Dosya Yolu:";
            // 
            // lblCumleSayi
            // 
            this.lblCumleSayi.AutoSize = true;
            this.lblCumleSayi.Location = new System.Drawing.Point(498, 31);
            this.lblCumleSayi.Name = "lblCumleSayi";
            this.lblCumleSayi.Size = new System.Drawing.Size(115, 25);
            this.lblCumleSayi.TabIndex = 5;
            this.lblCumleSayi.Text = "Cumle Sayisi:";
            // 
            // txtCumleSayi
            // 
            this.txtCumleSayi.Location = new System.Drawing.Point(644, 31);
            this.txtCumleSayi.Name = "txtCumleSayi";
            this.txtCumleSayi.Size = new System.Drawing.Size(150, 31);
            this.txtCumleSayi.TabIndex = 6;
            // 
            // txtCumleKelimeSayi
            // 
            this.txtCumleKelimeSayi.Location = new System.Drawing.Point(644, 75);
            this.txtCumleKelimeSayi.Name = "txtCumleKelimeSayi";
            this.txtCumleKelimeSayi.Size = new System.Drawing.Size(150, 31);
            this.txtCumleKelimeSayi.TabIndex = 7;
            // 
            // txtOrtKelimeSayi
            // 
            this.txtOrtKelimeSayi.Location = new System.Drawing.Point(644, 122);
            this.txtOrtKelimeSayi.Name = "txtOrtKelimeSayi";
            this.txtOrtKelimeSayi.Size = new System.Drawing.Size(150, 31);
            this.txtOrtKelimeSayi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ortalama Kelime Sayisi: ";
            // 
            // lblCumleKelim
            // 
            this.lblCumleKelim.AutoSize = true;
            this.lblCumleKelim.Location = new System.Drawing.Point(435, 78);
            this.lblCumleKelim.Name = "lblCumleKelim";
            this.lblCumleKelim.Size = new System.Drawing.Size(183, 25);
            this.lblCumleKelim.TabIndex = 10;
            this.lblCumleKelim.Text = "Cumle Kelime Sayilari:";
            // 
            // btnAgacAktar
            // 
            this.btnAgacAktar.Location = new System.Drawing.Point(122, 172);
            this.btnAgacAktar.Name = "btnAgacAktar";
            this.btnAgacAktar.Size = new System.Drawing.Size(275, 34);
            this.btnAgacAktar.TabIndex = 11;
            this.btnAgacAktar.Text = "Agaca Aktar";
            this.btnAgacAktar.UseVisualStyleBackColor = true;
            this.btnAgacAktar.Click += new System.EventHandler(this.btnAgacAktar_Click);
            // 
            // btnHashTabloOlustur
            // 
            this.btnHashTabloOlustur.Location = new System.Drawing.Point(122, 275);
            this.btnHashTabloOlustur.Name = "btnHashTabloOlustur";
            this.btnHashTabloOlustur.Size = new System.Drawing.Size(275, 34);
            this.btnHashTabloOlustur.TabIndex = 12;
            this.btnHashTabloOlustur.Text = "Hash Tablo Olustur";
            this.btnHashTabloOlustur.UseVisualStyleBackColor = true;
            this.btnHashTabloOlustur.Click += new System.EventHandler(this.btnHashTabloOlustur_Click);
            // 
            // btnSikKullanilanKelimeler
            // 
            this.btnSikKullanilanKelimeler.Location = new System.Drawing.Point(122, 222);
            this.btnSikKullanilanKelimeler.Name = "btnSikKullanilanKelimeler";
            this.btnSikKullanilanKelimeler.Size = new System.Drawing.Size(275, 34);
            this.btnSikKullanilanKelimeler.TabIndex = 13;
            this.btnSikKullanilanKelimeler.Text = "Sık Kullanilan Kelimeleri Getir";
            this.btnSikKullanilanKelimeler.UseVisualStyleBackColor = true;
            this.btnSikKullanilanKelimeler.Click += new System.EventHandler(this.btnSikKullanilanKelimeler_Click);
            // 
            // lboxSikKullanilanKelimeler
            // 
            this.lboxSikKullanilanKelimeler.FormattingEnabled = true;
            this.lboxSikKullanilanKelimeler.ItemHeight = 25;
            this.lboxSikKullanilanKelimeler.Location = new System.Drawing.Point(644, 177);
            this.lboxSikKullanilanKelimeler.Name = "lboxSikKullanilanKelimeler";
            this.lboxSikKullanilanKelimeler.Size = new System.Drawing.Size(733, 154);
            this.lboxSikKullanilanKelimeler.TabIndex = 14;
            // 
            // lblSikKullanilanKelimeler
            // 
            this.lblSikKullanilanKelimeler.AutoSize = true;
            this.lblSikKullanilanKelimeler.Location = new System.Drawing.Point(435, 177);
            this.lblSikKullanilanKelimeler.Name = "lblSikKullanilanKelimeler";
            this.lblSikKullanilanKelimeler.Size = new System.Drawing.Size(194, 25);
            this.lblSikKullanilanKelimeler.TabIndex = 15;
            this.lblSikKullanilanKelimeler.Text = "Sık Kullanilan Kelimeler:";
            // 
            // btnHashDene
            // 
            this.btnHashDene.Location = new System.Drawing.Point(269, 371);
            this.btnHashDene.Name = "btnHashDene";
            this.btnHashDene.Size = new System.Drawing.Size(113, 34);
            this.btnHashDene.TabIndex = 16;
            this.btnHashDene.Text = "Hash Test";
            this.btnHashDene.UseVisualStyleBackColor = true;
            this.btnHashDene.Click += new System.EventHandler(this.btnHashDene_Click);
            // 
            // txtHashDeneme
            // 
            this.txtHashDeneme.Location = new System.Drawing.Point(101, 371);
            this.txtHashDeneme.Name = "txtHashDeneme";
            this.txtHashDeneme.Size = new System.Drawing.Size(150, 31);
            this.txtHashDeneme.TabIndex = 17;
            // 
            // lblascii
            // 
            this.lblascii.AutoSize = true;
            this.lblascii.Location = new System.Drawing.Point(101, 343);
            this.lblascii.Name = "lblascii";
            this.lblascii.Size = new System.Drawing.Size(202, 25);
            this.lblascii.TabIndex = 18;
            this.lblascii.Text = "Aranacak ascii kod dizisi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 669);
            this.Controls.Add(this.lblascii);
            this.Controls.Add(this.txtHashDeneme);
            this.Controls.Add(this.btnHashDene);
            this.Controls.Add(this.lblSikKullanilanKelimeler);
            this.Controls.Add(this.lboxSikKullanilanKelimeler);
            this.Controls.Add(this.btnSikKullanilanKelimeler);
            this.Controls.Add(this.btnHashTabloOlustur);
            this.Controls.Add(this.btnAgacAktar);
            this.Controls.Add(this.lblCumleKelim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrtKelimeSayi);
            this.Controls.Add(this.txtCumleKelimeSayi);
            this.Controls.Add(this.txtCumleSayi);
            this.Controls.Add(this.lblCumleSayi);
            this.Controls.Add(this.lblDosyaPath);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.txtMetinPath);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.TextBox txtMetinPath;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.Label lblDosyaPath;
        private System.Windows.Forms.Label lblCumleSayi;
        private System.Windows.Forms.TextBox txtCumleSayi;
        private System.Windows.Forms.TextBox txtCumleKelimeSayi;
        private System.Windows.Forms.TextBox txtOrtKelimeSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCumleKelim;
        private System.Windows.Forms.Button btnAgacAktar;
        private System.Windows.Forms.Button btnHashTabloOlustur;
        private System.Windows.Forms.Button btnSikKullanilanKelimeler;
        private System.Windows.Forms.ListBox lboxSikKullanilanKelimeler;
        private System.Windows.Forms.Label lblSikKullanilanKelimeler;
        private System.Windows.Forms.Button btnHashDene;
        private System.Windows.Forms.TextBox txtHashDeneme;
        private System.Windows.Forms.Label lblascii;
    }
}
