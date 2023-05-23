using System.Data.SqlClient;
using Dapper;

namespace LIB_BDD_Custom;

public class C_STATISTIQUE
{
    public int Id { get; set; }
    public int nombreVue { get; set; }
    public int revenueTotal { get; set; }
    public int revenueMoisJanv { get; set; }
    public int revenueMoisFevr { get; set; }
    public int revenueMoisMars { get; set; }
    public int revenueMoisAvri { get; set; }
    public int revenueMoisMai { get; set; }
    public int revenueMoisJuin { get; set; }
    public int revenueMoisJuil { get; set; }
    public int revenueMoisAout { get; set; }
    public int revenueMoisSept { get; set; }
    public int revenueMoisOcto { get; set; }
    public int revenueMoisNove { get; set; }
    public int revenueMoisDece { get; set; }
    public int revenueAnnee { get; set; }
    public int dateAnnee { get; set; }
}

public partial class C_BASE
{
    /*  Fonction Add
        Fonction Update
        Fonction Delete
    */

    public List<C_STATISTIQUE> Get_Statistique()
    {
        List<C_STATISTIQUE> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_STATISTIQUE>("select * from STATISTIQUES").ToList(); ;


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public C_STATISTIQUE Get_Statistique_by_dateAnnee(int P_Date)
    {
        C_STATISTIQUE Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_STATISTIQUE>("select * from STATISTIQUES where dateAnnee=@_dateAnnee", new { _dateAnnee = P_Date}).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
    //------------------------------------------------------

    public int Add_Statistique(C_STATISTIQUE P_Stat)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into STATISTIQUES(nombreVue,revenueTotal,revenueMoisJanv,revenueMoisFevr,revenueMoisMars,revenueMoisAvri,revenueMoisMai,revenueMoisJuin,revenueMoisJuil,revenueMoisAout,revenueMoisSept,revenueMoisOcto,revenueMoisNove,revenueMoisDece,revenueAnnee,dateAnnee) OUTPUT INSERTED.Id values (@_nombreVue,@_revenueTotal,@_revenueMoisJanv,@_revenueMoisFevr,@_revenueMoisMars,@_revenueMoisAvri,@_revenueMoisMai,@_revenueMoisJuin,@_revenueMoisJuil,@_revenueMoisAout,@_revenueMoisSept,@_revenueMoisOcto,@_revenueMoisNove,@_revenueMoisDece,@_revenueAnnee,@_dateAnnee) ",
                        new { _nombreVue = P_Stat.nombreVue, _revenueTotal = P_Stat.revenueTotal, _revenueMoisJanv = P_Stat.revenueMoisJanv, _revenueMoisFevr = P_Stat.revenueMoisFevr, _revenueMoisMars = P_Stat.revenueMoisMars, _revenueMoisAvri = P_Stat.revenueMoisAvri, _revenueMoisMai = P_Stat.revenueMoisMai, _revenueMoisJuin = P_Stat.revenueMoisJuin, _revenueMoisJuil = P_Stat.revenueMoisJuil, _revenueMoisAout = P_Stat.revenueMoisAout, _revenueMoisSept = P_Stat.revenueMoisSept, _revenueMoisOcto = P_Stat.revenueMoisOcto, _revenueMoisNove = P_Stat.revenueMoisNove, _revenueMoisDece = P_Stat.revenueMoisDece, _revenueAnnee = P_Stat.revenueAnnee, _dateAnnee= P_Stat.dateAnnee});

            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //------------------------------------------------------

    public void Update_Statistique(C_STATISTIQUE P_Stat)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_AUTHENTIFICATION uneAuth = La_Connexion.Query<C_AUTHENTIFICATION>("Select * from STATISTIQUES where Id=@_ID", new { _ID = P_Stat.Id }).FirstOrDefault();
                if (uneAuth != null)
                {
                    La_Connexion.Query("UPDATE STATISTIQUES SET nombreVue=@_nombreVue, revenueTotal=@_revenueTotal, revenueMoisJanv=@_revenueMoisJanv, revenueMoisFevr=@_revenueMoisFevr, revenueMoisMars=@_revenueMoisMars, revenueMoisAvri=@_revenueMoisAvri, revenueMoisMai=@_revenueMoisMai, revenueMoisJuin=@_revenueMoisJuin, revenueMoisJuil=@_revenueMoisJuil, revenueMoisAout=@_revenueMoisAout, revenueMoisSept=@_revenueMoisSept, revenueMoisOcto=@_revenueMoisOcto, revenueMoisNove=@_revenueMoisNove, revenueMoisDece=@_revenueMoisDece , revenueAnnee=@_revenueAnnee, dateAnnee=@_dateAnnee where Id=@_ID",
                        new { _nombreVue = P_Stat.nombreVue, _revenueTotal = P_Stat.revenueTotal, _revenueMoisJanv = P_Stat.revenueMoisJanv, _revenueMoisFevr = P_Stat.revenueMoisFevr, _revenueMoisMars = P_Stat.revenueMoisMars, _revenueMoisAvri = P_Stat.revenueMoisAvri, _revenueMoisMai = P_Stat.revenueMoisMai, _revenueMoisJuin = P_Stat.revenueMoisJuin, _revenueMoisJuil = P_Stat.revenueMoisJuil, _revenueMoisAout = P_Stat.revenueMoisAout, _revenueMoisSept = P_Stat.revenueMoisSept, _revenueMoisOcto = P_Stat.revenueMoisOcto, _revenueMoisNove = P_Stat.revenueMoisNove, _revenueMoisDece = P_Stat.revenueMoisDece, _revenueAnnee = P_Stat.revenueAnnee, _dateAnnee = P_Stat.dateAnnee, _ID = P_Stat.Id });
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //----------------------------------------------------

    public void Delete_Statistique(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM STATISTIQUES where Id=@_ID", new { _ID = P_Id });
            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }




}