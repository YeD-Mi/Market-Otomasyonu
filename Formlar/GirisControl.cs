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
    public partial class GirisControl : Form
    {
        public GirisControl()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e) => Singleton.Instance.ExitTheApplication();

        private void GirisControl_Load(object sender, EventArgs e)
        {
            uyegir_rb.Checked = true;
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            if (uyegir_rb.Checked == true)
            {
                Singleton.Instance.islem.KullaniciGirisi(username_admin, password_admin, this);
            }
            else if (admingir_rb.Checked == true)
            {
                Singleton.Instance.islem.AdminGirisi(username_admin, password_admin, this);
            }
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            Singleton.Instance.signUp.Show();
            this.Hide();
        }
    }
}
