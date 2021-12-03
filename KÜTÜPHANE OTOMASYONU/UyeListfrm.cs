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
    public partial class UyeListfrm : Form
    {
        public UyeListfrm()
        {
            InitializeComponent();
        }
        /*veri tabanımızın adresini değişkene atayarak belirtiyoruz*/
        DataSet daset = new DataSet();
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*uye tablosundan tc ye göre datagridden silme yaptık. Ön planda datagridden arka planda uye tablosundan silindi*/
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
                        SqlCommand komut = new SqlCommand("update uye set Active = 0 where Id=@Id", connect);
                        komut.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                        komut.ExecuteNonQuery();
                        connect.Close();
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Silme işlemi tamamlandı");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silinecek kaydı seçiniz!", "Uyarı");
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
        /*Üye listeleme işi için bir metot oluşturduk gerekli yerlerde çağıracağız*/
        private void uyelist()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select Tc,AdSoyad,OgrenciNo,Eposta,Tell,Adres,active from uye where Active=1", connect);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            connect.Close();
        }
        private void UyeListfrm_Load(object sender, EventArgs e)
        {
            uyelist();
        }
        /*üye güncelleme işlemi için veri tabanındaki tüm değerleri geçici isimlerine atayıp o isimlere karşılık gelen textbox ları tanımladık ve güncelleme işlemini yaptık.*/
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("Güncelleme işlemi yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if ( SayiMi(txtTc.Text) == true && SayiMi(txtOgrNo.Text) == true && SayiMi(txtTell.Text) == true)
                    {
                    if ( txtTc.TextLength <= 50 && txtAdSoyad.TextLength <= 50 && txtOgrNo.TextLength <= 50 && txtEposta.TextLength <= 50 && txtTell.TextLength <= 50 && txtAdres.TextLength <= 50)
                    {
                        if ( txtTc.Text != "" && txtAdSoyad.Text != "" && txtOgrNo.Text != "" && txtEposta.Text != "" && txtTell.Text != "" && txtAdres.Text != "")
                        {
                            connect.Open();
                            SqlCommand komut = new SqlCommand("update uye set TC=@Tc,AdSoyad=@AdSoyad,OgrenciNo=@OgrenciNo,Eposta=@Eposta,Tell=@Tell,Adres=@Adres where Id=Id Active=1", connect);
                            komut.Parameters.AddWithValue("@Tc", txtTc.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@OgrenciNo", txtOgrNo.Text);
                            komut.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                            komut.Parameters.AddWithValue("@Tell", txtTell.Text);
                            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                            komut.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Güncelleme işlemi yapıldı");
                            daset.Tables["uye"].Clear();
                            uyelist();
                            foreach (Control item in Controls)
                            {
                                if (item is TextBox)
                                {
                                    item.Text = "";
                                }
                            }
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
                    MessageBox.Show("TC, ÖĞRENCİ NO TELEFON bilgileri sayı dışında karakter içeremez!", "Uyari");
                }
            }     
        }



          
        /*datagrid in cell double click bölümüne data gridde tıklanan öğeyi tc ye text box larda sıraladık*/
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
        }
        /*uye tablosundan verileri çekip kullanıcının girdiği değere göre sıralama yaptık*/

        /*veri tabanındaki kayıtları listelemek için select deyimini kullandık. Uye tablosundan tc boxına listeleme yaptık*/
        private void txtAraId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["uye"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where active=1 and Tc like '" + txtAraId.Text + "'", connect);
            adtr.Fill(daset, "uye");
            connect.Close();
            if (txtAraId.Text == "")
            {
                daset.Tables["uye"].Clear();
                uyelist();
            }
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            PopupUyefrm popup1 = new PopupUyefrm();
            popup1.ShowDialog();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut = new SqlCommand("select *from uye  where active=1 and Tc like'" + txtTc.Text + "'", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["AdSoyad"].ToString();
                txtOgrNo.Text = read["OgrenciNo"].ToString();
                txtEposta.Text = read["Eposta"].ToString();
                txtTell.Text = read["Tell"].ToString();
                txtAdres.Text = read["Adres"].ToString();
            }
            connect.Close();
        }
    }
    
}
