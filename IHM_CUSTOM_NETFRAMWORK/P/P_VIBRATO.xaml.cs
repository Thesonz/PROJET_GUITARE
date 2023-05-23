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
    /// Logique d'interaction pour P_VIBRATO.xaml
    /// </summary>
    public partial class P_VIBRATO : Page
    {
        public P_VIBRATO()
        {
            InitializeComponent();

            DataContext = C_COORDINATION.Instance;
            C_COORDINATION.Instance.Vibrato_Selec = new C_VIBRATOTYPES();
            C_COORDINATION.Instance.RefreshList();
        }

        private void BTN_Nouveau_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                C_VIBRATOTYPES Nouveau_Vibrato = new C_VIBRATOTYPES() { NomVibrato = TB_Nom.Text, DescriptionVibrato = TB_Description.Text, DispoVibrato = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text) };
                C_COORDINATION.Instance.Ma_base.AddVibratoTypeAsync(Nouveau_Vibrato);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Vibrato_Selec = new C_VIBRATOTYPES();

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
                C_VIBRATOTYPES Modifier_Vibrato = new C_VIBRATOTYPES() { NomVibrato = TB_Nom.Text, DescriptionVibrato = TB_Description.Text, DispoVibrato = Convert.ToBoolean(TB_Dispo.Text), Prix = Convert.ToInt32(TB_Prix.Text), IdVibrato = C_COORDINATION.Instance.Vibrato_Selec.IdVibrato };
                C_COORDINATION.Instance.Ma_base.UpdateVibratoTypeAsync(Modifier_Vibrato);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Vibrato_Selec = new C_VIBRATOTYPES();
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
                C_COORDINATION.Instance.Ma_base.DeleteVibratoTypeAsync(C_COORDINATION.Instance.Vibrato_Selec.IdVibrato);
                Thread.Sleep(100);
                C_COORDINATION.Instance.RefreshList();
                C_COORDINATION.Instance.Vibrato_Selec = new C_VIBRATOTYPES();
            }
            catch (Exception ex)
            {
                TB_Erreur.Text = ex.Message;
            }
        }

        private void BTN_Vider_Click(object sender, RoutedEventArgs e)
        {
            C_COORDINATION.Instance.Vibrato_Selec = new C_VIBRATOTYPES();
        }
    }
}
