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
    public partial class PopupUyefrm : Form
    {
        public PopupUyefrm()
        {
            InitializeComponent();
        }
        
        DataSet daset = new DataSet();
        private void uyelist()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where active is null", connect);
            adtr.Fill(daset, "uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            connect.Close();
        }

        private void PopupUyefrm_Load(object sender, EventArgs e)
        {
            uyelist();
        }

        private void txtAraId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["uye"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where active is null and Id like '%" + txtAraId.Text + "%'", connect);
            adtr.Fill(daset, "uye");
            connect.Close();
            if (txtAraId.Text == "")
            {
                daset.Tables["uye"].Clear();
                uyelist();
            }
        }

        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["uye"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where active is null and Tc like '%" + txtAraTc.Text + "%'", connect);
            adtr.Fill(daset, "uye");
            connect.Close();
            if (txtAraTc.Text == "")
            {
                daset.Tables["uye"].Clear();
                uyelist();
            }
        }

        private void txtAraAdSoyad_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["uye"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye where active is null and AdSoyad like '%" + txtAraAdSoyad.Text + "%'", connect);
            adtr.Fill(daset, "uye");
            connect.Close();
            if (txtAraAdSoyad.Text == "")
            {
                daset.Tables["uye"].Clear();
                uyelist();
            }
        }
    }
}
