using System.Net;
using LIB_BDD_Custom;
using static LIB_BDD_Custom.C_BASE;

namespace CMD_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C_BASE Ma_Base = new C_BASE();
            /*WebClient client = new WebClient();

            // Récupérer le code source de la page web
            string htmlCode = client.DownloadString("https://www.guitare-electrique.org/dossiers/bois-guitare.php");

          
            string[] tableauString = new string[11];
            tableauString[0] = htmlCode.Substring(htmlCode.IndexOf($"<!-- Project One -->"), (htmlCode.LastIndexOf($"<!-- /.one -->") - htmlCode.IndexOf($"<!-- Project One -->")));
            for (int i = 1; i < 11; i++)
            {
                tableauString[i] = htmlCode.Substring(htmlCode.IndexOf($"<!-- Project {i+1} -->"), (htmlCode.LastIndexOf($"<!-- /.{i+1} -->") - htmlCode.IndexOf($"<!-- Project {i+1} -->")));
            }

            var ListeBoisType = Ma_Base.Get_All_BoisTypes();

            foreach (var item in ListeBoisType)
            {
                Console.WriteLine($"ID: {item.IdBois} Nom : {item.nomBois},Des : {item.descriptionBois},dispo : {item.dispoBois}");
            }*/

            /*foreach (var item in tableauString)
            {
                Console.WriteLine(item);
                int debTitre = item.IndexOf("<h3>");
                int finTitre = item.LastIndexOf("</h3>");
                string Titre = item.Substring(debTitre+4, finTitre-4 - debTitre);

                int debDes = item.IndexOf("<p>");
                int finDes = item.LastIndexOf("</p>");
                string Descri = item.Substring(debDes + 3, finDes - 3 - debDes);

            }*/

            /*C_BASE Ma_Base = new C_BASE();

            Console.WriteLine();

            //Ma_Base.Add_BoisType(new C_BOISTYPES() {nomBois= "L'aulne",descriptionBois= "bois dur 530 Kg/m3,fragile", dispoBois=false });
            //Ma_Base.Update_BoisType(new C_BOISTYPES() { IdBois = 3, nomBois = "toto", descriptionBois = "gay", dispoBois = true });
            Ma_Base.Delete_BoisType(6);

            var ListeBoisType = Ma_Base.Get_All_BoisTypes();

            foreach (var item in ListeBoisType)
            {
                Console.WriteLine($"ID: {item.IdBois} Nom : {item.nomBois},Des : {item.descriptionBois},dispo : {item.dispoBois}");
            }
            */

            //Ma_Base.Add_MicroType(new C_MICROTYPES() { nomMicro = "Air ClassicTM Bridge - DP191", descriptionMicro= @"Sortie : 226,Basse : 3.5,Bas Moyen : 4.5,Haut Moyen : 4.0,Tripler : 6.0", dispoMicro=true });

            //Ma_Base.Add_VibratoType(new C_VIBRATOTYPES() { nomVibrato= "Brass tremolo", descriptionVibrato="test", dispoVibrato=true});

            //Ma_Base.Add_Authentification(new C_AUTHENTIFICATION() { adresseMailAuth = "test1@gmail.com", passwordAuth = "test1" });

            //Ma_Base.Add_Client(new C_CLIENT() { prenomClient = "prenom1", nomClient = "nom1", adresseClient = "1 rue de la madone", cpClient = "30700", photoClient = "/photo1.png", authId = 1 });


            //var test = Ma_Base.Add_Commande(new C_COMMANDE() { clientId=1, guitareId=4, numeroCom="test", reportagePhotoCam="test" });
            //Console.WriteLine(test);
            //foreach (var item in Ma_Base.Get_All_Commandes())
            //{
            //Console.WriteLine($"{item.Id} {item.numeroCom} {item.reportagePhotoCam} {item.guitareId} {item.clientId}");
            //}

            //Ma_Base.Add_Statistique(new C_STATISTIQUE() { nombreVue = 1, revenueAnnee = 0, revenueMois = 0, revenueTotal = 0 });

            //Ma_Base.Delete_Statistique(1);

            //Ma_Base.Add_Statistique(new C_STATISTIQUE() { nombreVue = 1, dateAnnee = 2023, revenueMoisJanv = 1000, revenueMoisFevr = 2000, revenueMoisMars = 3000, revenueMoisAvri = 4000, revenueMoisMai = 2000, revenueMoisJuin = 0, revenueMoisJuil = 0, revenueMoisAout = 0, revenueMoisSept = 0, revenueMoisOcto = 0, revenueMoisNove = 0, revenueMoisDece = 0, revenueAnnee = 12000, revenueTotal = 12000 });

            /*var toto = Ma_Base.Get_All_MicroTypes();
            foreach (var t in toto)
            {
                Console.WriteLine($"{t.IdMicro} {t.nomMicro}");
            }*/

            Console.WriteLine(Ma_Base.HashPassword("test1"));
            Console.WriteLine(Ma_Base.HashPassword("test2"));
            Console.WriteLine(Ma_Base.HashPassword("test3"));

        }
    }
}