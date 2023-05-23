using Dapper;
using System.Data.SqlClient;

namespace LIB_BDD_Custom;
public class C_CLIENT
{
    public int IdClient { get; set; }
    public string nomClient { get; set; }
    public string prenomClient { get; set; }
    public string adresseClient { get; set; }
    public string cpClient { get; set; }
    public string photoClient { get; set; }
    public int authId { get; set; }
}

public partial class C_BASE
{


    /*  Fonction Get_All
    *  Fonction Get_Id
     *  Fonction Get_Nom
     *  Fonction Add
     *  Fonction Update
     *  Fonction Delete
     */

    public List<C_CLIENT> Get_All_Clients()
    {

        List<C_CLIENT> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_CLIENT>("select * from CLIENTS").ToList(); ;


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }

    }

    //------------------------------------

    public C_CLIENT Get_Client_By_Nom(string P_Nom)
    {
        C_CLIENT Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_CLIENT>("select * from CLIENTS where nomClient=@_nomClient", new { _nomClient = P_Nom }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
    //----------------------------------

    public C_CLIENT Get_Client_By_Id(int P_Id)
    {
        C_CLIENT Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_CLIENT>("select * from CLIENTS where IdClient=@_IdClient", new { _IdClient = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public C_CLIENT Get_Client_By_AuthId(int P_Id)
    {
        C_CLIENT Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_CLIENT>("select * from CLIENTS where authID=@_IdAuth", new { _IdAuth = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //-------------------------------

    public int Add_Client(C_CLIENT P_Client)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into CLIENTS(nomclient,prenomClient,adresseClient,cpClient,villeCLient,photoClient,authId) OUTPUT INSERTED.IdClient values (@_nomclient,@_prenomClient,@_adresseClient,@_cpClient,@_villeCLient,@_photoClient,@_authId) ",
                    new { _nomclient = P_Client.nomClient, _prenomClient = P_Client.prenomClient, _adresseClient = P_Client.adresseClient, _cpClient = P_Client.cpClient, _villeCLient = P_Client.cpClient, _photoClient = P_Client.photoClient, _authId = P_Client.authId});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //------------------------------------

    public void Update_Client(C_CLIENT P_Client)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_CLIENT unMicroType = La_Connexion.Query<C_CLIENT>("Select * from CLIENTS where IdClient=@_ID", new { _ID = P_Client.IdClient }).FirstOrDefault();
                if (unMicroType != null)
                {
                    La_Connexion.Query("UPDATE CLIENTS SET nomclient=@_nomClient, prenomClient=@_prenomClient, adresseClient=@_adresseClient, cpClient=@_cpClient, villeCLient=@_cpClient, photoClient=@_photoClient, authId=@_authId where IdClient=@_ID",
                        new { _nomclient = P_Client.nomClient, _prenomClient = P_Client.prenomClient, _adresseClient = P_Client.adresseClient, _cpClient = P_Client.cpClient, _villeCLient = P_Client.cpClient, _photoClient = P_Client.photoClient, _authId = P_Client.authId, _ID = P_Client.IdClient });
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //------------------------------

    public void Delete_Client(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM CLIENTS where IdClient=@_ID", new { _ID = P_Id });
            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
}