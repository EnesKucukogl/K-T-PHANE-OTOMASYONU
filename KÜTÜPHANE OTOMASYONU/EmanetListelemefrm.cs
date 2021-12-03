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
    public partial class EmanetListelemefrm : Form
    {
        public EmanetListelemefrm()
        {
            InitializeComponent();
        }
       
        DataSet daset = new DataSet();
        /*emanetleri listelemek için method yazdık*/
        private void EmanetListele()
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where active is null", connect);
            adtr.Fill(daset, "emanet");
            dataGridView1.DataSource = daset.Tables["emanet"];
            connect.Close();
        }
        private void EmanetTeslimfrm_Load(object sender, EventArgs e)
        {
            EmanetListele();
            cmbFiltrele.SelectedIndex = 0;
        }
        /*filtreleme combobox edit ıtems bölümü ile ilgili koşullu sıralama yaptık*/
        private void cmbFiltrele_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
            daset.Tables["emanet"].Clear();
            if (cmbFiltrele.SelectedIndex ==0)
            {
                EmanetListele();
            }
            else if (cmbFiltrele.SelectedIndex == 1)
            {
                connect.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where'"+DateTime.Now.ToShortDateString()+"'>AlinacagiTarih", connect);
                adtr.Fill(daset, "emanet");
                dataGridView1.DataSource = daset.Tables["emanet"];
                connect.Close();
            }
            else if (cmbFiltrele.SelectedIndex == 2)
            {
                connect.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select *from emanet where'" + DateTime.Now.ToShortDateString() + "'<= AlinacagiTarih", connect);
                adtr.Fill(daset, "emanet");
                dataGridView1.DataSource = daset.Tables["emanet"];
                connect.Close();
            }
        }
    }
}
