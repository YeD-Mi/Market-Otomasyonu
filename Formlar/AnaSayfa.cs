using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace borsaProjesi
{
    public partial class MainScreen : Form
    {
      
        private string sorgu = "";
        public MainScreen()
        {
            InitializeComponent();    
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            MainScreenOnLoad();
        }
        public void MainScreenOnLoad()
        {
            Singleton.Instance.islem.SiparistenSatinAl();

            ParabirimiComboDoldur();
            Anasayfa_Tarih.Text = "Tarih : " + DateTime.Parse(DateTime.Now.ToShortDateString()).ToShortDateString();
            listeleCombo.Text = "Tüm Satışlarım";
            KendiSatislarim_CheckBox.Checked = true;
            KendiSatislarim_CheckBox.Checked = false;
            urunler_listbox.Items.Clear();
            satinalgrpbox.Visible = false;
            GuncelProfil();
        
        }
        private void ParabirimiComboDoldur()
        {
            Parabirimleri_combo.Items.Clear();
            Parabirimleri_combo.Items.Add("TL");
            Parabirimleri_combo.Items.Add("USD");
            Parabirimleri_combo.Items.Add("EUR");
            Parabirimleri_combo.Items.Add("GBP");
            Parabirimleri_combo.Items.Add("JPY");
            Parabirimleri_combo.Items.Add("SAR");
        }
        public void GuncelProfil()
        {
            puserid_label.Text = Singleton.Instance.currentUser.UserID.ToString();
            pusername_label.Text = Singleton.Instance.currentUser.UserName;
            puserpass_txt.Text = Singleton.Instance.currentUser.UserPass;
            profilad_label.Text = Singleton.Instance.currentUser.Ad;
            psoyad_label.Text = Singleton.Instance.currentUser.SoyAd;
            ptcno.Text = Singleton.Instance.currentUser.Tc.ToString();
            ptelefonno_txt.Text = Singleton.Instance.currentUser.Telefon.ToString();
            padres_txt.Text = Singleton.Instance.currentUser.Adres;
            p_emailtxt.Text = Singleton.Instance.currentUser.Eposta;
            main_ad.Text = Singleton.Instance.currentUser.Ad;
            bakiye_label.Text = Singleton.Instance.currentUser.Bakiye + " ₺";
            geciciBakiye_label.Text = Singleton.Instance.currentUser.PasifBakiye + " "+ Singleton.Instance.currentUser.ParaBirimi;
            bakiyelabel2_txt.Text = bakiye_label.Text;
            gecicibakiye2label_txt.Text = geciciBakiye_label.Text;
            kacadetalmak_txt.Text = "";       
        }
        private void OtosatinalPageLoad()
        {
            ListBoxDoldur();
            ListBoxControlEt();
        }
        public void ListBoxDoldur() => Singleton.Instance.islem.ListBoxDoldur(urunler_listbox);
        public void ListBoxControlEt()
        {
            int x;
            do
            {
              x = 0;
                for (int i = 0; i < urunler_listbox.Items.Count; i++)
                {
                    for (int j = i + 1; j < urunler_listbox.Items.Count; j++)
                    {
                        if (urunler_listbox.Items[i].ToString().ToLower() == urunler_listbox.Items[j].ToString().ToLower())
                        {
                            urunler_listbox.Items.RemoveAt(i);
                            x++;
                        }

                    }
                }
            } while (x >0);
            
        }
        private void Urunler_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (satinalgrpbox.Visible == false)
                satinalgrpbox.Visible = true;
            kacadetalmak_txt.Text = "";
            sorgu = "SELECT * FROM UrunGoster WHERE UrunName='" + urunler_listbox.SelectedItem.ToString() + "'  AND UrunMiktari>0  AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "'";
            urunusatanlar_datagrid.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
        }
        private void Otosatinal_btn_Click(object sender, EventArgs e)
        {
            if (SayiMi(kacadetalmak_txt.Text))
            {
                double toplampara = Singleton.Instance.islem.GetToplamPara(urunler_listbox.SelectedItem.ToString(), Convert.ToInt32(kacadetalmak_txt.Text));
                double kasakomisyon = toplampara / 100;
                double gereklibakiye = toplampara + kasakomisyon;
                double toplamadet = Singleton.Instance.islem.GetUrunToplamAdet(urunler_listbox.SelectedItem.ToString());
                if (Convert.ToInt32(kacadetalmak_txt.Text) > toplamadet)
                {
                    MessageBox.Show("Stok yetersiz,alabileceginiz maksimum miktar:" + toplamadet + " +  dir.");
                }
                else if (Singleton.Instance.currentUser.Bakiye < gereklibakiye)
                {
                    MessageBox.Show("Bu üründen " + kacadetalmak_txt.Text + "almak icin bakiyeniz yetersiz", "Bakiye Hatasi");
                }
                else if (Singleton.Instance.currentUser.Bakiye >= gereklibakiye)
                {
                    Singleton.Instance.islem.Otosatinal(urunler_listbox.SelectedItem.ToString(), Convert.ToInt32(kacadetalmak_txt.Text),kasakomisyon);
                }

            }
            else if (kacadetalmak_txt.Text == "")
                MessageBox.Show("Lütfen Kac Adet Almak istediginizi giriniz", "Tüm alanları doldurun");
            else
            {
                MessageBox.Show("Yanlis deger girdiniz.", "Hata!");
            }
        }
        private void Hangiurunu_listele_Click(object sender, EventArgs e) => OtosatinalPageLoad();
        private void Titlebakiye_label_MouseHover(object sender, EventArgs e)
        {
            geciciBakiye_label.Visible = true;
            unonay_label.Visible = true;
        }
        private void Titlebakiye_label_MouseLeave(object sender, EventArgs e)
        {
            geciciBakiye_label.Visible = false;
            unonay_label.Visible = false;
        }
        private void Satinal_btn_Click(object sender, EventArgs e)
        {
            double toplam = Convert.ToDouble(odenecektutar_label.Text);
            double kasakomisyon = Convert.ToDouble(odenecektutar_label.Text)/100;
            double geneltoplam =  toplam+kasakomisyon;
            string x;
            if (urunsaticilabel.Text == Singleton.Instance.currentUser.UserName)
            {
                MessageBox.Show("Kendi Ürününüzü Satın Alamazsınız", "Hatalı ürün seçimi");
            }
            else
            {
                DialogResult onay = MessageBox.Show("Bu ürünü almak için istedigine eminmisin Toplam Fiyat:" + geneltoplam.ToString() + " ₺", "Emin misin ?", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    if (geneltoplam > Singleton.Instance.currentUser.Bakiye)
                    {
                        double eksikbakiye = geneltoplam - Convert.ToInt32(Singleton.Instance.currentUser.Bakiye) ;
                        DialogResult dialogResult = MessageBox.Show("Bu ürünü almak için bakiyeniz yetersiz bu ürün için eksik bakiyeniz :" + eksikbakiye.ToString() + "₺ dir. Eksik Bakiyeyi Yüklemek istermisiniz", "Bakiye Yetersizliği !!!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Singleton.Instance.islem.GecicibakiyeGuncelle(eksikbakiye, "TL");
                        }
                    }
                    else if (geneltoplam > 0)
                    {
                        x = "Satin Alma Basarili";
                        Singleton.Instance.islem.UrunSatinAl(barkodno_label.Text, urunsaticilabel.Text, Convert.ToInt32(alinanadet_txt.Text), Convert.ToInt32(odenecektutar_label.Text), x, kasakomisyon);
                    }
                    MainScreenOnLoad();

                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }
            }
        }
        private void Bakiye_ekle_btn_Click(object sender, EventArgs e)
        {

            if (bakiyeekle_txt.Text == "" || Parabirimleri_combo.Text == "") 
            {
                MessageBox.Show("Para birimi ve turu girmediniz.");
            }
            else
            {
                if (Singleton.Instance.currentUser.PasifBakiye == 0)
                {
                    Singleton.Instance.islem.GecicibakiyeGuncelle(Convert.ToInt32(bakiyeekle_txt.Text),Parabirimleri_combo.Text);
                    ParabirimiComboDoldur();
                    bakiyeekle_txt.Text = "";
                    MainScreenOnLoad();
                }
                else
                {
                    MessageBox.Show("Eklediginiz tutar, onceki eklemenizin uzerine eklenmistir.", "Extra Bakiye Yukleme");
                    Singleton.Instance.currentUser.PasifBakiye = Singleton.Instance.currentUser.PasifBakiye + Convert.ToInt32(bakiyeekle_txt.Text);
                    Singleton.Instance.islem.GecicibakiyeGuncelle(Singleton.Instance.currentUser.PasifBakiye, Parabirimleri_combo.Text);
                    ParabirimiComboDoldur();
                    bakiyeekle_txt.Text = "";
                    MainScreenOnLoad();
                }
            }
        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (puserpass_txt.Text == ""||p_emailtxt.Text==""||padres_txt.Text==""||ptelefonno_txt.Text=="")
            {
                MessageBox.Show("Guncellenek alanlar boş bırakılamaz");
            }
            else
            {
                DialogResult onay = MessageBox.Show("Güncellemek istediginize eminmisiniz  ?", "Kullanıcı Güncellensin mi ?", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    Singleton.Instance.islem.UserUpdate(puserpass_txt, p_emailtxt, padres_txt, ptelefonno_txt);
                    MessageBox.Show("Güncelleme işlemi tamamlandı.");
                }
                else if (onay == DialogResult.No)
                {
                    MessageBox.Show("Güncelleme işlemi iptal edildi.");

                }
            }
            GuncelProfil();
        }
        private void BenimSattiklarim_btn_Click(object sender, EventArgs e) => ListeleComboBoxControl();
        private void Add_urun_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.islem.UrunEkle(add_barkodno, urunbirimibox, add_urunfiyati, add_urunmiktari, add_urunname, add_urunturu, Singleton.Instance.currentUser.UserName, guncelle_gb);
            MessageBox.Show("Urun listeye eklenmistir. Onay sonrasi pazarda goruntulenecektir.", "Urun Eklendi");
            ListeleComboBoxControl();
            add_barkodno.Text = "";
            add_urunname.Text = "";
            add_urunmiktari.Text = "";
            add_urunfiyati.Text = "";
            add_urunturu.Text = "";
        }
        private void Urun_guncelle_btn_Click(object sender, EventArgs e)
        {
            if (SayiMi(g_urunfiyati.Text) && SayiMi(g_urunmiktari.Text))
            {
             
                if (Convert.ToInt32(g_urunfiyati.Text) <= 0 || Convert.ToInt32(g_urunmiktari.Text) <= 0)
                {
                    MessageBox.Show("Lütfen 0 dan farklı pozitif sayılar giriniz.", "Hatalı urun güncellemesi");
                }
                else
                {
                   
                    Singleton.Instance.islem.UrunUpdate(g_urunfiyati, g_urunmiktari, g_urunbarkod.Text,guncelle_gb);
                    MessageBox.Show("Urun guncellendi admin onayı bekleniyor","Urun güncelleme Başarılı");
               
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir deger girin");
            }
            ListeleComboBoxControl();
        }
        static bool SayiMi(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void CheckBoxcontrol()
        {
            if (KendiSatislarim_CheckBox.Checked == true)
            {           
                sorgu = "SELECT * FROM showUruns WHERE urunOnay='" + "Onaylandı" + "' AND UrunMiktari>0 ";
                Secereksatinal_datagrid.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
            }

            if (KendiSatislarim_CheckBox.Checked == false)
            {
                sorgu = "SELECT * FROM showUruns WHERE urunOnay='" + "Onaylandı" + "' AND UrunMiktari>0 AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "'";
                Secereksatinal_datagrid.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
            }
        }
        private void ListeleComboBoxControl()
        {
            satisbaslik_lbl.Text = listeleCombo.Text;
            sorgu = "SELECT * FROM showUruns WHERE UrunSatici='" + Singleton.Instance.currentUser.UserName + "'";
            if (listeleCombo.Text == "Tum Satislarim")
                sorgu = "SELECT * FROM showUruns WHERE UrunSatici='" + Singleton.Instance.currentUser.UserName + "'";
            if (listeleCombo.Text == "Onaylanmis Satislarim")
                sorgu = "SELECT * FROM showUruns WHERE UrunSatici='" + Singleton.Instance.currentUser.UserName + "' AND urunonay='" + "Onaylandı" + "'";
            if (listeleCombo.Text == "Onaylanmamis Satislarim")
                sorgu = "SELECT * FROM showUruns WHERE UrunSatici='" + Singleton.Instance.currentUser.UserName + "' AND urunonay='" + "Onaylanmadı" + "'";
            urunler_dg.DataSource = Singleton.Instance.islem.Showdatabases(sorgu);
        }
        private void KendiSatislarim_CheckBox_CheckedChanged(object sender, EventArgs e) => CheckBoxcontrol();
        private void Secereksatinal_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Secereksatinal_datagrid.CurrentRow.Selected = true;
            barkodno_label.Text = Secereksatinal_datagrid.Rows[e.RowIndex].Cells["urunBarkodNo"].FormattedValue.ToString();
            urunadilabel.Text = Secereksatinal_datagrid.Rows[e.RowIndex].Cells["UrunName"].FormattedValue.ToString();
            fiyat_label.Text = Secereksatinal_datagrid.Rows[e.RowIndex].Cells["UrunFiyati"].FormattedValue.ToString();
            stok_lbl.Text= Secereksatinal_datagrid.Rows[e.RowIndex].Cells["UrunMiktari"].FormattedValue.ToString();
            urunsaticilabel.Text = Secereksatinal_datagrid.Rows[e.RowIndex].Cells["UrunSatici"].FormattedValue.ToString();
            urunbirimilabel.Text = Secereksatinal_datagrid.Rows[e.RowIndex].Cells["UrunBirimi"].FormattedValue.ToString();
        }
        private void Urunekle_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunler_dg.CurrentRow.Selected = true;
            g_urunid.Text = urunler_dg.Rows[e.RowIndex].Cells["UrunID"].FormattedValue.ToString();
            g_urunname.Text = urunler_dg.Rows[e.RowIndex].Cells["UrunName"].FormattedValue.ToString();
            g_urunmiktari.Text = urunler_dg.Rows[e.RowIndex].Cells["UrunMiktari"].FormattedValue.ToString();
            g_urunbirimi.Text = urunler_dg.Rows[e.RowIndex].Cells["urunBirimi"].FormattedValue.ToString();
            g_urunfiyati.Text = urunler_dg.Rows[e.RowIndex].Cells["UrunFiyati"].FormattedValue.ToString();
            g_urunturu.Text = urunler_dg.Rows[e.RowIndex].Cells["UrunTuru"].FormattedValue.ToString();
            g_urunbarkod.Text = urunler_dg.Rows[e.RowIndex].Cells["urunBarkodNo"].FormattedValue.ToString();
        }
        private void Back_btn_Click(object sender, EventArgs e) => Singleton.Instance.ChangeScreen(this, Singleton.Instance.girisctr);
        private void talep_btn_Click(object sender, EventArgs e)
        {

            try
            {
                double toplamtutar = Convert.ToDouble(kacadet_txt.Text) * Convert.ToDouble(kactl_txt.Text);
                double kasakomisyon = toplamtutar / 100;
                double gereklibakiye = toplamtutar + kasakomisyon;

                if (gereklibakiye <= Singleton.Instance.currentUser.Bakiye)
                    Singleton.Instance.islem.SiparisControl(urun_adi_txt.Text, kacadet_txt.Text, kactl_txt.Text);
                else
                    MessageBox.Show("Islem Icin Bakiye Yetersiz...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
            urun_adi_txt.Text = "";
            kactl_txt.Text = "";
            kacadet_txt.Text = "";
        }
        private void gesmic_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.alisverisListele.SiparislerimOnLoad();
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.alisverisListele);
        }
        private void aktifislem_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.listeleSiparisler.SiparislerimListeleOnLoad();
            Singleton.Instance.ChangeScreen(this, Singleton.Instance.listeleSiparisler);
        }
        private void hesapla_btn_Click(object sender, EventArgs e)
        {
            int istenenadet = Convert.ToInt32(alinanadet_txt.Text);
            int stokadet= Convert.ToInt32(stok_lbl.Text);
            if (SayiMi(alinanadet_txt.Text))
            {
                if(istenenadet<=stokadet)
                {
                    satinal_btn.Visible = true;
                    double ucret = Convert.ToInt32(alinanadet_txt.Text) * Convert.ToInt32(fiyat_label.Text);
                    odenecektutar_label.Visible = true;
                    odenecektutar_label.Text = ucret.ToString();
                }
                else
                {
                    MessageBox.Show("Stokta bu kadar yok. Alim adetini dusurebilirsin.");
                }
            }
            else
            {
                MessageBox.Show("Luftfen adet kismina miktar giriniz");
            }
        }
    }
}
