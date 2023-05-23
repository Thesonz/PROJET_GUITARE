using IHM_VRAI_CUSTOM_NET.C;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM_VRAI_CUSTOM_NET.F.P
{
    /// <summary>
    /// Logique d'interaction pour P_HOME.xaml
    /// </summary>
    public partial class P_HOME_BOIS : Page
    {
        Frame frame;
        public P_HOME_BOIS(Frame P_Page)
        {
            frame = P_Page;
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
            C_COORDINATION.Instance.Ma_Guitare = new C_GUITARE();
            
            Affichage_Client();
        }

        

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void CB_Corp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Corp.SelectedIndex = C_COORDINATION.Instance.BoisCorp;
        }

        private void BTN_Suivant_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Ma_Guitare.CorpBoisId = C_COORDINATION.Instance.BoisCorpItem.IdBois;
            C_COORDINATION.Instance.Ma_Guitare.MancheBoisId = C_COORDINATION.Instance.BoisMancheItem.IdBois;
            C_COORDINATION.Instance.Ma_Guitare.ToucheBoisId = C_COORDINATION.Instance.BoisToucheItem.IdBois;
            C_COORDINATION.Instance.PageGuitare = 3;
            P_HOME_MICRO pg = new P_HOME_MICRO(frame);
            frame.Content = pg;
        }

        private void BTN_Precedent_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.PageGuitare = 1;
            P_HOME pg = new P_HOME(frame);
            frame.Content = pg;
        }

        private void CB_Manche_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Manche.SelectedIndex = C_COORDINATION.Instance.BoisManche;
        }

        private void CB_Touche_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Touche.SelectedIndex = C_COORDINATION.Instance.BoisTouche;
            
        }
    }
}
