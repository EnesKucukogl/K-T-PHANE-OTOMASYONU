
namespace KÜTÜPHANE_OTOMASYONU
{
    partial class EmanetListelemefrm
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
            this.cmbFiltrele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(939, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbFiltrele
            // 
            this.cmbFiltrele.FormattingEnabled = true;
            this.cmbFiltrele.Items.AddRange(new object[] {
            "Tümü",
            "Teslim süresi dolan",
            "Teslim süresi dolmayan"});
            this.cmbFiltrele.Location = new System.Drawing.Point(785, 21);
            this.cmbFiltrele.Name = "cmbFiltrele";
            this.cmbFiltrele.Size = new System.Drawing.Size(151, 28);
            this.cmbFiltrele.TabIndex = 1;
            this.cmbFiltrele.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrele_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FİLTRELE";
            // 
            // EmanetListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetListelemefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMANET LİSTELEME";
            this.Load += new System.EventHandler(this.EmanetTeslimfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbFiltrele;
        private System.Windows.Forms.Label label1;
    }
}