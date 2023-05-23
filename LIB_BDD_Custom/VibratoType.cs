using System.Data.SqlClient;
using Dapper;

namespace LIB_BDD_Custom;

public class C_VIBRATOTYPES
{
    public int IdVibrato { get; set; }
    public string nomVibrato { get; set; }
    public string descriptionVibrato { get; set; }
    public bool dispoVibrato { get; set; }
    public int prix { get; set; }
}

public partial class C_BASE
{
    //========================
    //=== CRUD VibratoTYPE ===
    //========================

    /*  Fonction Get_All
     *  Fonction Get_By_Id
     *  Fonction Get_By_Name
     *  Fonction Add
     *  Fonction Update
     *  Fonction Delete
     */

    public List<C_VIBRATOTYPES> Get_All_VibratoTypes()
    {
        List<C_VIBRATOTYPES> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_VIBRATOTYPES>("select * from VIBRATOTYPES").ToList(); ;


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------

    public C_VIBRATOTYPES Get_VibratoType_By_Id(int P_Id)
    {
        C_VIBRATOTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_VIBRATOTYPES>("select * from VIBRATOTYPES where IdVibrato=@_ID", new { _ID = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------

    public C_VIBRATOTYPES Get_VibratoType_By_Nom(string P_Nom)
    {
        C_VIBRATOTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_VIBRATOTYPES>("select * from VIBRATOTYPES where nomVibrato=@_nomVibrato", new { _nomVibrato = P_Nom }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //-----------------------------------

    public int Add_VibratoType(C_VIBRATOTYPES P_VibratoType)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into VIBRATOTYPES(nomVibrato,descriptionVibrato,dispoVibrato,prix) OUTPUT INSERTED.IdVibrato values (@_nomVibrato,@_descriptionVibrato,@_dispoVibrato,@_prix) ", new { _nomVibrato = P_VibratoType.nomVibrato, _descriptionVibrato = P_VibratoType.descriptionVibrato, _dispoVibrato = P_VibratoType.dispoVibrato, _prix= P_VibratoType.prix });


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------------------------------

    public void Update_VibratoType(C_VIBRATOTYPES P_VibratoType)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_VIBRATOTYPES unMicroType = La_Connexion.Query<C_VIBRATOTYPES>("Select * from VIBRATOTYPES where IdVibrato=@_ID", new { _ID = P_VibratoType.IdVibrato }).FirstOrDefault();
                if (unMicroType != null)
                {
                    La_Connexion.Query("UPDATE VIBRATOTYPES SET nomVibrato=@_nomVibrato, descriptionVibrato=@_descriptionVibrato, dispoVibrato=@_dispoVibrato, prix=@_prix where IdVibrato=@_ID",
                        new { _nomVibrato = P_VibratoType.nomVibrato, _descriptionVibrato = P_VibratoType.descriptionVibrato, _dispoVibrato = P_VibratoType.dispoVibrato, _prix = P_VibratoType.prix, _ID = P_VibratoType.IdVibrato });
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------------------------------------

    public void Delete_VibratoType(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM VIBRATOTYPES where IdVibrato=@_ID", new { _ID = P_Id });
            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
}
