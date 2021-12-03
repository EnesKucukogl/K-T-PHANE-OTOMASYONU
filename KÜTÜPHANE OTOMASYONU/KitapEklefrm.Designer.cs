
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class KitapEklefrm
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
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKayit = new System.Windows.Forms.TextBox();
            this.chcActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(160, 147);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(227, 27);
            this.txtRafNo.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(160, 44);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(227, 27);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(160, 96);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(227, 27);
            this.txtYazari.TabIndex = 3;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(160, 200);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(227, 27);
            this.txtSayfa.TabIndex = 4;
            // 
            // txtYayin
            // 
            this.txtYayin.Location = new System.Drawing.Point(160, 247);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(227, 27);
            this.txtYayin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "RAF NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "KİTAP ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "YAZARI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "SAYFA SAYISI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "YAYIN EVİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "TÜRÜ";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(291, 465);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(96, 26);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(160, 465);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(96, 26);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Biyografi",
            "Oto Biyografi",
            "Gezi Yazısı",
            "Şiir Kitabı",
            "Akademik Kitap",
            "Dini Kitap",
            "Çocuk Kitabı",
            "Masal"});
            this.cmbTuru.Location = new System.Drawing.Point(160, 294);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(227, 28);
            this.cmbTuru.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "KAYIT TARİHİ";
            // 
            // txtKayit
            // 
            this.txtKayit.Location = new System.Drawing.Point(160, 349);
            this.txtKayit.Name = "txtKayit";
            this.txtKayit.Size = new System.Drawing.Size(227, 27);
            this.txtKayit.TabIndex = 18;
            // 
            // chcActive
            // 
            this.chcActive.AutoSize = true;
            this.chcActive.Location = new System.Drawing.Point(20, 411);
            this.chcActive.Name = "chcActive";
            this.chcActive.Size = new System.Drawing.Size(72, 24);
            this.chcActive.TabIndex = 19;
            this.chcActive.Text = "Active";
            this.chcActive.UseVisualStyleBackColor = true;
            // 
            // KitapEklefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 529);
            this.Controls.Add(this.chcActive);
            this.Controls.Add(this.txtKayit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYayin);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.txtYazari);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtRafNo);
            this.Name = "KitapEklefrm";
            this.Text = "KİTAP EKLEME SAYFASI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKayit;
        private System.Windows.Forms.CheckBox chcActive;
    }
}