using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NS_WS;

namespace IHM_VRAI_CUSTOM_NET.C
{
    public class C_COORDINATION : C_NOTIFIABLE
    {
        public C_WS Ma_base;
        private static C_COORDINATION _instance = null;

        public static C_COORDINATION Instance
        {
            get
            {
                if (_instance == null) { _instance = new C_COORDINATION(); }
                return _instance;
            }
        }

        public C_COORDINATION()
        {


            HttpClient client = new HttpClient();
            Ma_base = new C_WS("https://webapibddtsquitare.azurewebsites.net/", client);
            RefreshList();

        }

        public void checkMois(int P_Prix)
        {
            try
            {
                var stat = Ma_base.GetStatistiqueByDateAnneeAsync(DateTime.Now.Year).Result;
                switch (DateTime.Now.Month)
                {
                    case 1: stat.RevenueMoisJanv += P_Prix; break;
                    case 2: stat.RevenueMoisFevr += P_Prix; break;
                    case 3: stat.RevenueMoisMars += P_Prix; break;
                    case 4: stat.RevenueMoisAvri += P_Prix; break;
                    case 5: stat.RevenueMoisMai += P_Prix; break;
                    case 6: stat.RevenueMoisJuin += P_Prix; break;
                    case 7: stat.RevenueMoisJuil += P_Prix; break;
                    case 8: stat.RevenueMoisAout += P_Prix; break;
                    case 9: stat.RevenueMoisSept += P_Prix; break;
                    case 10: stat.RevenueMoisOcto += P_Prix; break;
                    case 11: stat.RevenueMoisNove += P_Prix; break;
                    case 12: stat.RevenueMoisDece += P_Prix; break;
                }
                stat.RevenueTotal = stat.RevenueMoisJanv + stat.RevenueMoisFevr + stat.RevenueMoisMars + stat.RevenueMoisAvri + stat.RevenueMoisMai + stat.RevenueMoisJuin + stat.RevenueMoisJuil + stat.RevenueMoisAout + stat.RevenueMoisSept + stat.RevenueMoisOcto + stat.RevenueMoisNove + stat.RevenueMoisDece;
                Ma_base.UpdateStatistiqueAsync(stat);
            }
            catch
            {

            }
        }
        
        public void RefreshCommande()
        {
            var Commandes = Ma_base.GetCommandesByIdClientAsync(LeClient.IdClient).Result;
            Liste_Commande = Commandes.ToList();
        }

        public void RefreshList()
        {
            var bois = Ma_base.GetAllBoisTypesAsync().Result;
            Liste_Bois = bois.ToList();
            var Micro = Ma_base.GetAllMicroTypesAsync().Result;
            Liste_Micro = Micro.ToList();
            
            var stat = Ma_base.GetStatistiqueAsync().Result;
            Liste_Stat = stat.ToList();
            var vibrato = Ma_base.GetAllVibratoTypesAsync().Result;
            Liste_Vibrato = vibrato.ToList();
            

        }
        private int _PageGuitare;

        public int PageGuitare
        {
            get { return _PageGuitare; }
            set { _PageGuitare = value; Signale_Changement(); }
        }

        private int _BoisCorp;

        public int BoisCorp
        {
            get { return _BoisCorp; }
            set { _BoisCorp = value; Signale_Changement(); }
        }

        private int _BoisManche;

        public int BoisManche
        {
            get { return _BoisManche; }
            set { _BoisManche = value; Signale_Changement(); }
        }

        private int _BoisTouche;

        public int BoisTouche
        {
            get { return _BoisTouche; }
            set { _BoisTouche = value; Signale_Changement(); }
        }

        private int _MicroNuck;

        public int MicroNuck
        {
            get { return _MicroNuck; }
            set { _MicroNuck = value; Signale_Changement(); }
        }

        private int _MicroCenter;

        public int MicroCenter
        {
            get { return _MicroCenter; }
            set { _MicroCenter = value; Signale_Changement(); }
        }

        private int _MicroBridge;

        public int MicroBridge
        {
            get { return _MicroBridge; }
            set { _MicroBridge = value; Signale_Changement(); }
        }

        private int _Vibrato;

        public int Vibrato
        {
            get { return _Vibrato; }
            set { _Vibrato = value;Signale_Changement(); }
        }


        private int _PageGuitareItem;

