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
    public partial class EmanetTeslimfrm : Form
    {
        public EmanetTeslimfrm()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();
        DataTable dt = new DataTable();
        /*listeleme metodu oluşturduk*/
        private void list()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where active is null", connect);
            adtr.Fill(daset, "emanet");
            dataGridView1.DataSource = daset.Tables["emanet"];
            connect.Close();
        }
        /*private void EmanetTeslim()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            
            SqlCommand komut = new SqlCommand("Select uye.Id, uye.Tc,uye.AdSoyad,kitap.Id,kitap.KitapAdi,kitap.Yazari from emanet inner join uye on uye.Id = emanet.UyeId inner join kitap  on  kitap.Id = emanet.KitapId ", connect);
            SqlDataAdapter adtr = new SqlDataAdapter(komut);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }*/
        private void EmanetTeslimfrm_Load(object sender, EventArgs e)
        {
            list();
            //EmanetTeslim();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            DialogResult dialog;
            dialog = MessageBox.Show("Emanet teslim alınsın mı?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    connect.Open();

                    SqlCommand komut = new SqlCommand("update emanet set active=1 where IslemId=@IslemId", connect);
                    komut.Parameters.AddWithValue("@IslemId", dataGridView1.CurrentRow.Cells["IslemId"].Value.ToString());
                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("İADE İŞLEMİ BAŞARILI");
                    daset.Tables["emanet"].Clear();
                    list();
                    //EmanetTeslim();
                }
                else
                {
                    MessageBox.Show("Olmayan bir emanet kaydını teslim edemezsiniz!", "Uyarı");
                }
            }

        }


        private void btnUye_Click(object sender, EventArgs e)
        {
            PopupUyefrm popup_1 = new PopupUyefrm();
            popup_1.ShowDialog();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Popupkitapfrm popup_2 = new Popupkitapfrm();
            popup_2.ShowDialog();
        }

        private void txtAraKitapId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["emanet"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where active is null and KitapId like '" + txtAraKitapId.Text + "'", connect);
            adtr.Fill(daset, "emanet");
            connect.Close();
            if (txtAraKitapId.Text == "")
            {
                daset.Tables["emanet"].Clear();
                list();
                //EmanetTeslim();
            }
        }

        private void txtAraUyeId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["emanet"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where active is null and UyeId like '" + txtAraUyeId.Text + "'", connect);
            adtr.Fill(daset, "emanet");
            connect.Close();
            if (txtAraUyeId.Text == "")
            {
                daset.Tables["emanet"].Clear();
                list();
                //EmanetTeslim();
            }
        }
    }
}

