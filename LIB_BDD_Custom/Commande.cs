using Dapper;
using System.Data.SqlClient;

namespace LIB_BDD_Custom;

public class C_COMMANDE
{
    public int Id { get; set; }
    public string numeroCom { get; set; }
    public string reportagePhotoCam { get; set; }
    public int clientId { get; set; }
    public int guitareId { get; set; }
    public int prixTotal { get; set; }
}

public partial class C_BASE
{

    public List<C_COMMANDE> Get_All_Commandes()
    {
        List<C_COMMANDE> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_COMMANDE>("select * from COMMANDES").ToList(); ;


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
    //--------------------------------

    public string GenerateNumero()
    {
        try
        {
            Random random = new Random();
            int randomNumber = random.Next(1000000, 9999999); 
            string orderNumber = "CMD-" + randomNumber.ToString() + "-" + DateTime.Now.ToString("ddMMyyyy"); 
            return orderNumber;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------

    public C_COMMANDE Get_Commande_By_Id(int P_Id)
    {
        C_COMMANDE Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_COMMANDE>("select * from COMMANDES where Id=@_ID", new { _ID = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------

    public C_COMMANDE Get_Commande_By_Nom(string P_Nom)
    {
        C_COMMANDE Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_COMMANDE>("select * from COMMANDES where numeroCom=@_numeroCom", new { _numeroCom = P_Nom }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------

    public List<C_COMMANDE> Get_Commandes_By_IdClient(int P_Id)
    {
        List<C_COMMANDE> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_COMMANDE>("select * from COMMANDES where clientId=@_clientId", new { _clientId = P_Id }).ToList();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public int Add_Commande(C_COMMANDE P_Commande)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into COMMANDES(numeroCom,reportagePhotoCam,clientId,guitareId,prixTotal) OUTPUT INSERTED.Id values (@_numeroCom,@_reportagePhotoCam,@_clientId,@_guitareId,@_prixTotal) ", new { _numeroCom = GenerateNumero(), _reportagePhotoCam = P_Commande.reportagePhotoCam, _clientId = P_Commande.clientId, _guitareId = P_Commande.guitareId, _prixTotal = P_Commande.prixTotal});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
}