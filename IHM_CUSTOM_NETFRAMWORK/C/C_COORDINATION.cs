using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NS_WS;

namespace IHM_CUSTOM_NETFRAMWORK.C
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

        public void RefreshList()
        {
            var bois = Ma_base.GetAllBoisTypesAsync().Result;
            Liste_Bois = bois.ToList();
            var Micro = Ma_base.GetAllMicroTypesAsync().Result;
            Liste_Micro = Micro.ToList();
            var Commandes = Ma_base.GetAllCommandesAsync().Result;
            Liste_Commande = Commandes.ToList();
            var stat = Ma_base.GetStatistiqueAsync().Result;
            Liste_Stat = stat.ToList();
            var vibrato = Ma_base.GetAllVibratoTypesAsync().Result;
            Liste_Vibrato = vibrato.ToList();
            var client = Ma_base.GetAllClientsAsync().Result;
            Liste_Client = client.ToList();

        }
        private List<C_CLIENT> _Liste_Client;

        public List<C_CLIENT> Liste_Client
        {
            get { return _Liste_Client; }
            set { _Liste_Client = value; Signale_Changement(); }
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
