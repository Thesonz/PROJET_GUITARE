using IHM_CUSTOM_NETFRAMWORK.C;
using NS_WS;
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

namespace IHM_CUSTOM_NETFRAMWORK.P
{
    /// <summary>
    /// Logique d'interaction pour P_LISTEMICRO.xaml
    /// </summary>
    public partial class P_LISTEMICRO : Page
    {
        public P_LISTEMICRO()
        {
            InitializeComponent();

            DataContext = C_COORDINATION.Instance;
            C_COORDINATION.Instance.Micro_Selec = new C_MICROTYPES();
            C_COORDINATION.Instance.RefreshList();
        }

        private void BTN_Nouveau_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_MICROTYPES Nouveau_Micro = new C_MICROTYPES() { NomMicro = TB_Nom.Text, DescriptionMicro = TB_Description.Text, DispoMicro = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text) };
                C_COORDINATION.Instance.Ma_base.AddMicroTypeAsync(Nouveau_Micro);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Micro_Selec = new C_MICROTYPES();

            }
            catch (Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_MICROTYPES Modifier_Micro = new C_MICROTYPES() { NomMicro = TB_Nom.Text, DescriptionMicro = TB_Description.Text, DispoMicro = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text), IdMicro = C_COORDINATION.Instance.Micro_Selec.IdMicro };
                C_COORDINATION.Instance.Ma_base.UpdateMicroTypeAsync(Modifier_Micro);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Micro_Selec = new C_MICROTYPES();
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
                C_COORDINATION.Instance.Ma_base.DeleteMicroTypeAsync(C_COORDINATION.Instance.Micro_Selec.IdMicro);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Micro_Selec = new C_MICROTYPES();
            }
            catch (Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Vider_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Micro_Selec = new C_MICROTYPES();
        }

    }
}
