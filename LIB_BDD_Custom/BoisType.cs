using System.Data.SqlClient;
using System.Globalization;
using Dapper;

namespace LIB_BDD_Custom;

public class C_BOISTYPES
{
    public int IdBois { get; set; }
    public string nomBois { get; set; }
    public string descriptionBois { get; set; }
    public bool dispoBois { get; set; }
    public int prix { get; set; }

}

public partial class C_BASE
{
    //=====================
    //=== CRUD BOISTYPE ===
    //=====================

    /*  Fonction Get_All
     *  Fonction Get_By_Id
     *  Fonction Get_By_Name
     *  Fonction Add
     *  Fonction Update
     *  Fonction Delete
     */

    public List<C_BOISTYPES> Get_All_BoisTypes()
    {
        List<C_BOISTYPES> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_BOISTYPES>("select * from BOISTYPES").ToList();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------

    public C_BOISTYPES Get_BoisType_By_Id(int P_Id)
    {
        C_BOISTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_BOISTYPES>("select * from BOISTYPES where IdBois=@_ID", new { _ID = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------

    public C_BOISTYPES Get_BoisType_By_Nom(string P_Nom)
    {
        C_BOISTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_BOISTYPES>("select * from BOISTYPES where nomBois=@_nomBois", new { _nomBois = P_Nom }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //-----------------------------------

    public int Add_BoisType(C_BOISTYPES P_BoisType)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into BOISTYPES(nomBois,descriptionBois,dispoBois,prix) OUTPUT INSERTED.IdBois values (@_nomBois,@_descriptionBois,@_dispoBois,@_prix) ", new { _nomBois = P_BoisType.nomBois, _descriptionBois = P_BoisType.descriptionBois, _dispoBois = P_BoisType.dispoBois, _prix= P_BoisType.prix});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------------------------------

    public void Update_BoisType(C_BOISTYPES P_BoisType)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_BOISTYPES unBoisType = La_Connexion.Query<C_BOISTYPES>("Select * from BOISTYPES where IdBois=@_ID", new { _ID = P_BoisType.IdBois }).FirstOrDefault();
                if (unBoisType != null)
                {
                    La_Connexion.Query("UPDATE BOISTYPES SET nomBois=@_nomBois, descriptionBois=@_descriptionBois, dispoBois=@_dispoBois, prix=@_prix where IdBois=@_ID",
                        new { _nomBois = P_BoisType.nomBois, _descriptionBois = P_BoisType.descriptionBois, _dispoBois = P_BoisType.dispoBois, _prix= P_BoisType.prix, _ID = P_BoisType.IdBois });
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------------------------------------

    public void Delete_BoisType(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM BOISTYPES where IdBois=@_ID", new { _ID = P_Id });
            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------

    

}