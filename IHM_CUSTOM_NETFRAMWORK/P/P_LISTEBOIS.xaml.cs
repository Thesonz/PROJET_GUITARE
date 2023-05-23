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
using IHM_CUSTOM_NETFRAMWORK.C;
using NS_WS;

namespace IHM_CUSTOM_NETFRAMWORK.P
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
            C_COORDINATION.Instance.RefreshList();
        }

        private void BTN_Nouveau_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_BOISTYPES Nouveau_Bois = new C_BOISTYPES() { NomBois = TB_Nom.Text, DescriptionBois = TB_Description.Text, DispoBois = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text) };
                C_COORDINATION.Instance.Ma_base.AddBoisTypeAsync(Nouveau_Bois);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Bois_Selec = new C_BOISTYPES();

            }
            catch(Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_BOISTYPES Modifier_Bois = new C_BOISTYPES() { NomBois = TB_Nom.Text, DescriptionBois = TB_Description.Text, DispoBois = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text), IdBois = C_COORDINATION.Instance.Bois_Selec.IdBois };
                C_COORDINATION.Instance.Ma_base.UpdateBoisTypeAsync(Modifier_Bois);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Bois_Selec = new C_BOISTYPES();
            }
            catch (Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_COORDINATION.Instance.Ma_base.DeleteBoisTypeAsync(C_COORDINATION.Instance.Bois_Selec.IdBois);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Bois_Selec = new C_BOISTYPES();
            }
            catch (Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Vider_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Bois_Selec = new C_BOISTYPES();
        }
    }
}
