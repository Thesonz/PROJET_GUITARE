using IHM_VRAI_CUSTOM_NET.C;
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
    /// Logique d'interaction pour P_HOME.xaml
    /// </summary>
    public partial class P_HOME : Page
    {
        Frame Page;
        public P_HOME(Frame P_Page)
        {
            Page = P_Page;
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;

            Affichage_Client();
        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void BTN_Creation_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.PageGuitare = 2;
            P_HOME_BOIS pg = new P_HOME_BOIS(Page);
            Page.Content = pg;
        }
    }
}
