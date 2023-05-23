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
    public partial class P_HOME_COMMANDER : Page
    {
        int validation = 0;
        Frame frame;
        public P_HOME_COMMANDER(Frame P_Page)
        {
            frame = P_Page;
            InitializeComponent();
            DataContext = C_COORDINATION.Instance;
            Affichage_Client();
            Creation_Guitare();
            Affiche_Descriptif();
        }

        public void Affiche_Descriptif()
        {
            if (validation > 0)
            {
                TB_Descriptif.Text = $"Bonjour {C_COORDINATION.Instance.LeClient.NomClient},\n\n" +
                          $"Nous avons bien reçu votre commande {C_COORDINATION.Instance.Ma_base.GetCommandeByIdAsync(validation).Result.NumeroCom} du {DateTime.Now.ToString("ddMMyyyy")} et nous vous en remercions.\n" +
                          "Elle sera traitée dans les plus brefs délais.\n\n" +
                          "Nous vous tiendrons informé(e) de l'avancée de votre commande sur notre application.\n" +
                          "N'hésitez pas à nous contacter si vous avez des questions ou des remarques.\n\n" +
                          "Cordialement,\n" +
                          "L'équipe de GuizTar";
            }
            else
            {
                TB_Descriptif.Text = "Une erreur a eu lieu dans votre création de votre guitare !";
            }
        }
        public void Creation_Guitare()
        {
            try
            {
                
                var IdGuitare = C_COORDINATION.Instance.Ma_base.AddGuitareAsync(C_COORDINATION.Instance.Ma_Guitare).Result;
                try
                {
                    C_COMMANDE La_Command = new C_COMMANDE() {ClientId = C_COORDINATION.Instance.LeClient.IdClient,
                        GuitareId = IdGuitare,
                        ReportagePhotoCam = "photo",
                        PrixTotal = C_COORDINATION.Instance.BoisCorpItem.Prix + C_COORDINATION.Instance.BoisMancheItem.Prix + C_COORDINATION.Instance.BoisToucheItem.Prix + C_COORDINATION.Instance.MicroNuckItem.Prix + C_COORDINATION.Instance.MicroCenterItem.Prix + C_COORDINATION.Instance.MicroBridgeItem.Prix + C_COORDINATION.Instance.VibratoItem.Prix
                    };
                    validation = C_COORDINATION.Instance.Ma_base.AddCommandeAsync(La_Command).Result;
                    C_COORDINATION.Instance.checkMois(La_Command.PrixTotal);
                }
                catch
                {
                    MessageBox.Show("Erreur durant la création de la commande");
                }
            }
            catch
            {
                MessageBox.Show("Erreur durant la création de votre guitare");
            }

        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        

        private void BTN_Suivant_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.PageGuitare = 1;
            P_HOME pg = new P_HOME(frame);
            frame.Content = pg;
        }
    }
}
