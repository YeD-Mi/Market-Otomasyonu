using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borsaProjesi
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void Kullanici_ekle_btn_Click(object sender, EventArgs e)
        {
        
            if (username_txt.Text == "" || password_txt.Text == "" || adres_txt.Text == "" || ad_txt.Text == "" || soyad_txt.Text == "" || tc_txt.Text == "" || telefon_txt.Text == "" || adres_txt.Text == "" || email_txt.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurun");
            else if (SayiMi(tc_txt.Text) == false)
                MessageBox.Show("Girdiginiz TC Gecersiz.");
            else if (SayiMi(telefon_txt.Text) == false)
                MessageBox.Show("Girdiginiz telefon numarasi Gecersiz.");
            else if (password_txt.Text == passagain_txt.Text)
            {
                Singleton.Instance.islem.KullaniciEkle(username_txt, password_txt, ad_txt, soyad_txt, tc_txt, telefon_txt, adres_txt, email_txt,this);

            }
            else
                MessageBox.Show("Sifreler ayni degil.", "Hata 2");
        }

        private void Cikis_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Singleton.Instance.girisctr.Show();
        }
        static bool SayiMi(string deger)
        {
            try
            {
                long.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
