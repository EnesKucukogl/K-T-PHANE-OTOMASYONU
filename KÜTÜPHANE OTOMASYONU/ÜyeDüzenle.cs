using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class ÜyeDüzenlefrm : Form
    {
        public ÜyeDüzenlefrm()
        {
            InitializeComponent();
        }
        //İptal butonunun kapatma komutu verildi
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
        /*Uyeleri eklemek için veri tabanındaki tc,ad vs gibideğerleri isimleri ile çağırıp tek tek tanımladık ve execute... diyerek de işlemimizden etkilenen satırları döndürdük.
          Son olarak da döngü yardımıyla hemen bir sonraki kayıt için formu temizledik.*/
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

            connect.Open();
            SqlCommand komut_2 = new SqlCommand("select *from uye where Tc=@Tc ", connect);
            komut_2.Parameters.AddWithValue("@Tc", txtTc.Text);
            SqlDataReader read = komut_2.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Bu TC ile sistemde kayıtlı biri var!", "Uyarı");
            }
            else
            {
                connect.Close();
                if (SayiMi(txtTc.Text) == true && SayiMi(txtOgrNo.Text) == true && SayiMi(txtTell.Text) == true)
                {
                    if (txtTc.TextLength <= 50 && txtAdSoyad.TextLength <= 50 && txtOgrNo.TextLength <= 50 && txtEposta.TextLength <= 50 && txtTell.TextLength <= 50 && txtAdres.TextLength <= 50)
                    {
                        if (txtTc.Text != "" && txtAdSoyad.Text != "" && txtOgrNo.Text != "" && txtEposta.Text != "" && txtTell.Text != "" && txtAdres.Text != ""&& chcActive != null)
                        {
                            connect.Open();
                            SqlCommand komut = new SqlCommand("insert into uye(Tc,AdSoyad,OgrenciNo,Eposta,Tell,Adres,Active) values(@Tc,@AdSoyad,@OgrenciNo,@Eposta,@Tell,@Adres,@Active)", connect);

                            komut.Parameters.AddWithValue("@Tc", txtTc.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@OgrenciNo", txtOgrNo.Text);
                            komut.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                            komut.Parameters.AddWithValue("@Tell", txtTell.Text);
                            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                            komut.Parameters.AddWithValue("@Active", chcActive.Checked);
                            komut.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Kayıt işlemi yapıldı");
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler kısmındaki her bilgiyi doldurmalısınız!", "Uyari");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirlenen karakters sayısından fazla karakter tuşladınız!", "Uyari");
                    }
                }
                else
                {
                    MessageBox.Show("TC, ÖĞRENCİ NO TELEFON bilgileri sayı dışında karakter içeremez!", "Uyari");
                }
            }
        }
    }
}
