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
    public partial class P_LISTECOMMANDE : Page
    {

        public P_LISTECOMMANDE()
        {
            InitializeComponent();

            // Ma_Conf = P_Conf;
            DataContext = C_COORDINATION.Instance;
            Affichage_Client();

            C_COORDINATION.Instance.RefreshCommande();
        }

        public void Affichage_Client()
        {

            TB_HomeTitle.Text = $"Bonjour, {C_COORDINATION.Instance.LeClient.PrenomClient} {C_COORDINATION.Instance.LeClient.NomClient}";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (C_COORDINATION.Instance.Commande_Selec != null)
            {
                C_COMMANDE La_Commande = C_COORDINATION.Instance.Commande_Selec;
                C_GUITARE La_Guitare = C_COORDINATION.Instance.Ma_base.GetGuitareByIdAsync(La_Commande.GuitareId).Result;
                TB_Date.Text = $"{La_Commande.NumeroCom.Substring(12,2)}/{La_Commande.NumeroCom.Substring(14, 2)}/{La_Commande.NumeroCom.Substring(16, 4)}";
                var Manche = C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.MancheBoisId).Result;
                TB_MancheBois.Text = $"{Manche.NomBois}";
                var Corp = C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.CorpBoisId).Result;
                TB_CorpBois.Text = $"{Corp.NomBois}";
                var Touche = C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.ToucheBoisId).Result;
                TB_ToucheBois.Text = $"{Touche.NomBois}";
                var Neck = C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.NeckMicroId).Result;
                TB_NeckMicro.Text = $"{Neck.NomMicro}";
                var Central = C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.CentralMicroId).Result;
                TB_CentralMicro.Text = $"{Central.NomMicro}";
                var Bridge = C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.BridgeMicroId).Result;
                TB_BridgeMicro.Text = $"{Bridge.NomMicro}";
                var Vibrato = C_COORDINATION.Instance.Ma_base.GetVibratoTypeByIdAsync(La_Guitare.VibratoId).Result;
                TB_Vibrato.Text = $"{Vibrato.NomVibrato}";
                TB_PrixTotal.Text = $"{La_Commande.PrixTotal}€";
            }
        }
    }
}
