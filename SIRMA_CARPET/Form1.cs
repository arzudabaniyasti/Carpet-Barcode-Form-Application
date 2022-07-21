using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIRMA_CARPET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Siparisler siparisler_form;
        Barkod barkod_form;
        private void siparisler_buton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (siparisler_form == null) 
            { 
                siparisler_form = new Siparisler();
                siparisler_form.MdiParent = this;
                siparisler_form.Show();
                
            }

        }

        private void barkod_buton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barkod_form == null)
            {
                barkod_form = new Barkod();
                barkod_form.MdiParent = this;
                barkod_form.Show();
              
            }
        }
    }
}
