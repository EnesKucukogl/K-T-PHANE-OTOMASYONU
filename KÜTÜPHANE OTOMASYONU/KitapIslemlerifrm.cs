using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class KitapIslemlerifrm : Form
    {
        public KitapIslemlerifrm()
        {
            InitializeComponent();
        }
       
        DataSet daset = new DataSet();
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        /*kitap listelemek için metod yazdık*/
        private void booklist()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where active is null", connect);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            connect.Close();
        }
        private void KitapIslemlerifrm_Load(object sender, EventArgs e)
        {
            booklist();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*kullanıcıdan aldığımız silinme bilgisine göre kitap tablosundaki seçile veriyi silme işlemi yaptık*/
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("KAYIT SİLİNSİN Mİ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    connect.Open();
                    SqlCommand komut = new SqlCommand("update kitap set Active = 1 where Id=@Id", connect);
                    komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                    komut.ExecuteNonQuery();
                    connect.Close();
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    MessageBox.Show("Silme işlemi tamamlandı");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!", "Uyarı");
                }
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }

                }
            }
        }
        /*kitap tablosundaki mevcut bir kitabın bilgilerini geçici değişkenlere atayıp karşılık gelen textbox larda tanımladık ve güncelleme işlemi yaptık.*/
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("Güncelleme işlemi yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                    
                if ( SayiMi(txtRafNo.Text) == true && SayiMi(txtSayfa.Text) == true )
                {
                    if ( txtKitapAdi.TextLength <= 50 && txtYazari.TextLength <= 50 && txtRafNo.TextLength <= 50 && txtSayfa.TextLength <= 50 && txtYayin.TextLength <= 50 && txtKayit.TextLength <= 50 )
                    {
                        if ( txtKitapAdi.Text != "" && txtYazari.Text != "" && txtRafNo.Text != "" && txtSayfa.Text != "" && txtYayin.Text != "" && cmbTuru.Text != "" && txtKayit.Text != "")
                        {
                            connect.Open();
                            SqlCommand komut = new SqlCommand("update kitap set KitapAdi=@KitapAdi,Yazari=@Yazari,RafNo=@RafNo,SayfaSayisi=@SayfaSayisi,YayinEvi=@YayinEvi,Turu=@Turu,KayitTarihi=@KayitTarihi where Id=@Id", connect);
                            komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                            komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
                            komut.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
                            komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfa.Text);
                            komut.Parameters.AddWithValue("@YayinEvi", txtYayin.Text);
                            komut.Parameters.AddWithValue("@Turu", cmbTuru.Text);
                            komut.Parameters.AddWithValue("@KayitTarihi", txtKayit.Text);
                            komut.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Güncelleme işlemi yapıldı");
                            daset.Tables["kitap"].Clear();
                            booklist();
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler kısmındaki her bilgiyi doldurmalısınız!", "Uyari");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirlenen karakter sayısından fazla karakter tuşladınız!", "Uyari");
                    }                     
                }
                else
                {
                    MessageBox.Show("RAF NO, SAYFA SAYISI, STOK SAYISI bilgileri sayı dışında karakter içeremez!", "Uyari");
                }
            }
        }         
        
        /*kitap tablosundan kitap no ya göre verileri çekip datagrid de listeledik*/

        /*kitap tablosundan kitap no ya göre verileri çekip hepsini tanımlayıp textboxlarda listeledik*/
        /*data grid in celldoubleclick bölümüne, çift tıklandığı zaman kitap no ya göre text boxlarda listleme işlemi yaptık*/
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();
        }

        private void txtAraId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["kitap"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from kitap where active is null and Id like '" + txtAraId.Text+ "'", connect);
            adtr.Fill(daset, "kitap");
            connect.Close();
            if (txtAraId.Text == "")
            {
                daset.Tables["kitap"].Clear();
                booklist();
            }
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Popupkitapfrm popup2 = new Popupkitapfrm();
            popup2.ShowDialog();
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut = new SqlCommand("select *from kitap  where active is null and KitapAdi like'" + txtKitapAdi.Text + "'", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtYazari.Text = read["Yazari"].ToString();
                txtRafNo.Text = read["RafNo"].ToString();
                txtSayfa.Text = read["SayfaSayisi"].ToString();
                txtYayin.Text = read["YayinEvi"].ToString();
                cmbTuru.Text = read["Turu"].ToString();
                txtKayit.Text = read["KayitTarihi"].ToString();
            }
            connect.Close();
        }
    }
}
