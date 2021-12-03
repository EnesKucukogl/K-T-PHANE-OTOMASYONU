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
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
       
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
        /*kitap tablosuna ekleme işlemi yaptık*/
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
                if ( SayiMi(txtRafNo.Text) == true && SayiMi(txtSayfa.Text) == true )
                {
                    if ( txtRafNo.TextLength <= 50 && txtKitapAdi.TextLength <= 50 && txtYazari.TextLength <= 50 && txtSayfa.TextLength <= 50 && txtSayfa.TextLength <= 50 && txtYayin.TextLength <= 50 && txtKayit.TextLength <= 50 )
                    {
                        if ( txtRafNo.Text != "" && txtKitapAdi.Text != "" && txtYazari.Text != "" && txtSayfa.Text != "" && txtYayin.Text != "" && cmbTuru.Text != "" && txtKayit.Text != "" && chcActive!= null)
                        {
                            connect.Open();
                            SqlCommand komut = new SqlCommand("insert into kitap(RafNo,KitapAdi,Yazari,SayfaSayisi,YayinEvi,Turu,KayitTarihi,Active) values(@RafNo,@KitapAdi,@Yazari,@SayfaSayisi,@YayinEvi,@Turu,@KayitTarihi,@Active)", connect);
                            komut.Parameters.AddWithValue("@RafNo", txtRafNo.Text);
                            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                            komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
                            komut.Parameters.AddWithValue("@SayfaSayisi", txtSayfa.Text);
                            komut.Parameters.AddWithValue("@YayinEvi", txtYayin.Text);
                            komut.Parameters.AddWithValue("@Turu", cmbTuru.Text);
                            komut.Parameters.AddWithValue("@KayitTarihi", txtKayit.Text);
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
                        MessageBox.Show("Belirlenen karakter sayısından fazla karakter tuşladınız!", "Uyari");
                    }
                }
                else
                {
                    MessageBox.Show("RAF NO ve SAYFA SAYISI bölümleri sayı dışında karakter içeremez!", "Uyari");
                }
        }
    }
}
