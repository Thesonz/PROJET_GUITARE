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
    public partial class P_HOME_MICRO : Page
    {
        Frame frame;
        public P_HOME_MICRO(Frame P_Page)
        {
            frame = P_Page;
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;

            Affichage_Client();
        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void BTN_Precedent_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.PageGuitare = 2;
            P_HOME_BOIS pg = new P_HOME_BOIS(frame);
            frame.Content = pg;
        }

        private void BTN_Suivant_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Ma_Guitare.NeckMicroId = C_COORDINATION.Instance.MicroNuckItem.IdMicro;
            C_COORDINATION.Instance.Ma_Guitare.CentralMicroId = C_COORDINATION.Instance.MicroCenterItem.IdMicro;
            C_COORDINATION.Instance.Ma_Guitare.BridgeMicroId = C_COORDINATION.Instance.MicroBridgeItem.IdMicro;
            C_COORDINATION.Instance.PageGuitare = 4;
            P_HOME_VIBRATO pg = new P_HOME_VIBRATO(frame);
            frame.Content = pg;
        }

        private void CB_Nuck_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Nuck.SelectedIndex = C_COORDINATION.Instance.MicroNuck;
        }

        private void CB_Central_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Central.SelectedIndex = C_COORDINATION.Instance.MicroCenter;
        }

        private void CB_Bridge_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Bridge.SelectedIndex = C_COORDINATION.Instance.MicroBridge;
        }
    }
}
