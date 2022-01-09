using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml;

namespace borsaProjesi
{
    public partial class AdminForm : Form
    {
        private string sorgu = "";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Kullanicilar_datagridview.ColumnHeadersVisible = false;
            Kullanicilar_datagridview.ReadOnly = true;
            Urunler_datagridview.ColumnHeadersVisible = false;
            Urunler_datagridview.ReadOnly = true; 
            AdminFormOnLoad();
        }
        public void AdminFormOnLoad()
        {
            Kullanicikontrol_tarih_label.Text = "Tarih : " + DateTime.Parse(DateTime.Now.ToShortDateString()).ToShortDateString();// tarih anasayfa
            Tarihurunkontrol_label.Text = "Tarih : " + DateTime.Parse(DateTime.Now.ToShortDateString()).ToShortDateString();// tarih profilim
            double kasabutce = 0;
            Singleton.Instance.islem.KasaKomisyon(kasabutce);
            kasagelir_lbl.Text = "Kasa Geliri: " + Singleton.Instance.currentUser.kasabutce.ToString() + " TL";
            UyecomboBox();
            UrunlerComboBox();
            ClearTxts();
        }
        private void UyecomboBox()
        {
            secenekler_combobox.Items.Clear();
            secenekler_combobox.Text="Tüm Uyeler";
            secenekler_combobox.Items.Add("Tüm Uyeler");
            secenekler_combobox.Items.Add("Islem Bekleyenler");

            sorgu = "SELECT * FROM Uyeler";
            Kullanicilar_datagridview.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
        }
        private void UrunlerComboBox()
        {    
            urunler_combobox.Items.Clear();
            urunler_combobox.Text = "Tüm Ürünler";
            urunler_combobox.Items.Add("Tüm Ürünler");
            urunler_combobox.Items.Add("Onaylanan Ürünler");
            urunler_combobox.Items.Add("Onay Bekleyen Ürünler");

            sorgu = "SELECT * FROM showUruns";
            Urunler_datagridview.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            ClearTxts();
         
            baslik_label.Text = secenekler_combobox.Text;
            if (secenekler_combobox.Text == "Islem Bekleyenler")
                sorgu = "SELECT * FROM PasifBakiyeler";
            if (secenekler_combobox.Text == "Tüm Uyeler" || secenekler_combobox.Text=="")
               sorgu = "SELECT * FROM Uyeler";           
            Kullanicilar_datagridview.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
        }
        private void Onayla_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(pasifbakiye_txt.Text) > 0 && doviz_txt.Text=="TL")
            {
                DialogResult dialogResult = MessageBox.Show("Bakiyeyi Onaylamak istediğinize eminmisiniz ?", "Bakiye Onaylansın mı ?", MessageBoxButtons.YesNo);
            
                if (dialogResult == DialogResult.Yes)
                {
                    double bakiye = Convert.ToDouble(bakiye_txt.Text);
                    double artismiktari = Convert.ToDouble(pasifbakiye_txt.Text);
                    bakiye += artismiktari;
                    Singleton.Instance.islem.BakiyeOnay(username_txt.Text, bakiye);                  
                    MessageBox.Show("Bakiye onaylama işlemi tamamlandı.", "Bakiye Onay");
                    secenekler_combobox.Text = "Tüm Üyeler";
                    Listele();
                }
            }
            else if (doviz_txt.Text != "TL")
            {
                MessageBox.Show("Onay oncesi dovizi TL birimine cevirmelisiniz.", "Hata Kodu: 1");
            }   
        }
        public void ClearTxts()
        {
            bakiye_txt.Text = "";
            pasifbakiye_txt.Text = "";
            username_txt.Text = "";
            doviz_txt.Text = "";
            ParaBirimiVisibleControl(false);
        }
        private void Urunlerlistele_btn_Click(object sender, EventArgs e)
        {
            UrunListele();
        }
        private void UrunListele()
        {
            urunkodu_txt.Text = "";
            onaycontrol_label.Text = ""; 

            urunbaslik_label.Text = urunler_combobox.Text;
            if (urunler_combobox.Text == "Tüm Ürünler")
                sorgu = "SELECT * FROM showUruns";
            if (urunler_combobox.Text == "Onaylanan Ürünler")
                sorgu = "SELECT * FROM showUruns WHERE urunOnay='" + "Onaylandı" + "'";
            if (urunler_combobox.Text == "Onay Bekleyen Ürünler")
                sorgu = "SELECT * FROM showUruns WHERE urunOnay='" + "Onaylanmadı" + "'";
            Urunler_datagridview.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);

        }
        private void Urunonayla_btn_Click(object sender, EventArgs e)
        {
            if (onaycontrol_label.Text == "Onaylanmadı")
            {
                DialogResult dialogResult = MessageBox.Show("Urun Onaylamak istediğinize eminmisiniz ?", "Urun Onaylansın mı ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Singleton.Instance.islem.UrunOnay(urunkodu_txt.Text);
                    UrunListele();
                    MessageBox.Show("Urun onaylama işlemi tamamlandı.", "Kullanıcı Onay");
                }
                else if (dialogResult == DialogResult.No) MessageBox.Show("Urun onaylama işlemi tamamlandı.", "Kullanıcı Onay");
            }
            else if (onaycontrol_label.Text == "Onaylandı")MessageBox.Show("Seçtiğiniz kullanıcı zaten onaylanmış.", "****");         
            else MessageBox.Show("Lütfen bir ürün  seçiniz.", "****");       
        }
        private void Kullanicilar_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Kullanicilar_datagridview.CurrentRow.Selected = true;
            username_txt.Text = Kullanicilar_datagridview.Rows[e.RowIndex].Cells["UserName"].FormattedValue.ToString();
            bakiye_txt.Text = Kullanicilar_datagridview.Rows[e.RowIndex].Cells["hesapBakiye"].FormattedValue.ToString();
            pasifbakiye_txt.Text =  Kullanicilar_datagridview.Rows[e.RowIndex].Cells["geciciBakiye"].FormattedValue.ToString();
            doviz_txt.Text = Kullanicilar_datagridview.Rows[e.RowIndex].Cells["parabirimi"].FormattedValue.ToString();

            if(pasifbakiye_txt.Text != "")
            {
                if (Convert.ToDouble(pasifbakiye_txt.Text) > 0)
                {
                    ParaBirimiVisibleControl(true);
                    onayla_btn.Visible = true;
                }
                else
                {
                    ParaBirimiVisibleControl(false);
                    onayla_btn.Visible = false;
                }
            }
        }
        private void ParaBirimiVisibleControl(bool deger)
        {
            if (deger)
            {
                parabirimibaslik.Visible = true;
                doviz_txt.Visible = true;
                donustur_btn.Visible = true;
            }
            else
            {
                parabirimibaslik.Visible = false;
                doviz_txt.Visible = false;
                donustur_btn.Visible = false;
            }
        }
        private void Urunler_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Urunler_datagridview.CurrentRow.Selected = true;
            onaycontrol_label.Text = Urunler_datagridview.Rows[e.RowIndex].Cells["urunOnay"].FormattedValue.ToString();
            urunkodu_txt.Text = Urunler_datagridview.Rows[e.RowIndex].Cells["urunBarkodNo"].FormattedValue.ToString();
        }
        private void donustur_btn_Click(object sender, EventArgs e)
        {
            try { 
                if(doviz_txt.Text != "TL")
                {                  
                    string link= "https://www.tcmb.gov.tr/kurlar/today.xml";
                    var xml = new XmlDocument();
                    xml.Load(link);
                    DateTime tarih = Convert.ToDateTime(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                    string conversionRate = xml.SelectSingleNode("Tarih_Date/Currency [@Kod='"+ doviz_txt.Text +"']/BanknoteSelling").InnerXml;

                    double onayBekleyenHesapBakiyesi = Convert.ToDouble(pasifbakiye_txt.Text);       
                    double virgullubakiye = onayBekleyenHesapBakiyesi * Convert.ToDouble(conversionRate.Replace(".",","));
                    double newBekleyenBakiye = Math.Round(virgullubakiye, 1);

                    Singleton.Instance.islem.GeciciBakiyeDegistirWithUsurname(username_txt.Text, newBekleyenBakiye);                  
                    MessageBox.Show(tarih.ToShortDateString() + " Tarihindeki kur bilgilerine göre paranız  donusturuldu .\n\n"+ onayBekleyenHesapBakiyesi.ToString()+" "+ doviz_txt.Text +" --> "+newBekleyenBakiye.ToString()+" TL ." );
                    AdminFormOnLoad();
                }
                else
                {
                    MessageBox.Show("Para Biriminiz Zaten TL");
                }
            }
            catch(Exception ex){
                MessageBox.Show("Hata kod: " + ex.ToString());
            }
        }
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.girisctr);
        }
    }
}
