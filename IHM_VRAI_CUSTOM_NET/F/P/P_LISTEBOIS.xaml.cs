using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using IHM_VRAI_CUSTOM_NET.C;
using NS_WS;

namespace IHM_VRAI_CUSTOM_NET.F.P
{
    /// <summary>
    /// Logique d'interaction pour P_LISTEBOIS.xaml
    /// </summary>
    public partial class P_LISTEBOIS : Page
    {

        public P_LISTEBOIS()
        {
            InitializeComponent();

            // Ma_Conf = P_Conf;
            DataContext = C_COORDINATION.Instance;
            C_COORDINATION.Instance.Bois_Selec = new C_BOISTYPES();
            Affichage_Client();
        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (C_COORDINATION.Instance.Bois_Selec != null && C_COORDINATION.Instance.Bois_Selec.DispoBois == true)
            {
                TB_Dispo.Text = "Disponible";
            }
            else
            {
                TB_Dispo.Text = "Non Disponible";
            }

        }
    }
}
