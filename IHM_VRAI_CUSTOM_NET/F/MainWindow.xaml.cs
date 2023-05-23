using IHM_VRAI_CUSTOM_NET.C;
using IHM_VRAI_CUSTOM_NET.F.P;
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

namespace IHM_VRAI_CUSTOM_NET.F
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;

            C_COORDINATION.Instance.exit = false;
            F_LOGIN f_LOGIN = new F_LOGIN();
            f_LOGIN.ShowDialog();

            if(C_COORDINATION.Instance.LeClient == null)
            {
                Close();
            }
            else { 
                TB_PN.Text = Initial_Prenom_Nom();
                var stat = C_COORDINATION.Instance.Ma_base.GetStatistiqueByDateAnneeAsync(DateTime.Now.Year).Result;
                stat.NombreVue++;
                C_COORDINATION.Instance.Ma_base.UpdateStatistiqueAsync(stat);
                C_COORDINATION.Instance.PageGuitare = 1;
                P_HOME pg = new P_HOME(F_Page);
                F_Page.Content = pg;
            }


           
        }

        public string Initial_Prenom_Nom()
        {
            if (C_COORDINATION.Instance.LeClient != null)
            {
                string nom = C_COORDINATION.Instance.LeClient.NomClient;
            string prenom = C_COORDINATION.Instance.LeClient.PrenomClient;

            return $"{prenom.Substring(0, 1)}{nom.Substring(0,1)}".ToUpper();
            }
            return "";
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BTN_Commande_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_LISTECOMMANDE pg = new P_LISTECOMMANDE();
            F_Page.Content = pg;
        }

        private void BTN_Quitter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Vibrato_Click(object sender, RoutedEventArgs e)
        {
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButtonActive"];
            P_LISTEVIBRATO pg = new P_LISTEVIBRATO();
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

        private void BTN_Home_Click(object sender, RoutedEventArgs e)
        {
            BTN_Micro.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Vibrato.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Bois.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Commande.Style = (Style)Application.Current.Resources["menuButton"];
            BTN_Home.Style = (Style)Application.Current.Resources["menuButtonActive"];
            switch (C_COORDINATION.Instance.PageGuitare)
            {
                case 1: P_HOME pg = new P_HOME(F_Page); F_Page.Content = pg; break;
                case 2: P_HOME_BOIS pgb = new P_HOME_BOIS(F_Page); F_Page.Content = pgb; break;
                case 3: P_HOME_MICRO pgm = new P_HOME_MICRO(F_Page); F_Page.Content = pgm; break;
                case 4: P_HOME_VIBRATO pgvi = new P_HOME_VIBRATO(F_Page); F_Page.Content = pgvi; break;
                case 5: P_HOME_VERIFICATION pgve = new P_HOME_VERIFICATION(F_Page); F_Page.Content = pgve; break;
            }
        }
    }
}
