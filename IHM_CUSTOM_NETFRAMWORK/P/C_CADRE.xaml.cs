using IHM_CUSTOM_NETFRAMWORK.C;
using LiveCharts;
using Microsoft.Extensions.DependencyInjection;
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

namespace IHM_CUSTOM_NETFRAMWORK.P
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class C_CADRE : Window
    {

       
        public C_CADRE()
        {
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
            P_ACCUEIL page = new P_ACCUEIL();
            F_Page.Content = page;
        }

        
        

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void BTN_Quitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Bois_Click(object sender, RoutedEventArgs e)
        {
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_LISTEBOIS pg = new P_LISTEBOIS();
            F_Page.Content = pg;
        }

        private void BTN_Micro_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_LISTEMICRO pg = new P_LISTEMICRO();
            F_Page.Content = pg;
        }

        private void BTN_Vibrato_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_VIBRATO pg = new P_VIBRATO();
            F_Page.Content = pg;
        }

        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_ACCUEIL pg = new P_ACCUEIL();
            F_Page.Content = pg;
        }

        private void BTN_Commande_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_COMMANDE pg = new P_COMMANDE();
            F_Page.Content = pg;
        }
    }
}
