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
    public partial class EmanetIslemleri : Form
    {
        public EmanetIslemleri()
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
        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*verileri listelemek için method yazdık*/
        private void verilistele()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from veri", connect);
            adtr.Fill(daset, "veri");
            dataGridView1.DataSource = daset.Tables["veri"];
            connect.Close();
        }
        /*sepete ekleme işlemi yaptık*/
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut_2 = new SqlCommand("select *from veri where UyeId!=@UyeId", connect);
            komut_2.Parameters.AddWithValue("@UyeId", txtUyeId.Text);
            SqlDataReader read = komut_2.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Sepette sadece tek bir kullanıcının işlemlerini yapabilirsiniz!", "Uyari");

            }
            else
            {
                connect.Close();
                if (txtKitapAdi.Text != "" && txtYazari.Text != "" && txtKitapSayisi.Text != "" && dtpVerildigi.Text != "" && dtpAlinacagi.Text != "")
                {
                    if (txtTc.TextLength <= 50 && txtAdSoyad.TextLength <= 50 && txtKitapAdi.TextLength <= 50 && txtYazari.TextLength <= 50 && txtKitapSayisi.TextLength <= 50)
                    {
                        if (SayiMi(txtTc.Text) == true && SayiMi(txtKitapSayisi.Text) == true)
                        {
                            connect.Open();
                            SqlCommand komut = new SqlCommand("insert into veri(UyeId,KitapId,KitapAdi,Yazari,KitapSayisi,VerildigiTarih,AlinacagiTarih) values(@UyeId,@KitapId,@KitapAdi,@Yazari,@KitapSayisi,@VerildigiTarih,@AlinacagiTarih)", connect);
                            komut.Parameters.AddWithValue("@UyeId", txtUyeId.Text);
                            komut.Parameters.AddWithValue("@KitapId", txtKitapId.Text);
                            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
                            komut.Parameters.AddWithValue("@Yazari", txtYazari.Text);
                            komut.Parameters.AddWithValue("@KitapSayisi", int.Parse(txtKitapSayisi.Text));
                            komut.Parameters.AddWithValue("@VerildigiTarih", dtpVerildigi.Text);
                            komut.Parameters.AddWithValue("@AlinacagiTarih", dtpAlinacagi.Text);
                            komut.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("EKLEME İŞLEMİ TAMAMLANDI");
                            daset.Tables["veri"].Clear();
                            verilistele();
                            lblKitapSayisi.Text = "";
                            kitapsayisi();
                            foreach (Control item in grpkitap.Controls)
                            {
                                if (item is TextBox)
                                {
                                    if (item != txtKitapSayisi)
                                    {
                                        item.Text = "";
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("TC VE KİTAP SAYISI bölümleri sayı dışında karakter içeremez!", "Uyarı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirlenen Karakter sayısından fazla tuşlama yaptınız!", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Sepete kitap eklemek için önce kitap ve üye seçmelisiniz!", "Uyarı");
                }
            }
            connect.Close();
        }
        /*labelda görülen kitap sayısı; veri tablosundan kitap sayısı değerini çekmek için method oluşturduk*/
        private void kitapsayisi()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayisi) from veri", connect);
            lblKitapSayisi.Text = komut.ExecuteScalar().ToString();
            connect.Close();
        }
        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {
            verilistele();
            kitapsayisi();
        }
        /*kitap tablosundan kitap no ya göre sıralama yaptık*/
        /*kullanıcıdan alınan cevaba göre sepetten silme işlemi yaptık*/
        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("KAYIT SİLİNSİN Mİ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            { 
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    connect.Open();
                    SqlCommand komut = new SqlCommand("delete from veri where KitapId='" + dataGridView1.CurrentRow.Cells["KitapId"].Value.ToString() + "'", connect);
                    komut.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("SİLME İŞLEMİ TAMAMLANDI");
                    daset.Tables["veri"].Clear();
                    verilistele();
                    lblKitapSayisi.Text = "";
                    kitapsayisi();
                }
                else
                {
                    MessageBox.Show("Sepet şu an boş. Silme işlemi yapamazsınız!","Uyarı");
                }   
            }          
        }
        /*sepete eklediğimiz kitaplari teslim etmek için telim et butonunda koşullu ifadelerimizi kurduk.
         eğer kitap girildiyse koşul devam ediyor eğer girilmediyse uyarı veriyor.
        eğer girilen kitap sayısı talep edilen kitabın stoğunda bir sorun oluşturmuyorsa koşul devam ediyor oluşturuyorsa uyarı veriyor.
        eğer kullanıcı bilgileri girildiyse koşul devam ediyor girilmediyse uyarı veriyor.*/
        private void btntesliet_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("Kitaplar teslim edilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if(dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    connect.Open();
                    SqlCommand komut_2 = new SqlCommand("select *from emanet where active is null and UyeId=@UyeId and KitapId=@KitapId", connect);
                    komut_2.Parameters.AddWithValue("@UyeId", dataGridView1.CurrentRow.Cells["UyeId"].Value.ToString());
                    komut_2.Parameters.AddWithValue("@KitapId", dataGridView1.CurrentRow.Cells["KitapId"].Value.ToString());
                    SqlDataReader read = komut_2.ExecuteReader();
                    if (read.Read())
                    {
                        MessageBox.Show("Bu üye bu kitabı zaten emanet almış onu geri getirmeden yenisini veremezsiniz!", "Uyarı");
                    }
                    else
                    {
                        connect.Close();
                        if (lblKitapSayisi.Text != "")
                        {
                            if (lblKayitliKitap.Text == "" && int.Parse(lblKitapSayisi.Text) <= 3 || lblKayitliKitap.Text != "" && int.Parse(lblKayitliKitap.Text) + int.Parse(lblKitapSayisi.Text) <= 3)
                            {
                                if (  txtTc.Text != "" && txtAdSoyad.Text != "")
                                {
                                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                                    {
                                        connect.Open();
                                        SqlCommand komut = new SqlCommand("insert into emanet (UyeId, KitapId,KitapSayisi,VerildigiTarih,AlinacagiTarih ) values(@UyeId, @KitapId,@KitapSayisi,@VerildigiTarih,@AlinacagiTarih)", connect);
                                        komut.Parameters.AddWithValue("@UyeId", txtUyeId.Text);
                                        komut.Parameters.AddWithValue("@KitapId", dataGridView1.Rows[i].Cells["KitapId"].Value.ToString());
                                        komut.Parameters.AddWithValue("@KitapSayisi", dataGridView1.Rows[i].Cells["KitapSayisi"].Value.ToString());
                                        komut.Parameters.AddWithValue("@VerildigiTarih", dataGridView1.Rows[i].Cells["VerildigiTarih"].Value.ToString());
                                        komut.Parameters.AddWithValue("@AlinacagiTarih", dataGridView1.Rows[i].Cells["AlinacagiTarih"].Value.ToString());
                                        komut.ExecuteNonQuery();
                                        connect.Close();
                                    }
                                    /*InsertKeyMode into emanet select tc*/
                                    connect.Open();
                                    SqlCommand komut_4 = new SqlCommand("delete from veri", connect);
                                    komut_4.ExecuteNonQuery();
                                    connect.Close();
                                    MessageBox.Show("EMANET İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ.");
                                    daset.Tables["veri"].Clear();
                                    verilistele();
                                    txtUyeId.Text = "";
                                    lblKitapSayisi.Text = "";
                                    kitapsayisi();
                                }
                                else
                                {
                                    MessageBox.Show("ÖNCE ÜYE SEÇMELİSİNİZ!", "Uyarı");
                                }


                            }

                            else
                            {
                                MessageBox.Show("Bir üye üç kitaptan fazla kitap emanet alamaz!", "UYARI");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ÖNCE KİTAP EKLEMELİSİNİZ!", "Uyarı");
                        }
                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Sepet boş!", "Uyarı");
                }
               
            }

           
        }
        /*uye tablosundan tc ye göre listeleme yaptık*/

        private void btnUye_Click(object sender, EventArgs e)
        {
            PopupUyefrm popup1 = new PopupUyefrm();
            popup1.ShowDialog();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Popupkitapfrm popup2 = new Popupkitapfrm();
            popup2.ShowDialog();
        }

        private void txtKitapId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where Active is null and Id like'" + txtKitapId.Text + "'", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["KitapAdi"].ToString();
                txtYazari.Text = read["Yazari"].ToString();
            }
            connect.Close();
            if (txtKitapId.Text == "")
            {
                foreach (Control item in grpkitap.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void txtUyeId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlCommand komut = new SqlCommand("select *from uye where Active is null and Id like '" + txtUyeId.Text + "'", connect);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtTc.Text = read["Tc"].ToString();
                txtAdSoyad.Text = read["AdSoyad"].ToString();
            }
            connect.Close();

            connect.Open();
            SqlCommand komut_2 = new SqlCommand("select sum(KitapSayisi) from emanet where UyeId='" + txtUyeId.Text + "'", connect);
            lblKayitliKitap.Text = komut_2.ExecuteScalar().ToString();
            connect.Close();
            if (txtUyeId.Text == "")
            {
                foreach (Control item in grpuye.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                lblKayitliKitap.Text = "";
            }
        }


    }
    }
