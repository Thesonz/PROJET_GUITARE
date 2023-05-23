using IHM_CUSTOM_NETFRAMWORK.C;
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
    /// Logique d'interaction pour P_COMMANDE.xaml
    /// </summary>
    public partial class P_COMMANDE : Page
    {
        public P_COMMANDE()
        {
            InitializeComponent();

            DataContext = C_COORDINATION.Instance;
        }

        private void LTB_Commande_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LTB_Commande.SelectedItem != null)
            {
                C_COMMANDE La_Commande = (C_COMMANDE)LTB_Commande.SelectedItem;
                C_CLIENT Le_Client = C_COORDINATION.Instance.Ma_base.GetClientByIdAsync(La_Commande.ClientId).Result;
                TB_Nom.Text = Le_Client.NomClient;
                TB_Prenom.Text = Le_Client.PrenomClient;
                C_GUITARE La_Guitare = C_COORDINATION.Instance.Ma_base.GetGuitareByIdAsync(La_Commande.GuitareId).Result;
                TB_MancheBois.Text = $"{C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.MancheBoisId).Result.NomBois}";
                TB_CorpBois.Text = $"{C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.CorpBoisId).Result.NomBois}";
                TB_ToucheBois.Text = $"{C_COORDINATION.Instance.Ma_base.GetBoisTypeByIdAsync(La_Guitare.ToucheBoisId).Result.NomBois}";
                TB_NeckMicro.Text = $"{C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.NeckMicroId).Result.NomMicro}";
                TB_CentralMicro.Text = $"{C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.CentralMicroId).Result.NomMicro}";
                TB_BridgeMicro.Text = $"{C_COORDINATION.Instance.Ma_base.GetMicroTypeByIdAsync(La_Guitare.BridgeMicroId).Result.NomMicro}";
                TB_Vibrato.Text = $"{C_COORDINATION.Instance.Ma_base.GetVibratoTypeByIdAsync(La_Guitare.VibratoId).Result.NomVibrato}";
            }
        }
    }
}
