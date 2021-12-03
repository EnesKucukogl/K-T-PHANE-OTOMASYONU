
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class PopupUyefrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAraId = new System.Windows.Forms.TextBox();
            this.txtAraTc = new System.Windows.Forms.TextBox();
            this.txtAraAdSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id ile ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tc ile ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad soyad ile ara";
            // 
            // txtAraId
            // 
            this.txtAraId.Location = new System.Drawing.Point(150, 29);
            this.txtAraId.Name = "txtAraId";
            this.txtAraId.Size = new System.Drawing.Size(185, 27);
            this.txtAraId.TabIndex = 4;
            this.txtAraId.TextChanged += new System.EventHandler(this.txtAraId_TextChanged);
            // 
            // txtAraTc
            // 
            this.txtAraTc.Location = new System.Drawing.Point(527, 30);
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(185, 27);
            this.txtAraTc.TabIndex = 5;
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            // 
            // txtAraAdSoyad
            // 
            this.txtAraAdSoyad.Location = new System.Drawing.Point(948, 36);
            this.txtAraAdSoyad.Name = "txtAraAdSoyad";
            this.txtAraAdSoyad.Size = new System.Drawing.Size(185, 27);
            this.txtAraAdSoyad.TabIndex = 6;
            this.txtAraAdSoyad.TextChanged += new System.EventHandler(this.txtAraAdSoyad_TextChanged);
            // 
            // PopupUyefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 664);
            this.Controls.Add(this.txtAraAdSoyad);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.txtAraId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopupUyefrm";
            this.Text = "PopupUyefrm";
            this.Load += new System.EventHandler(this.PopupUyefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAraId;
        private System.Windows.Forms.TextBox txtAraTc;
        private System.Windows.Forms.TextBox txtAraAdSoyad;
    }
}