        public int PageGuitareItem
        {
            get { return _PageGuitareItem; }
            set { _PageGuitareItem = value; Signale_Changement(); }
        }

        private C_BOISTYPES _BoisCorpItem;

        public C_BOISTYPES BoisCorpItem
        {
            get { return _BoisCorpItem; }
            set { _BoisCorpItem = value; Signale_Changement(); }
        }

        private C_BOISTYPES _BoisMancheItem;

        public C_BOISTYPES BoisMancheItem
        {
            get { return _BoisMancheItem; }
            set { _BoisMancheItem = value; Signale_Changement(); }
        }

        private C_BOISTYPES _BoisToucheItem;

        public C_BOISTYPES BoisToucheItem
        {
            get { return _BoisToucheItem; }
            set { _BoisToucheItem = value; Signale_Changement(); }
        }

        private C_MICROTYPES _MicroNuckItem;

        public C_MICROTYPES MicroNuckItem
        {
            get { return _MicroNuckItem; }
            set { _MicroNuckItem = value; Signale_Changement(); }
        }

        private C_MICROTYPES _MicroCenterItem;

        public C_MICROTYPES MicroCenterItem
        {
            get { return _MicroCenterItem; }
            set { _MicroCenterItem = value; Signale_Changement(); }
        }

        private C_MICROTYPES _MicroBridgeItem;

        public C_MICROTYPES MicroBridgeItem
        {
            get { return _MicroBridgeItem; }
            set { _MicroBridgeItem = value; Signale_Changement(); }
        }

        private C_VIBRATOTYPES _VibratoItem;

        public C_VIBRATOTYPES VibratoItem
        {
            get { return _VibratoItem; }
            set { _VibratoItem = value; Signale_Changement(); }
        }


        private C_CLIENT _LeClient;

        public C_CLIENT LeClient
        {
            get { return _LeClient; }
            set { _LeClient = value;Signale_Changement(); }
        }


        private bool _exit;

        public bool exit
        {
            get { return _exit; }
            set { _exit = value; Signale_Changement(); }
        }

        private C_GUITARE _Ma_Guitare;

        public C_GUITARE Ma_Guitare
        {
            get { return _Ma_Guitare; }
            set { _Ma_Guitare = value; Signale_Changement(); }
        }



        private C_COMMANDE _Commande_Selec;

        public C_COMMANDE Commande_Selec
        {
            get { return _Commande_Selec; }
            set { _Commande_Selec = value; Signale_Changement(); }
        }


        private List<C_VIBRATOTYPES> _Liste_Vibrato;

        public List<C_VIBRATOTYPES> Liste_Vibrato
        {
            get { return _Liste_Vibrato; }
            set { _Liste_Vibrato = value; Signale_Changement(); }
        }

        private C_VIBRATOTYPES _Vibrato_Selec;

        public C_VIBRATOTYPES Vibrato_Selec
        {
            get { return _Vibrato_Selec; }
            set { _Vibrato_Selec = value; Signale_Changement(); }
        }



        private List<C_STATISTIQUE> _Liste_Stat;

        public List<C_STATISTIQUE> Liste_Stat
        {
            get { return _Liste_Stat; }
            set { _Liste_Stat = value; Signale_Changement(); }
        }

        private C_BOISTYPES _Bois_Selec;

        public C_BOISTYPES Bois_Selec
        {
            get { return _Bois_Selec; }
            set { _Bois_Selec = value; Signale_Changement(); }
        }

        private C_MICROTYPES _Micro_Selec;

        public C_MICROTYPES Micro_Selec
        {
            get { return _Micro_Selec; }
            set { _Micro_Selec = value; Signale_Changement(); }
        }



        private List<C_MICROTYPES> _Liste_Micro;

		public List<C_MICROTYPES> Liste_Micro
		{
			get { return _Liste_Micro; }
			set { _Liste_Micro = value; Signale_Changement(); }
		}
        private List<C_BOISTYPES> _Liste_Bois;

        public List<C_BOISTYPES> Liste_Bois
        {
            get { return _Liste_Bois; }
            set { _Liste_Bois = value; Signale_Changement(); }
        }

        private List<C_COMMANDE> _Liste_Commande;

        public List<C_COMMANDE> Liste_Commande
        {
            get { return _Liste_Commande; }
            set { _Liste_Commande = value;Signale_Changement(); }
        }


    }
}
