using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace borsaProjesi
{
    public class veriler
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\alisveris.mdb");
        OleDbCommand komut;

        public void SiparistenSatinAl()
        {
            OpenConnection();
            OleDbDataReader ReadSiparislerData = ReadDatabase("Select * from Siparisler Where SiparisDurumu='" + "Beklemede" + "' ORDER BY siparisOlusturulmaTarihi ASC ");
            while (ReadSiparislerData.Read())
            {
                double siparisFiyati = Convert.ToDouble(ReadSiparislerData["KacParayaAlacak"].ToString());
                int adetSayisi = Convert.ToInt32(ReadSiparislerData["KacAdetAlacak"].ToString());
                double toplamFiyat = siparisFiyati * adetSayisi;
                double kasakomisyon = toplamFiyat / 100;
                double toplamCekilecekPara = toplamFiyat + kasakomisyon;
                double userHesapbakiyesi = 0;
                OleDbDataReader ReadUserBilgileri = ReadDatabase("Select * from Uyeler Where UserName='" + ReadSiparislerData["siparisVerenKisi"].ToString()+ "'");
                if (ReadUserBilgileri.Read())
                    userHesapbakiyesi = Convert.ToDouble(ReadUserBilgileri["hesapBakiye"].ToString());

                if (userHesapbakiyesi >= toplamCekilecekPara) { 

                    OleDbDataReader ReadUrunlerData = ReadDatabase("Select * from Uruns Where UrunName='" + ReadSiparislerData["urunAdi"].ToString() + "' AND UrunMiktari>0 AND urunOnay='"+ "Onaylandı" + "' AND NOT UrunSatici='" + ReadSiparislerData["siparisVerenKisi"].ToString() + "' ORDER BY UrunFiyati ASC");
                    if (ReadUrunlerData.Read())
                    {
                        int urunSayisi = Convert.ToInt32(ReadUrunlerData["UrunMiktari"].ToString());
                        double urunFiyati = Convert.ToInt32(ReadUrunlerData["UrunFiyati"].ToString());
                        if (siparisFiyati == urunFiyati && adetSayisi <= urunSayisi)
                        {
                            ParaCekWithUserName(toplamCekilecekPara, ReadSiparislerData["siparisVerenKisi"].ToString());

                            double newBakiye = Convert.ToDouble(ReadUserBilgileri["hesapBakiye"].ToString());
                            newBakiye += toplamFiyat;
                            AddOrUpdateDatabase("update Uyeler set hesapBakiye='" + newBakiye + "' where UserName='" + ReadUrunlerData["UrunSatici"] + "'");

                            KasaKomisyon(kasakomisyon);

                            int newAdetSayisi = Convert.ToInt32(ReadUrunlerData["UrunMiktari"].ToString());
                            newAdetSayisi -= adetSayisi;
                            AddOrUpdateDatabase("update Uruns set UrunMiktari='" + newAdetSayisi + "' where urunBarkodNo='" + ReadUrunlerData["urunBarkodNo"].ToString() + "'");
                            AddOrUpdateDatabase("insert into Satislar(UrunAdi,SatisFiyati,SatisMiktari,UrunBirimi,SatisYapan,SatinAlan,SatisTarihi) values('" + ReadUrunlerData["UrunName"].ToString() + "','" + ReadUrunlerData["UrunFiyati"].ToString() + "','" + adetSayisi.ToString() + "','" + ReadUrunlerData["UrunBirimi"].ToString() + "','" + ReadUrunlerData["UrunSatici"].ToString() + "','" + ReadSiparislerData["siparisVerenKisi"].ToString() + "','" + DateTime.Parse(DateTime.Now.ToShortDateString()).ToString() + "')");                       
                            AddOrUpdateDatabase("update Siparisler set SiparisDurumu='" + "Satin alindi" + "' where urunAdi='" + ReadSiparislerData["urunAdi"].ToString() + "' ");
                        }
                    }
                }
            }
            CloseConnection();
            NoLoadRefresh();
        }
        public void Temizle(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                if (c is TextBox box)
                    box.Clear();
                if (c.Controls.Count > 0)
                    Temizle(c);
            }

        }
        private void OpenConnection() => baglanti.Open();
        private void CloseConnection() => baglanti.Close();
        private OleDbDataReader ReadDatabase(string sorgu)
        {
            OleDbDataReader ReadData;
            komut = new OleDbCommand(sorgu, baglanti);
            ReadData = komut.ExecuteReader();
            return ReadData;
        }
        private string AddOrUpdateDatabase(string sorgu)
        {
            komut = new OleDbCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            return "Islem Basarili.";
        }
        public void KasaKomisyon(double komisyon)
        {
            if (baglanti.State != ConnectionState.Open) { baglanti.Open(); };
            OleDbDataReader ReadData;
            ReadData = ReadDatabase("Select * from Kasa WHERE soyad='" + "Demirel" + "'");
            if (ReadData.Read())
            {
                double kasabutce = Convert.ToDouble(ReadData["hesapBakiyesi"].ToString());
                Singleton.Instance.currentUser.kasabutce = kasabutce;
                kasabutce += komisyon;
                AddOrUpdateDatabase("update Kasa set hesapBakiyesi='" + kasabutce + "' where soyad='" + "Demirel" + "'");
            }
            baglanti.Close();
        }
        public void SiparisControl(string urunAdi,string kacadet,string kacpara)
        {
            int urunFiyat = 0, urunAdet = 0;
            string saticiAdi = "", barkodNo = "";
            double toplamfiyat = Convert.ToDouble(kacadet) * Convert.ToDouble(kacpara);
            double kasakomisyon = toplamfiyat / 100;
            DialogResult onay = MessageBox.Show("Urun Adı : "+urunAdi+"\nUrun Adedi : "+kacadet+"\nUrun Birim Fiyati : "+kacpara+"\nToplam fiyat : "+toplamfiyat.ToString() + "\nKomisyon Ucreti: " + kasakomisyon.ToString() + " ₺\n\n\n Not: Istediginiz fiyattan urununu satisa konulmasi durumunda islem otomatik yapilacaktir.", "Onaylıyormusunuz ?", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                OpenConnection();
                OleDbDataReader ReadMinFiyatData = ReadDatabase("Select * from Uruns Where UrunName='" + urunAdi + "' AND UrunMiktari>0  AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "' ORDER BY UrunFiyati ASC ");
                    if (ReadMinFiyatData.Read())
                    {
                        urunFiyat = Convert.ToInt32(ReadMinFiyatData["UrunFiyati"].ToString());
                        urunAdet = Convert.ToInt32(ReadMinFiyatData["UrunMiktari"].ToString());
                        saticiAdi = ReadMinFiyatData["UrunSatici"].ToString();
                        barkodNo = ReadMinFiyatData["urunBarkodNo"].ToString();
                    }
                CloseConnection();
                if (urunFiyat == 0 || urunAdet == 0)
                {
                    CreateSiparis(urunAdi, kacadet, kacpara);
                    MessageBox.Show("Siparisiniz beklemeye alinmistir.\n", "Talep Olusturuldu!");
                }
                else if (Convert.ToInt32(kacpara) >= urunFiyat && Convert.ToInt32(kacadet) <= urunAdet)
                {
                   UrunSatinAl(barkodNo,saticiAdi,Convert.ToInt32(kacadet),toplamfiyat, "Talebinizi istinaden alim islemi yapildi.", kasakomisyon);
                }
                else
                {
                    CreateSiparis(urunAdi,kacadet,kacpara);
                    MessageBox.Show("Siparisiniz beklemeye alinmistir.", "Talep Olusturuldu!");
                }
                
            }
            else MessageBox.Show("Iptal Edildi", "Iptal Edildi!");

        }
        public void CreateSiparis(string urunAdi, string kacadet, string kacpara)
        {
            OpenConnection();
            string sorgu = "insert into Siparisler(urunAdi,KacParayaAlacak,KacAdetAlacak,siparisVerenKisi,siparisOlusturulmaTarihi) values('" + urunAdi + "','" + kacpara + "','" + kacadet + "','" + Singleton.Instance.currentUser.UserName + "','" + DateTime.Parse(DateTime.Now.ToString()).ToString() + "')";
            AddOrUpdateDatabase(sorgu);
            CloseConnection();
        } 
        public int GetUrunToplamAdet(string urunname)
        {
            int toplamurun = 0;
            OleDbDataReader ReadData;
            OpenConnection();
              ReadData = ReadDatabase("Select * from Uruns Where UrunName='" + urunname + "' AND UrunMiktari>0  AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "' ORDER BY UrunFiyati ASC ");
                while (ReadData.Read())
                 toplamurun += Convert.ToInt32(ReadData["UrunMiktari"].ToString());
            CloseConnection();
            return toplamurun;
        }
        public int GetToplamPara(string urunname, int miktar)
        {
            int toplamPara = 0;

            OleDbDataReader ReadData;
            OpenConnection();
                ReadData = ReadDatabase("Select * from Uruns Where UrunName='" + urunname + "' AND UrunMiktari>0  AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "' ORDER BY UrunFiyati ASC ");
                while (ReadData.Read())
                {
                int sattigimmiktar;
                    if (Convert.ToInt32(ReadData["UrunMiktari"].ToString()) <= miktar)
                    {
                        sattigimmiktar = Convert.ToInt32(ReadData["UrunMiktari"].ToString());
                        miktar -= sattigimmiktar;
                        toplamPara += sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString());
                    }
                    else if (Convert.ToInt32(ReadData["UrunMiktari"].ToString()) > miktar && miktar > 0)
                    {
                        sattigimmiktar = miktar;
                        miktar -= sattigimmiktar;
                        toplamPara += sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString());
                    }
                }
            CloseConnection();
            return toplamPara;
        }
        public void ParaCek(double toplamfiyat)
        {
            OleDbDataReader ReadData;
            ReadData = ReadDatabase("Select * from Uyeler WHERE UserName='" + Singleton.Instance.currentUser.UserName + "'");
            if (ReadData.Read())
            {
                double x = Convert.ToDouble(ReadData["hesapBakiye"].ToString());
                x -= toplamfiyat;
                AddOrUpdateDatabase("update Uyeler set hesapBakiye='" + x + "' where UserName='" + Singleton.Instance.currentUser.UserName + "'");
            }
        }
        public void ParaCekWithUserName(double toplamfiyat,string userName)
        {
            OleDbDataReader ReadData;

            ReadData = ReadDatabase("Select * from Uyeler WHERE UserName='" + userName + "'");
            if (ReadData.Read())
            {
                double x = Convert.ToDouble(ReadData["hesapBakiye"].ToString());
                x -= toplamfiyat;
                AddOrUpdateDatabase("update Uyeler set hesapBakiye='" + x + "' where UserName='" + userName + "'");
            }
        }
        public void Otosatinal(string urunname, int miktar,double kasakomisyon)
        {
            int miktar2 = miktar;
            double toplamPara = 0;
            string mesaj = "";
            string urunbirimi = "";
            OleDbDataReader ReadData;
            OpenConnection();
            ReadData = ReadDatabase("Select * from Uruns Where UrunName='" + urunname + "' AND UrunMiktari>0  AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "' ORDER BY UrunFiyati ASC ");
            while (ReadData.Read())
            {
                urunbirimi = ReadData["UrunBirimi"].ToString();
                int sattigimmiktar;
                if (Convert.ToInt32(ReadData["UrunMiktari"].ToString()) <= miktar && Convert.ToInt32(ReadData["UrunMiktari"].ToString()) > 0)
                {
                    sattigimmiktar = Convert.ToInt32(ReadData["UrunMiktari"].ToString());
                    miktar -= sattigimmiktar;
                    toplamPara += sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString());
                    ParaCek( sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString()));
                    Satinal(ReadData, sattigimmiktar);
                    mesaj += sattigimmiktar + " " + urunbirimi + " --> Birim fiyati :" + Convert.ToInt32(ReadData["UrunFiyati"].ToString()) + " ₺ --> Toplam Fiyat :" + (sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString())).ToString() + " ₺ den alındı .\n";
                }
                else if (Convert.ToInt32(ReadData["UrunMiktari"].ToString()) > miktar && miktar > 0 && Convert.ToInt32(ReadData["UrunMiktari"].ToString()) > 0)
                {
                    sattigimmiktar = miktar;
                    miktar -= sattigimmiktar;
                    toplamPara += sattigimmiktar * Convert.ToDouble(ReadData["UrunFiyati"].ToString());
                    ParaCek(sattigimmiktar * Convert.ToDouble(ReadData["UrunFiyati"].ToString()));
                    Satinal(ReadData, sattigimmiktar);
                    mesaj += sattigimmiktar + " " + urunbirimi + " --> Birim fiyati :" + Convert.ToInt32(ReadData["UrunFiyati"].ToString()) + " ₺ --> Toplam Fiyat :" + (sattigimmiktar * Convert.ToInt32(ReadData["UrunFiyati"].ToString())).ToString() + " ₺ den alındı .\n";
                }
            }
            ParaCek(kasakomisyon);
            KasaKomisyon(kasakomisyon);
            string topMesaj = "Alindi: " + miktar2.ToString() + " " + urunbirimi + " " + urunname + ". Toplam Fiyat: " + toplamPara.ToString() + " ₺ + Komisyon Ucreti: " + kasakomisyon.ToString()+ " ₺\n\n";
            MessageBox.Show(topMesaj + mesaj + "\n", "Islem Tamamlandi");
            CloseConnection();
            Refresh();
        }
        private void Satinal(OleDbDataReader ReadUrunData, int satismiktari)
        {
            int fiyat = Convert.ToInt32(ReadUrunData["UrunFiyati"].ToString()) * satismiktari;
            string saticiadi = ReadUrunData["UrunSatici"].ToString();
            OleDbDataReader ReadUserData;
            ReadUserData = ReadDatabase("Select * from Uyeler WHERE UserName='" + saticiadi + "'");
            if (ReadUserData.Read())
            {
                double x = Convert.ToDouble(ReadUserData["hesapBakiye"].ToString());
                x += fiyat;
                int urunmiktari = Convert.ToInt32(ReadUrunData["UrunMiktari"].ToString());
                urunmiktari -= satismiktari;
                AddOrUpdateDatabase("update Uyeler set hesapBakiye='" + x + "' where UserName='" + saticiadi + "'");
                AddOrUpdateDatabase("update Uruns set UrunMiktari='" + urunmiktari + "' where urunBarkodNo='" + ReadUrunData["urunBarkodNo"].ToString() + "'");
                AddOrUpdateDatabase("insert into Satislar(UrunAdi,SatisFiyati,SatisMiktari,UrunBirimi,SatisYapan,SatinAlan,SatisTarihi) values('" + ReadUrunData["UrunName"].ToString() + "','" + ReadUrunData["UrunFiyati"].ToString() + "','" + satismiktari.ToString() + "','" + ReadUrunData["UrunBirimi"].ToString() + "','" + saticiadi + "','" + Singleton.Instance.currentUser.UserName + "','" + DateTime.Parse(DateTime.Now.ToShortDateString()).ToString() + "')");
            }
        }
        public void ListBoxDoldur(ListBox list)
        {
            list.Items.Clear();
            OleDbDataReader ReadData;
            OpenConnection();
            ReadData = ReadDatabase("Select * from Uruns Where UrunOnay='" + "Onaylandı" + "'AND UrunMiktari>0 AND NOT UrunSatici='" + Singleton.Instance.currentUser.UserName + "'");
            while (ReadData.Read())
                list.Items.Add(ReadData["UrunName"].ToString());
            CloseConnection();
        }
        public void Current_user_update(OleDbDataReader ReadUser)
        {
            Singleton.Instance.currentUser.UserID = Convert.ToInt32(ReadUser["UserID"].ToString());
            Singleton.Instance.currentUser.UserName = ReadUser["UserName"].ToString();
            Singleton.Instance.currentUser.UserPass = ReadUser["UserPassword"].ToString();
            Singleton.Instance.currentUser.Ad = ReadUser["ad"].ToString();
            Singleton.Instance.currentUser.SoyAd = ReadUser["soyad"].ToString();
            Singleton.Instance.currentUser.Adres = ReadUser["adres"].ToString();
            Singleton.Instance.currentUser.Eposta = ReadUser["email"].ToString();
            Singleton.Instance.currentUser.Tc = Convert.ToInt64(ReadUser["tcno"].ToString());
            Singleton.Instance.currentUser.Telefon = Convert.ToInt64(ReadUser["telefonno"].ToString());
            Singleton.Instance.currentUser.Bakiye = Convert.ToDouble(ReadUser["hesapBakiye"].ToString());
            Singleton.Instance.currentUser.PasifBakiye = Convert.ToDouble(ReadUser["geciciBakiye"].ToString());
            Singleton.Instance.currentUser.ParaBirimi = ReadUser["parabirimi"].ToString();
        }
        public void Refresh()
        {
            OleDbDataReader ReadData;
            OpenConnection();
            ReadData = ReadDatabase("Select * from Uyeler WHERE UserName='" + Singleton.Instance.currentUser.UserName + "'");
            if (ReadData.Read())
                 Current_user_update(ReadData);
            CloseConnection();
           
            Singleton.Instance.main.MainScreenOnLoad();
        }
        public void NoLoadRefresh()
        {
            OleDbDataReader ReadData;
            OpenConnection();
            ReadData = ReadDatabase("Select * from Uyeler WHERE UserName='" + Singleton.Instance.currentUser.UserName + "'");
            if (ReadData.Read())
                Current_user_update(ReadData);
            CloseConnection();
        }
        public DataTable Showdatabases(string sorgu)
        {
            OleDbDataAdapter db;
            OpenConnection();
            db = new OleDbDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            db.Fill(tablo);
            CloseConnection();
            return tablo;
        }
        public void KullaniciGirisi(TextBox ad, TextBox parola, Form g)
        {
            OleDbDataReader ReadUserData;
            OpenConnection();
            ReadUserData = ReadDatabase("Select * from Uyeler WHERE UserName='" + ad.Text + "' AND UserPassword='" + parola.Text + "'");
            if (ReadUserData.Read())
            {
                Current_user_update(ReadUserData);
                Temizle(g);
                CloseConnection();
                Singleton.Instance.main.MainScreenOnLoad();
                Singleton.Instance.ChangeScreen(g, Singleton.Instance.main);
            }
            else {
                MessageBox.Show("Giriş Başarısız");
                CloseConnection();
            }            
            CloseConnection();

        }
        public void AdminGirisi(TextBox adminname, TextBox adminpassword, Form g)
        {
            OleDbDataReader ReadAdminData;
            OpenConnection();
            ReadAdminData = ReadDatabase("Select * from Admins WHERE adminName='" + adminname.Text + "' AND adminPassword='" + adminpassword.Text + "'");
            if (ReadAdminData.Read())
            {
                CloseConnection();
                Singleton.Instance.adminForm.ClearTxts();
                Singleton.Instance.adminForm.AdminFormOnLoad();
                Singleton.Instance.ChangeScreen(g, Singleton.Instance.adminForm);
            }
            else {
                CloseConnection();
                MessageBox.Show("Giriş Başarısız");
            } 
           
            Temizle(g);
        }
        public void KullaniciEkle(TextBox username, TextBox userpass, TextBox ad, TextBox soyad, TextBox tc, TextBox tel, TextBox adres, TextBox email, Form g)
        {

            OleDbDataReader ReadUserData;
            OpenConnection();
            ReadUserData = ReadDatabase("Select * from Uyeler WHERE UserName='" + username.Text + "'");
            if (ReadUserData.Read())
            {
                MessageBox.Show("Bu Username Daha Önce Alınmış");
            }
            else
            {
                AddOrUpdateDatabase("insert into Uyeler(UserName,UserPassword,ad,soyad,tcno,telefonno,adres,email) values('" + username.Text + "','" + userpass.Text + "','" + ad.Text + "','" + soyad.Text + "','" + tc.Text + "','" + tel.Text + "','" + adres.Text + "','" + email.Text + "')");
                MessageBox.Show("Başarılı Bir şekilde üye oldunuz", "Üye Olma Başarılı");
                Temizle(g);
            }
            CloseConnection();
        }
        public void UrunEkle(TextBox urunbarkodno, ComboBox urunbirimi, TextBox urunfiyati, TextBox urunmiktari, TextBox urunname, TextBox urunturu, string UrunSatici, GroupBox g)
        {
            OleDbDataReader ReadUrunData;
            if (urunbarkodno.Text == "" || urunbirimi.Text == "" || urunfiyati.Text == "" || urunmiktari.Text == "" || urunname.Text == "" || urunturu.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            else
            {
                OpenConnection();
                ReadUrunData = ReadDatabase("Select * from Uruns WHERE urunBarkodNo='" + urunbarkodno.Text + "'");
                if (ReadUrunData.Read())MessageBox.Show("Bu Barkod Daha Önce Alınmış");
                else
                {
                    AddOrUpdateDatabase("insert into Uruns(UrunName,UrunMiktari,UrunFiyati,UrunTuru,UrunSatici,urunOnay,urunBirimi,urunBarkodNo) values('" + urunname.Text + "','" + Convert.ToInt32(urunmiktari.Text) + "','" + Convert.ToInt32(urunfiyati.Text) + "','" + urunturu.Text + "','" + UrunSatici + "','" + "Onaylanmadı" + "','" + urunbirimi.Text + "','" + urunbarkodno.Text + "')");
                    Temizle(g);
                }
                CloseConnection();
            }
        }
        private void AccessUpdateIslemleri(string sorgu)
        {
            OpenConnection();
            AddOrUpdateDatabase(sorgu);
            CloseConnection();
        }
        public void GecicibakiyeGuncelle(double gecicibakiye,string kullaniciParaBirimi)
        {
            string sorgu = ("update Uyeler set geciciBakiye='" + gecicibakiye + "', parabirimi='"+kullaniciParaBirimi+"',sonparayuklemetarihi='"+ DateTime.Parse(DateTime.Now.ToShortDateString()).ToShortDateString()+"' where UserName='" + Singleton.Instance.currentUser.UserName + "'");
            AccessUpdateIslemleri(sorgu);
            MessageBox.Show("Bakiye yükleme işlemi tamamlandı,admin onayı bekleniyor");
            Refresh();
        }
        public void BakiyeOnay(string username, double guncelbakiye)
        {
            string sorgu = ("update Uyeler set geciciBakiye='" + 0 + "' ,hesapBakiye='" + guncelbakiye + "' where UserName='" + username + "'");
            AccessUpdateIslemleri(sorgu);
        }
        public void GeciciBakiyeDegistirWithUsurname(string username, double gecicibakiye)
        {
            string sorgu = ("update Uyeler set geciciBakiye='" + gecicibakiye + "',parabirimi='" + "TL" + "' where UserName='" + username + "'");
            AccessUpdateIslemleri(sorgu);
        }
        public void UserUpdate(TextBox userpass, TextBox email, TextBox adres, TextBox telefonno)
        {
            string sorgu = ("update Uyeler set UserPassword='" + userpass.Text + "' ,email='" + email.Text + "',adres='" + adres.Text + "',telefonno='" + telefonno.Text + "' where UserName='" + Singleton.Instance.currentUser.UserName + "'");
            AccessUpdateIslemleri(sorgu);
            Refresh();
        }
        public void UrunUpdate(TextBox urunfiyati, TextBox urunmiktari, string urunbarkod, GroupBox g)
        {
            string sorgu = ("update Uruns set urunMiktari='" + Convert.ToInt32(urunmiktari.Text) + "' ,urunFiyati='" + Convert.ToInt32(urunfiyati.Text) + "',urunOnay='" + "Onaylanmadı" + "' where urunBarkodNo='" + urunbarkod + "'");
            AccessUpdateIslemleri(sorgu);
            Temizle(g);
        }
        public void UrunOnay(string barkodno)
        {
            string sorgu = ("update Uruns set urunOnay='" + "Onaylandı" + "' where urunBarkodNo='" + barkodno + "'");
            AccessUpdateIslemleri(sorgu);
        }
        public void UrunSatinAl(string barkodno, string urunsatici, int kacadet, double toplamfiyat, string mesaj,double kasakomisyon)
        {
            OpenConnection();
            ParaCek(toplamfiyat+kasakomisyon);
            CloseConnection();
            OpenConnection();
            OleDbDataReader ReadUserData;
            ReadUserData = ReadDatabase("Select * from Uyeler WHERE UserName='" + urunsatici + "'");
            if (ReadUserData.Read())
            {
                double newBakiye = Convert.ToDouble(ReadUserData["hesapBakiye"].ToString());
                newBakiye += toplamfiyat;
                AddOrUpdateDatabase("update Uyeler set hesapBakiye='" + newBakiye + "' where UserName='" + urunsatici + "'");           
            }
            CloseConnection();
            OpenConnection();
            OleDbDataReader ReadUrunData;
            ReadUrunData = ReadDatabase("Select * from Uruns WHERE urunBarkodNo='" + barkodno + "'");
            if (ReadUrunData.Read())
            {
                int newAdetSayisi = Convert.ToInt32(ReadUrunData["UrunMiktari"].ToString());
                newAdetSayisi -= kacadet;
                AddOrUpdateDatabase("update Uruns set UrunMiktari='" + newAdetSayisi + "' where urunBarkodNo='" + barkodno + "'");
                AddOrUpdateDatabase("insert into Satislar(UrunAdi,SatisFiyati,SatisMiktari,UrunBirimi,SatisYapan,SatinAlan,SatisTarihi) values('" + ReadUrunData["UrunName"].ToString() + "','" + ReadUrunData["UrunFiyati"].ToString() + "','" + kacadet.ToString() + "','" + ReadUrunData["UrunBirimi"].ToString() + "','" + urunsatici + "','" + Singleton.Instance.currentUser.UserName + "','" + DateTime.Parse(DateTime.Now.ToShortDateString()).ToString() + "')");
            }
            CloseConnection();
          
            OpenConnection();
                
            CloseConnection();
            MessageBox.Show(mesaj, "Satın Alma İşlemi Onaylanı");
            Refresh();

        }
    }
}

