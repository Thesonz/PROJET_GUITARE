using IHM_VRAI_CUSTOM_NET.C;
using IHM_VRAI_CUSTOM_NET.F.P;
using NS_WS;
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
using System.Windows.Shapes;

namespace IHM_VRAI_CUSTOM_NET.F
{
    /// <summary>
    /// Logique d'interaction pour F_LOGIN.xaml
    /// </summary>
    public partial class F_LOGIN : Window
    {

        public F_LOGIN()
        {
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
            P_LOGIN_CONNEXION pg = new P_LOGIN_CONNEXION();
            F_Login.Content = pg;
            P_LOGIN_G_CONNEXION pg1 = new P_LOGIN_G_CONNEXION(F_LoginG, F_Login);
            F_LoginG.Content = pg1;
             var result = AttendreBoolEnBoucleAsync();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void IconImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public async Task AttendreBoolEnBoucleAsync()
        {
            
            while (!C_COORDINATION.Instance.exit)
            {
                // Attendez un peu avant de vérifier à nouveau la condition
                await Task.Delay(1000);

                // Si la condition est vraie, sortez de la boucle
                if (C_COORDINATION.Instance.exit)
                {
                    break;
                }
            }

            Close();
        }

    }
}
