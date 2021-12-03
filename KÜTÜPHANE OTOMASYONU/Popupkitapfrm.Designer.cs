
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class Popupkitapfrm
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
            this.txtAraYazari = new System.Windows.Forms.TextBox();
            this.txtAraKitapAdi = new System.Windows.Forms.TextBox();
            this.txtAraId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAraYazari
            // 
            this.txtAraYazari.Location = new System.Drawing.Point(946, 34);
            this.txtAraYazari.Name = "txtAraYazari";
            this.txtAraYazari.Size = new System.Drawing.Size(185, 27);
            this.txtAraYazari.TabIndex = 13;
            this.txtAraYazari.TextChanged += new System.EventHandler(this.txtAraYazari_TextChanged);
            // 
            // txtAraKitapAdi
            // 
            this.txtAraKitapAdi.Location = new System.Drawing.Point(578, 35);
            this.txtAraKitapAdi.Name = "txtAraKitapAdi";
            this.txtAraKitapAdi.Size = new System.Drawing.Size(185, 27);
            this.txtAraKitapAdi.TabIndex = 12;
            this.txtAraKitapAdi.TextChanged += new System.EventHandler(this.txtAraKitapAdi_TextChanged);
            // 
            // txtAraId
            // 
            this.txtAraId.Location = new System.Drawing.Point(152, 35);
            this.txtAraId.Name = "txtAraId";
            this.txtAraId.Size = new System.Drawing.Size(185, 27);
            this.txtAraId.TabIndex = 11;
            this.txtAraId.TextChanged += new System.EventHandler(this.txtAraId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yazarı ile ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kitap adı ile ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id ile ara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 502);
            this.dataGridView1.TabIndex = 7;
            // 
            // Popupkitapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 641);
            this.Controls.Add(this.txtAraYazari);
            this.Controls.Add(this.txtAraKitapAdi);
            this.Controls.Add(this.txtAraId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Popupkitapfrm";
            this.Text = "Popupkitapfrm";
            this.Load += new System.EventHandler(this.Popupkitapfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAraYazari;
        private System.Windows.Forms.TextBox txtAraKitapAdi;
        private System.Windows.Forms.TextBox txtAraId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}