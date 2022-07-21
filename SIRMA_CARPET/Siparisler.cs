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

namespace SIRMA_CARPET
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }
        sql_connection connect = new sql_connection();
        private void Siparisler_Load(object sender, EventArgs e)
        {
            siparis_listele();
            konfeksiyon_listele();
            ebat_combobox();
            renk_combobox();
            desen_combobox();
            sekil_combobox();
            kalite_combobox();

        }
        void siparis_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select_siparis", connect.connection());
            da.Fill(dt);
            siparisler_grid.DataSource = dt;
        }
        void konfeksiyon_listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select_siparis_konfeksiyon", connect.connection());
            da.Fill(dt);
            konfeksiyon_grid.DataSource = dt;
            konfeksiyon_grid.Refresh();
        }
        void ebat_combobox()
        {
            SqlCommand ebat_combobox = new SqlCommand("Select CONCAT(m2,' m2 / ',en,'x',boy) from tbl_ebat order by m2", connect.connection());
            SqlDataReader dataReader_ebat = ebat_combobox.ExecuteReader();
            while (dataReader_ebat.Read())
            {
                ebat_comboBoxEdit.Properties.Items.Add(dataReader_ebat[0]);
            }
            connect.connection().Close();
        }
        void renk_combobox()
        {
            SqlCommand renk_combobox = new SqlCommand("Select renk_tanımı from tbl_renk order by renk_tanımı", connect.connection());
            SqlDataReader dataReader_renk = renk_combobox.ExecuteReader();
            while (dataReader_renk.Read())
            {
                renk_comboBoxEdit.Properties.Items.Add(dataReader_renk[0]);
            }
            connect.connection().Close();
        }
        void desen_combobox()
        {
            SqlCommand desen_combobox = new SqlCommand("Select desen_kodu from tbl_desen order by desen_kodu", connect.connection());
            SqlDataReader dataReader_desen = desen_combobox.ExecuteReader();
            while (dataReader_desen.Read())
            {
                desen_comboBoxEdit.Properties.Items.Add(dataReader_desen[0]);
            }
            connect.connection().Close();
        }
        void sekil_combobox()
        {
            SqlCommand sekil_combobox = new SqlCommand("Select ad from tbl_sekil order by ad", connect.connection());
            SqlDataReader dataReader_sekil = sekil_combobox.ExecuteReader();
            while (dataReader_sekil.Read())
            {
                sekil_comboBoxEdit.Properties.Items.Add(dataReader_sekil[0]);
            }
            connect.connection().Close();
        }
        void kalite_combobox()
        {
            SqlCommand kalite_combobox = new SqlCommand("Select kalite_kodu from tbl_kalite order by kalite_kodu", connect.connection());
            SqlDataReader dataReader_kalite = kalite_combobox.ExecuteReader();
            while (dataReader_kalite.Read())
            {
                kalite_comboBoxEdit.Properties.Items.Add(dataReader_kalite[0]);
            }
            connect.connection().Close();
        }
      
        String siparis_no;
        int ebat_id;
        String sekil_id;
        String renk_id;
        int next_siparis_no;
        int temp;
 
        String uretildi_siparis_no;
        String uretildi_siparis_id;
        int uretildi_siparis_adet;
        String mal_kodu;
        String urun_kodu;
        int barkodID;
        String upca_barkod;
        Boolean control;
        List<KeyValuePair<string, string>> urun_kodu_mal_kodu_pair_list = new List<KeyValuePair<string, string>>();
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            uretildi_siparis_no = gridView1.GetRowCellValue(e.RowHandle, "Sipariş Numarası").ToString();
            uretildi_siparis_id = gridView1.GetRowCellValue(e.RowHandle, "Sıra No").ToString();
            uretildi_siparis_adet = Convert.ToInt16(gridView1.GetRowCellValue(e.RowHandle, "Adet").ToString());
            //en son ürün kodunu getir
            SqlCommand urun_kodu_getir = new SqlCommand("SELECT TOP 1 urun_kodu FROM tbl_barkod ORDER BY urun_kodu DESC", connect.connection());

            SqlDataReader urun_kodu_reader = urun_kodu_getir.ExecuteReader();
            while (urun_kodu_reader.Read())
            {
                urun_kodu = urun_kodu_reader[0].ToString(); 
            }
            //en son barkod id getir and +1
            SqlCommand barkodID_getir = new SqlCommand("SELECT TOP 1 barkod_id FROM tbl_barkod ORDER BY id DESC", connect.connection());

            SqlDataReader barkodID_reader = barkodID_getir.ExecuteReader();
            while (barkodID_reader.Read())
            {
                barkodID = (Convert.ToInt16(barkodID_reader[0])+1);
            }
            //en son upca getir and +1
            SqlCommand upca_barkod_getir = new SqlCommand("SELECT TOP 1 upca_barkod_son FROM tbl_barkod ORDER BY id DESC", connect.connection());

            SqlDataReader upca_barkod_reader = upca_barkod_getir.ExecuteReader();
            while (upca_barkod_reader.Read())
            {
               upca_barkod = (Convert.ToInt64(upca_barkod_reader[0])).ToString();
            }

            //ürün kodu ataması yap
            SqlCommand select_mal_kodu = new SqlCommand("select mal_kodu from tbl_siparis where id = @p1", connect.connection());
            select_mal_kodu.Parameters.AddWithValue("@p1", uretildi_siparis_id);
            SqlDataReader mal_kodu_reader = select_mal_kodu.ExecuteReader();
            while (mal_kodu_reader.Read())
            {
                mal_kodu = mal_kodu_reader[0].ToString();
            }

            foreach (var element in urun_kodu_mal_kodu_pair_list)
            {
                if (element.Key == mal_kodu)
                {
                    control = true;
                    urun_kodu = element.Value;
                    break;
                }
                else
                {
                    control = false;
                }
            }
            if (control != true)
            {
                urun_kodu = (Convert.ToInt16(urun_kodu) + 1).ToString();
                urun_kodu_mal_kodu_pair_list.Add(new KeyValuePair<string, string>(mal_kodu, urun_kodu));
                
            }
            
            // Update uretildi boolean
            SqlCommand update_uretildi = new SqlCommand("update tbl_siparis set uretildi='True' where id=@p1", connect.connection());
            update_uretildi.Parameters.AddWithValue("@p1", uretildi_siparis_id);
            update_uretildi.ExecuteNonQuery();
            connect.connection().Close();
            //insert barkod table
            for (int i = 0; i < uretildi_siparis_adet; i++)
            {
                upca_barkod = (Convert.ToInt64(upca_barkod)+1).ToString();
    
                SqlCommand insert_barkod = new SqlCommand("insert into tbl_barkod (barkod_id,ean13_barkod_no,upca_barkod_son,urun_kodu) values (@p1,@p2,@p3,@p4)", connect.connection());
                //ean13 oluştur
                String ean_barkod = CalculateEan13("869", "1690", urun_kodu);
                insert_barkod.Parameters.AddWithValue("@p1", barkodID);
                insert_barkod.Parameters.AddWithValue("@p2", ean_barkod);
                insert_barkod.Parameters.AddWithValue("@p3", upca_barkod);
                insert_barkod.Parameters.AddWithValue("@p4", urun_kodu);
                insert_barkod.ExecuteNonQuery();
            }
            
            
            connect.connection().Close();
            //insert konfeksiyon
            SqlCommand insert_konfeksiyon = new SqlCommand("insert into tbl_konfeksiyon (barkod_id,siparis_id) values (@p1,@p2)", connect.connection());
          
            insert_konfeksiyon.Parameters.AddWithValue("@p1", barkodID);
            insert_konfeksiyon.Parameters.AddWithValue("@p2", Convert.ToInt16(uretildi_siparis_id));
            insert_konfeksiyon.ExecuteNonQuery();
            connect.connection().Close();

    
       
            //  gridView1.GetRow(e.RowHandle).hidde
       
            siparis_listele();
            konfeksiyon_listele();
        }
       
        Boolean tamamla_buton_click=true;
        Boolean mal_kodu_control=false; 
        private void siparis_ekle_buton_Click(object sender, EventArgs e)
        {

            //EN SON KAYDIN SIPARIS NUMARASINI GETIR
            SqlCommand siparis_no_getir = new SqlCommand("SELECT TOP 1 siparis_no FROM tbl_siparis ORDER BY id DESC", connect.connection());

            SqlDataReader siparis_no_reader = siparis_no_getir.ExecuteReader();
            while (siparis_no_reader.Read())
            {
                siparis_no = siparis_no_reader[0].ToString(); //sırma_03
            }
            //SIPARIS NUMARASINI BIR ARTTIR
            if (tamamla_buton_click == true)
            {               
                temp = siparis_no.IndexOf("_");
                next_siparis_no = Convert.ToInt32(siparis_no.ToString().Substring(temp + 1)) + 1;
                siparis_no = siparis_no.Replace(siparis_no.ToString().Substring(temp + 1), next_siparis_no.ToString());//sırma_04
                //SIPARIS DEVAM EDIYOR
                tamamla_buton_click =false;
            }
            String en = "0", boy;
            //EBAT COMBOBOXTAN EN GETIR
            if (ebat_comboBoxEdit.Text.Length == 16)
            {
                en = ebat_comboBoxEdit.Text.Substring(10, 2);
            }
            if (ebat_comboBoxEdit.Text.Length == 17)
            {
                en = ebat_comboBoxEdit.Text.Substring(10, 3);
            }
            //EBAT COMBOBOXTAN BOY GETIR
            temp = ebat_comboBoxEdit.Text.IndexOf("x");
            boy = ebat_comboBoxEdit.Text.Substring(temp + 1);
            //EN VE BOYDAN EBAT ID GETIR 
            SqlCommand ebat_id_getir = new SqlCommand("select id from tbl_ebat where en = @en_parameter and boy = @boy_parameter", connect.connection());
            ebat_id_getir.Parameters.AddWithValue("@en_parameter", en);
            ebat_id_getir.Parameters.AddWithValue("@boy_parameter", boy);
            SqlDataReader ebat_reader = ebat_id_getir.ExecuteReader();
            while (ebat_reader.Read())
            {
                ebat_id = Convert.ToInt16(ebat_reader[0]);
            }

            //COMBOBOXTAKI SEKLİN KODUNU GETIR
            SqlCommand sekil_id_getir = new SqlCommand("select id from tbl_sekil where ad=@sekil", connect.connection());
            sekil_id_getir.Parameters.AddWithValue("@sekil", sekil_comboBoxEdit.Text);
            SqlDataReader sekil_reader = sekil_id_getir.ExecuteReader();
            while (sekil_reader.Read())
            {
                sekil_id = sekil_reader[0].ToString();
            }

            //COMBOBOXTAKI RENGİN KODUNU GETIR
            SqlCommand renk_id_getir = new SqlCommand("select renk_kodu from tbl_renk where renk_tanımı=@renk", connect.connection());
            renk_id_getir.Parameters.AddWithValue("@renk", renk_comboBoxEdit.Text);
            SqlDataReader renk_reader = renk_id_getir.ExecuteReader();
            while (renk_reader.Read())
            {
                renk_id = renk_reader[0].ToString();
            }
            //MAL KODU OLUŞTUR
            String malkodu = kalite_comboBoxEdit.Text + "_" + desen_comboBoxEdit.Text + "_" + en + sekil_id + renk_id + boy;
            //MAL KODU KONTROL
            SqlCommand mal_kodu_control_command = new SqlCommand("select mal_kodu from tbl_siparis where siparis_no=@p1", connect.connection());
            mal_kodu_control_command.Parameters.AddWithValue("@p1", siparis_no);
            SqlDataReader mal_kodu_control_reader = mal_kodu_control_command.ExecuteReader();
            while (mal_kodu_control_reader.Read())
            {
                //AYNI MALKODUNA AIT BAŞKA BIR SİPARİŞ VARSA TABLODAKİ KAYDI GUNCELLE
                if (mal_kodu_control_reader[0].ToString() == malkodu) 
                {
                    mal_kodu_control = true;
                    SqlCommand update_siparis = new SqlCommand("update tbl_siparis set adet=adet+@p1 where siparis_no=@p2 and mal_kodu=@p3", connect.connection());
                    update_siparis.Parameters.AddWithValue("@p1", Convert.ToInt16(adet_numericUpDown.Value));
                    update_siparis.Parameters.AddWithValue("@p2", siparis_no);
                    update_siparis.Parameters.AddWithValue("@p3", malkodu);
                    update_siparis.ExecuteNonQuery();
                }
                
            }
            //AYNI MALKODUNA AIT BAŞKA BIR SİPARİŞ YOKSA TABLOYA YENİ KAYIT EKLE
            if (mal_kodu_control != true)
            {
                SqlCommand insert_siparis = new SqlCommand("insert into tbl_siparis (siparis_no,ebat_id,renk_id,desen_id,sekil_id,kalite_id,adet,mal_kodu,uretildi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,'False')", connect.connection());
                insert_siparis.Parameters.AddWithValue("@p1", siparis_no);
                insert_siparis.Parameters.AddWithValue("@p2", ebat_id);
                insert_siparis.Parameters.AddWithValue("@p3", renk_id);
                insert_siparis.Parameters.AddWithValue("@p4", desen_comboBoxEdit.Text);
                insert_siparis.Parameters.AddWithValue("@p5", sekil_id);
                insert_siparis.Parameters.AddWithValue("@p6", kalite_comboBoxEdit.Text);
                insert_siparis.Parameters.AddWithValue("@p7", Convert.ToInt16(adet_numericUpDown.Value));
                insert_siparis.Parameters.AddWithValue("@p8", malkodu);              
                insert_siparis.ExecuteNonQuery();
            }
            connect.connection().Close();       
        }

        private void siparis_tamamla_buton_Click(object sender, EventArgs e)
        {
            //SİPARİŞ TAMAMLANDIKTAN SONRA EKLENEN TÜM SİPARİŞLER İÇİN AYNI ZAMAN VE TARIH ATAMASI YAPILIR
            SqlCommand update_siparis = new SqlCommand("UPDATE tbl_siparis SET date=@p1,time=@p2 WHERE siparis_no=@p3", connect.connection());
            update_siparis.Parameters.AddWithValue("@p1", DateTime.Now.Date);
            update_siparis.Parameters.AddWithValue("@p2", DateTime.Now.ToShortTimeString());
            update_siparis.Parameters.AddWithValue("@p3", siparis_no);
            update_siparis.ExecuteNonQuery();
            connect.connection().Close();
            //SIPARIS TAMAMLANDI 
            tamamla_buton_click = true;
            //CLEAR TOOLBOX
            ebat_comboBoxEdit.ResetText();
            renk_comboBoxEdit.ResetText();
            desen_comboBoxEdit.ResetText();
            sekil_comboBoxEdit.ResetText();
            kalite_comboBoxEdit.ResetText();
            adet_numericUpDown.ResetText();
            siparis_listele();
        }
        public static string CalculateEan13(string country, string manufacturer, string product)
        {
            string temp = $"{country}{manufacturer}{product}";
            int sum = 0;
            int digit = 0;

            // Calculate the checksum digit here.
            for (int i = temp.Length; i >= 1; i--)
            {
                digit = Convert.ToInt32(temp.Substring(i - 1, 1));
                // This appears to be backwards but the 
                // EAN-13 checksum must be calculated
                // this way to be compatible with UPC-A.
                if (i % 2 == 0)
                { // odd  
                    sum += digit * 3;
                }
                else
                { // even
                    sum += digit * 1;
                }
            }
            int checkSum = (10 - (sum % 10)) % 10;
            return $"{temp}{checkSum}";
        }
    }
}
