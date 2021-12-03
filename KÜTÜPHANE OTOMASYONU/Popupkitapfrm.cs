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
    public partial class Popupkitapfrm : Form
    {
        public Popupkitapfrm()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();

        private void booklist()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap where active is null ", connect);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connect.Close();
        }
        private void txtAraId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["Kitap"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap where active is null and Id like '%" + txtAraId.Text + "%'", connect);
            adtr.Fill(daset, "Kitap");
            connect.Close();
            if (txtAraId.Text == "")
            {
                daset.Tables["kitap"].Clear();
                booklist();
            }
        }

        private void Popupkitapfrm_Load(object sender, EventArgs e)
        {
            booklist();
        }

        private void txtAraKitapAdi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["Kitap"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap where active is null and KitapAdi like '%" + txtAraKitapAdi.Text + "%'", connect);
            adtr.Fill(daset, "Kitap");
            connect.Close();
            if (txtAraKitapAdi.Text == "")
            {
                daset.Tables["kitap"].Clear();
                booklist();
            }
        }

        private void txtAraYazari_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["Kitap"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap where active is null and Yazari like '%" + txtAraYazari.Text + "%'", connect);
            adtr.Fill(daset, "Kitap");
            connect.Close();
            if (txtAraYazari.Text == "")
            {
                daset.Tables["kitap"].Clear();
                booklist();
            }
        }
    }
}
