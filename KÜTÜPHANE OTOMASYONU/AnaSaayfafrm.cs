using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÜTÜPHANE_OTOMASYONU
{
    public partial class AnaSaayfafrm : Form
    {
        public AnaSaayfafrm()
        {
            InitializeComponent();
        }
        //Formları ana sayfada birbirine bağlama işlemleri yapıldı.
        private void btnUye_Click(object sender, EventArgs e)
        {
            ÜyeDüzenlefrm uyeekle = new ÜyeDüzenlefrm ();
            uyeekle.ShowDialog();
        }

        private void btnUyelist_Click(object sender, EventArgs e)
        {
            UyeListfrm uyelist = new UyeListfrm();
            uyelist.ShowDialog();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapekle = new KitapEklefrm();
            kitapekle.ShowDialog();
        }

        private void btnKitaplist_Click(object sender, EventArgs e)
        {
            KitapIslemlerifrm kitapislemleri = new KitapIslemlerifrm();
            kitapislemleri.ShowDialog();
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanet = new EmanetIslemleri();
            emanet.ShowDialog();
        }

        private void btnEmanetlist_Click(object sender, EventArgs e)
        {
            EmanetListelemefrm Emanetlistele = new EmanetListelemefrm();
            Emanetlistele.ShowDialog();
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            EmanetTeslimfrm Teslim = new EmanetTeslimfrm();
            Teslim.ShowDialog();
        }
    }
}
