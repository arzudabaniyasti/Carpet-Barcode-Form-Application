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
using DevExpress.XtraReports.UI;

namespace SIRMA_CARPET
{
    public partial class Barkod : Form
    {
        sql_connection connect=new sql_connection();
        public Barkod()
        {
            InitializeComponent();
        }
        private void Barkod_Load(object sender, EventArgs e)
        {
            konfeksiyon_listele();
            siparis_no_listele();


        }
        void konfeksiyon_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT s.mal_kodu,b.ean13_barkod_no as EAN13, b.upca_barkod_son AS UPCA,s.siparis_no as 'Sipariş Numarası' from tbl_barkod b inner join tbl_konfeksiyon k on k.barkod_id=b.barkod_id inner join tbl_siparis s on s.id = k.siparis_id where s.siparis_no='"+siparis_numarasi+"'order by s.siparis_no, upca_barkod_son", connect.connection());
            da.Fill(dt);
            konfeksiyon_grid.DataSource = dt;
            konfeksiyon_grid.Refresh();
        }
        void siparis_no_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select siparis_no as 'Sipariş Numarası' from tbl_siparis where uretildi = 'True' group by siparis_no", connect.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
        }
       

        private void barcodes_view_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ean13_text_edit.Text = barcodes_view.GetDataRow(barcodes_view.FocusedRowHandle)["EAN13"].ToString();
            upca_text_edit.Text = barcodes_view.GetDataRow(barcodes_view.FocusedRowHandle)["UPCA"].ToString();
           
            //select barkod_id from tbl_barkod  where upca_barkod_son=169010002
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 report2 = new XtraReport1();
            report2.Parameters["parameter1"].Value = upca_text_edit.Text;
            ReportPrintTool tool = new ReportPrintTool(report2);
            tool.ShowPreviewDialog();
        }
        string siparis_numarasi="aa";
        private void siparis_grid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            siparis_numarasi = siparis_grid.GetDataRow(siparis_grid.FocusedRowHandle)["Sipariş Numarası"].ToString();
            konfeksiyon_listele();
        }


        //ean13_text_edit.Text =barcodes_view.GetRowCellValue(e.RowHandle, "EAN13").ToString();
        // upca_text_edit.Text = barcodes_view.GetRowCellValue(e.RowHandle, "UPCA").ToString();


        // uretildi_siparis_id = gridView1.GetRowCellValue(e., "EAN13").ToString();

        //upca barkod son siparis idye göre
        // select b.upca_barkod_son from tbl_barkod b where b.id = (select k.barkod_id from tbl_konfeksiyon k where k.siparis_id = 17)

    }
}
