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
    public partial class P_HOME_VIBRATO : Page
    {
        Frame frame;
        public P_HOME_VIBRATO(Frame P_Page)
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
            C_COORDINATION.Instance.PageGuitare = 3;
            P_HOME_MICRO pg = new P_HOME_MICRO(frame);
            frame.Content = pg;
        }

        private void BTN_Suivant_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Ma_Guitare.VibratoId = C_COORDINATION.Instance.VibratoItem.IdVibrato;
            C_COORDINATION.Instance.PageGuitare = 5;
            P_HOME_VERIFICATION pg = new P_HOME_VERIFICATION(frame);
            frame.Content = pg;
        }

        private void CB_Vibrato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CB_Vibrato.SelectedIndex = C_COORDINATION.Instance.Vibrato;
        }
    }
}
