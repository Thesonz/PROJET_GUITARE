using IHM_VRAI_CUSTOM_NET.C;
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

namespace IHM_VRAI_CUSTOM_NET.F.P
{
    /// <summary>
    /// Logique d'interaction pour P_HOME.xaml
    /// </summary>
    public partial class P_HOME_VERIFICATION : Page
    {
        Frame frame;
        public P_HOME_VERIFICATION(Frame P_Page)
        {
            frame = P_Page;
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
            Affichage_Prix();
            Affichage_Client();
        }

        public void Affichage_Prix()
        {
            TB_Prix1.Text = $"+{C_COORDINATION.Instance.BoisCorpItem.Prix} €";
            TB_Prix2.Text = $"+{C_COORDINATION.Instance.BoisMancheItem.Prix} €";
            TB_Prix3.Text = $"+{C_COORDINATION.Instance.BoisToucheItem.Prix} €";
            TB_Prix4.Text = $"+{C_COORDINATION.Instance.MicroNuckItem.Prix} €";
            TB_Prix5.Text = $"+{C_COORDINATION.Instance.MicroCenterItem.Prix} €";
            TB_Prix6.Text = $"+{C_COORDINATION.Instance.MicroBridgeItem.Prix} €";
            TB_Prix7.Text = $"+{C_COORDINATION.Instance.VibratoItem.Prix} €";
            int PrixTotal = C_COORDINATION.Instance.BoisCorpItem.Prix + C_COORDINATION.Instance.BoisMancheItem.Prix + C_COORDINATION.Instance.BoisToucheItem.Prix + C_COORDINATION.Instance.MicroNuckItem.Prix + C_COORDINATION.Instance.MicroCenterItem.Prix + C_COORDINATION.Instance.MicroBridgeItem.Prix + C_COORDINATION.Instance.VibratoItem.Prix;
            TB_Prix8.Text = $"{PrixTotal} €";

        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void BTN_Precedent_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.PageGuitare = 4;
            P_HOME_VIBRATO pg = new P_HOME_VIBRATO(frame);
            frame.Content = pg;
        }

        private void BTN_Suivant_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(1000);
            C_COORDINATION.Instance.PageGuitare = 1;
            P_HOME_COMMANDER pg = new P_HOME_COMMANDER(frame);
            frame.Content = pg;
        }
    }
}
