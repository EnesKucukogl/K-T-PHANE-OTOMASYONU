
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class EmanetIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpuye = new System.Windows.Forms.GroupBox();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.grpkitap = new System.Windows.Forms.GroupBox();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpAlinacagi = new System.Windows.Forms.DateTimePicker();
            this.dtpVerildigi = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btntesliet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblKayitliKitap = new System.Windows.Forms.Label();
            this.lblKitapSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUye = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpuye.SuspendLayout();
            this.grpkitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(966, 556);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpuye
            // 
            this.grpuye.Controls.Add(this.txtUyeId);
            this.grpuye.Controls.Add(this.label6);
            this.grpuye.Controls.Add(this.label3);
            this.grpuye.Controls.Add(this.label2);
            this.grpuye.Controls.Add(this.txtAdSoyad);
            this.grpuye.Controls.Add(this.txtTc);
            this.grpuye.Location = new System.Drawing.Point(53, 139);
            this.grpuye.Name = "grpuye";
            this.grpuye.Size = new System.Drawing.Size(416, 178);
            this.grpuye.TabIndex = 1;
            this.grpuye.TabStop = false;
            this.grpuye.Text = "ÜYE BİLGİLERİ";
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(140, 42);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(250, 27);
            this.txtUyeId.TabIndex = 11;
            this.txtUyeId.TextChanged += new System.EventHandler(this.txtUyeId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "UYE ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(140, 107);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(250, 27);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(140, 75);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(250, 27);
            this.txtTc.TabIndex = 1;
            // 
            // grpkitap
            // 
            this.grpkitap.Controls.Add(this.txtKitapId);
            this.grpkitap.Controls.Add(this.label1);
            this.grpkitap.Controls.Add(this.txtKitapSayisi);
            this.grpkitap.Controls.Add(this.label16);
            this.grpkitap.Controls.Add(this.dtpAlinacagi);
            this.grpkitap.Controls.Add(this.dtpVerildigi);
            this.grpkitap.Controls.Add(this.label15);
            this.grpkitap.Controls.Add(this.label14);
            this.grpkitap.Controls.Add(this.label11);
            this.grpkitap.Controls.Add(this.label10);
            this.grpkitap.Controls.Add(this.txtYazari);
            this.grpkitap.Controls.Add(this.txtKitapAdi);
            this.grpkitap.Location = new System.Drawing.Point(53, 323);
            this.grpkitap.Name = "grpkitap";
            this.grpkitap.Size = new System.Drawing.Size(416, 301);
            this.grpkitap.TabIndex = 2;
            this.grpkitap.TabStop = false;
            this.grpkitap.Text = "KİTAP BİLGİLERİ";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(140, 61);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(250, 27);
            this.txtKitapId.TabIndex = 22;
            this.txtKitapId.TextChanged += new System.EventHandler(this.txtKitapId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "KİTAP ID";
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(140, 161);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(250, 27);
            this.txtKitapSayisi.TabIndex = 20;
            this.txtKitapSayisi.Text = "1";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "KİTAP SAYISI";
            // 
            // dtpAlinacagi
            // 
            this.dtpAlinacagi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlinacagi.Location = new System.Drawing.Point(140, 227);
            this.dtpAlinacagi.Name = "dtpAlinacagi";
            this.dtpAlinacagi.Size = new System.Drawing.Size(250, 27);
            this.dtpAlinacagi.TabIndex = 17;
            // 
            // dtpVerildigi
            // 
            this.dtpVerildigi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVerildigi.Location = new System.Drawing.Point(140, 194);
            this.dtpVerildigi.Name = "dtpVerildigi";
            this.dtpVerildigi.Size = new System.Drawing.Size(250, 27);
            this.dtpVerildigi.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "ALINACAĞI TARİH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "VERİLDİĞİ TARİH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "YAZARI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "KİTAP ADI";
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(140, 127);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(250, 27);
            this.txtYazari.TabIndex = 3;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(140, 94);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(250, 27);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(193, 647);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 29);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btntesliet
            // 
            this.btntesliet.Location = new System.Drawing.Point(349, 647);
            this.btntesliet.Name = "btntesliet";
            this.btntesliet.Size = new System.Drawing.Size(94, 29);
            this.btntesliet.TabIndex = 4;
            this.btntesliet.Text = "TESLİM ET";
            this.btntesliet.UseVisualStyleBackColor = true;
            this.btntesliet.Click += new System.EventHandler(this.btntesliet_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(1347, 642);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(94, 29);
            this.btniptal.TabIndex = 5;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1218, 642);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 29);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(672, 647);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(145, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "KAYITLI KİTAP SAYISI";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(937, 647);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 20);
            this.label20.TabIndex = 8;
            this.label20.Text = "KİTAP SAYISI";
            // 
            // lblKayitliKitap
            // 
            this.lblKayitliKitap.AutoSize = true;
            this.lblKayitliKitap.Location = new System.Drawing.Point(823, 647);
            this.lblKayitliKitap.Name = "lblKayitliKitap";
            this.lblKayitliKitap.Size = new System.Drawing.Size(0, 20);
            this.lblKayitliKitap.TabIndex = 9;
            // 
            // lblKitapSayisi
            // 
            this.lblKitapSayisi.AutoSize = true;
            this.lblKitapSayisi.Location = new System.Drawing.Point(1035, 647);
            this.lblKitapSayisi.Name = "lblKitapSayisi";
            this.lblKitapSayisi.Size = new System.Drawing.Size(0, 20);
            this.lblKitapSayisi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yardım: Üye bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yardım: Kitap bilgileri";
            // 
            // btnUye
            // 
            this.btnUye.Location = new System.Drawing.Point(53, 61);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(94, 29);
            this.btnUye.TabIndex = 13;
            this.btnUye.Text = "ÜYE";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.Location = new System.Drawing.Point(312, 61);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(94, 29);
            this.btnKitap.TabIndex = 14;
            this.btnKitap.Text = "KİTAP";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // EmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 713);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKitapSayisi);
            this.Controls.Add(this.lblKayitliKitap);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btntesliet);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.grpkitap);
            this.Controls.Add(this.grpuye);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetIslemleri";
            this.Text = "EmanetIslemleri";
            this.Load += new System.EventHandler(this.EmanetIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpuye.ResumeLayout(false);
            this.grpuye.PerformLayout();
            this.grpkitap.ResumeLayout(false);
            this.grpkitap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpuye;
        private System.Windows.Forms.GroupBox grpkitap;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpAlinacagi;
        private System.Windows.Forms.DateTimePicker dtpVerildigi;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btntesliet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblKayitliKitap;
        private System.Windows.Forms.Label lblKitapSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label1;
    }
}