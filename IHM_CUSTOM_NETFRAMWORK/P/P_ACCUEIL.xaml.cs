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
using IHM_CUSTOM_NETFRAMWORK.C;
using LiveCharts;

namespace IHM_CUSTOM_NETFRAMWORK.P
{
    /// <summary>
    /// Logique d'interaction pour P_ACCUEIL.xaml
    /// </summary>
    public partial class P_ACCUEIL : Page
    {
        public P_ACCUEIL()
        {
            InitializeComponent();
            RefreshStat();
            AddListeOrders();
        }
        public void RefreshStat()
        {
            TB_NombreVue.Text = $"{C_COORDINATION.Instance.Liste_Stat[0].NombreVue}";
            TB_NombreCommande.Text = $"{C_COORDINATION.Instance.Liste_Commande.Count}";
            TB_RevenueTotal.Text = $"{C_COORDINATION.Instance.Liste_Stat[0].RevenueTotal}€";
            var values = new ChartValues<int>();
            values.Add(0);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisJanv);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisFevr);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisMars);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisAvri);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisMai);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisJuin);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisJuil);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisAout);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisSept);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisOcto);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisNove);
            values.Add(C_COORDINATION.Instance.Liste_Stat[0].RevenueMoisDece);
            LS_Profit.Values = values;
        }

        public void AddListeOrders()
        {
            int nombreCommande = C_COORDINATION.Instance.Liste_Commande.Count();
            List<string> listeOrders = new List<string>();

            for(int i = nombreCommande;nombreCommande-5<i;i--)
            {

                var leClient = C_COORDINATION.Instance.Ma_base.GetClientByIdAsync(C_COORDINATION.Instance.Liste_Commande[i-1].ClientId).Result;
                listeOrders.Add($"{leClient.NomClient} {leClient.PrenomClient} {C_COORDINATION.Instance.Liste_Commande[i - 1].PrixTotal}€");
            }
            TB_TOrder1.Text = $"{C_COORDINATION.Instance.Liste_Commande[nombreCommande - 1].NumeroCom}";
            TB_TOrder2.Text = $"{C_COORDINATION.Instance.Liste_Commande[nombreCommande - 2].NumeroCom}";
            TB_TOrder3.Text = $"{C_COORDINATION.Instance.Liste_Commande[nombreCommande - 3].NumeroCom}";
            TB_TOrder4.Text = $"{C_COORDINATION.Instance.Liste_Commande[nombreCommande - 4].NumeroCom}";
            TB_TOrder5.Text = $"{C_COORDINATION.Instance.Liste_Commande[nombreCommande - 5].NumeroCom}";

            TB_Order1.Text = $"{listeOrders[0]}";
            TB_Order2.Text = $"{listeOrders[1]}";
            TB_Order3.Text = $"{listeOrders[2]}";
            TB_Order4.Text = $"{listeOrders[3]}";
            TB_Order5.Text = $"{listeOrders[4]}";


        }
    }
}
