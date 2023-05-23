using System.Data.SqlClient;
using Dapper;

namespace LIB_BDD_Custom;

public class C_MICROTYPES
{
    public int IdMicro { get; set; }
    public string nomMicro { get; set; }
    public string descriptionMicro { get; set; }
    public bool dispoMicro { get; set; }
    public int prix { get; set; }
}

public partial class C_BASE
{

    //======================
    //=== CRUD MicroTYPE ===
    //======================

    /*  Fonction Get_All
     *  Fonction Get_By_Id
     *  Fonction Get_By_Name
     *  Fonction Add
     *  Fonction Update
     *  Fonction Delete
     */

    public List<C_MICROTYPES> Get_All_MicroTypes()
    {
        List<C_MICROTYPES> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_MICROTYPES>("select * from MICROTYPES").ToList();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }


    //---------------------------

    public C_MICROTYPES Get_MicroType_By_Id(int P_Id)
    {
        C_MICROTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_MICROTYPES>("select * from MICROTYPES where IdMicro=@_ID", new { _ID = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------

    public C_MICROTYPES Get_MicroType_By_Nom(string P_Nom)
    {
        C_MICROTYPES Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_MICROTYPES>("select * from MICROTYPES where nomMicro=@_nomMicro", new { _nomMicro = P_Nom }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //-----------------------------------

    public int Add_MicroType(C_MICROTYPES P_MicroType)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into MICROTYPES(nomMicro,descriptionMicro,dispoMicro,prix) OUTPUT INSERTED.IdMicro values (@_nomMicro,@_descriptionMicro,@_dispoMicro,@_prix) ", new { _nomMicro = P_MicroType.nomMicro, _descriptionMicro = P_MicroType.descriptionMicro, _dispoMicro = P_MicroType.dispoMicro, _prix = P_MicroType.prix});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //--------------------------------------------------------

    public void Update_MicroType(C_MICROTYPES P_MicroType)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_MICROTYPES unMicroType = La_Connexion.Query<C_MICROTYPES>("Select * from MICROTYPES where IdMicro=@_ID", new { _ID = P_MicroType.IdMicro }).FirstOrDefault();
                if (unMicroType != null)
                {
                    La_Connexion.Query("UPDATE MICROTYPES SET nomMicro=@_nomMicro, descriptionMicro=@_descriptionMicro, dispoMicro=@_dispoMicro, prix=@_prix where IdMicro=@_ID",
                        new { _nomMicro = P_MicroType.nomMicro, _descriptionMicro = P_MicroType.descriptionMicro, _dispoMicro = P_MicroType.dispoMicro, _prix = P_MicroType.prix, _ID = P_MicroType.IdMicro });
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------------------------------------

    public void Delete_MicroType(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM MICROTYPES where IdMicro=@_ID", new { _ID = P_Id });
            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
}