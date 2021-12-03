
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class EmanetTeslimfrm
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
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtAraKitapId = new System.Windows.Forms.TextBox();
            this.txtAraUyeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnUye = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(1141, 162);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(94, 36);
            this.btnTeslimAl.TabIndex = 2;
            this.btnTeslimAl.Text = "TESLİM AL";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(1141, 228);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 29);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtAraKitapId
            // 
            this.txtAraKitapId.Location = new System.Drawing.Point(805, 107);
            this.txtAraKitapId.Name = "txtAraKitapId";
            this.txtAraKitapId.Size = new System.Drawing.Size(196, 27);
            this.txtAraKitapId.TabIndex = 4;
            this.txtAraKitapId.TextChanged += new System.EventHandler(this.txtAraKitapId_TextChanged);
            // 
            // txtAraUyeId
            // 
            this.txtAraUyeId.Location = new System.Drawing.Point(285, 107);
            this.txtAraUyeId.Name = "txtAraUyeId";
            this.txtAraUyeId.Size = new System.Drawing.Size(196, 27);
            this.txtAraUyeId.TabIndex = 5;
            this.txtAraUyeId.TextChanged += new System.EventHandler(this.txtAraUyeId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ÜYE ID İLE ARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "KİTAP ID İLE ARA";
            // 
            // btnKitap
            // 
            this.btnKitap.Location = new System.Drawing.Point(340, 44);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(94, 29);
            this.btnKitap.TabIndex = 18;
            this.btnKitap.Text = "KİTAP";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnUye
            // 
            this.btnUye.Location = new System.Drawing.Point(81, 44);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(94, 29);
            this.btnUye.TabIndex = 17;
            this.btnUye.Text = "ÜYE";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yardım: Kitap bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yardım: Üye bilgileri";
            // 
            // EmanetTeslimfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 653);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAraUyeId);
            this.Controls.Add(this.txtAraKitapId);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetTeslimfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET TESLİM";
            this.Load += new System.EventHandler(this.EmanetTeslimfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtAraKitapId;
        private System.Windows.Forms.TextBox txtAraUyeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}