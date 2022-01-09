using borsaProjesi.FormScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borsaProjesi
{
    public sealed class Singleton
    {
        private Singleton()
        {
        }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        public void ExitTheApplication() => Application.Exit();
        public void ChangeScreen(Form hide, Form show)
        {
            hide.Hide();
            show.Show();
        }
        public CurrentUser currentUser = new CurrentUser();
        public veriler islem = new veriler();
        
        public MainScreen main = new MainScreen();
        public SignUp signUp = new SignUp();
        public AdminForm adminForm = new AdminForm();
        public GirisControl girisctr = new GirisControl();
        public GecmisAlisverisListele alisverisListele = new GecmisAlisverisListele();
        public SiparislerimListele listeleSiparisler = new SiparislerimListele();

    }
}
