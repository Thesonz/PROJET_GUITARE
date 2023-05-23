using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM_VRAI_CUSTOM_NET.F.P
{
    /// <summary>
    /// Logique d'interaction pour P_LOGIN_G_INSCRIPTION.xaml
    /// </summary>
    public partial class P_LOGIN_G_INSCRIPTION : Page
    {
        Frame F_Login_G;
        Frame F_Login;

        public P_LOGIN_G_INSCRIPTION(Frame frameG, Frame frame)
        {
            F_Login = frame;
            F_Login_G = frameG;
            InitializeComponent();
        }

        private void BT_Connexion_Click(object sender, RoutedEventArgs e)
        {
            P_LOGIN_CONNEXION pg = new P_LOGIN_CONNEXION();
            F_Login.Content = pg;
            P_LOGIN_G_CONNEXION pg1 = new P_LOGIN_G_CONNEXION(F_Login_G, F_Login);
            F_Login_G.Content = pg1;
        }
    }
}
