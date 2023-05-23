using Dapper;
using System.Data.SqlClient;

namespace LIB_BDD_Custom;

public class C_GUITARE
{
    public int IdGuitare { get; set; }
    public int mancheBoisId { get; set; }
    public int toucheBoisId { get; set; }
    public int corpBoisId { get; set; }
    public int neckMicroId { get; set; }
    public int centralMicroId { get; set; }
    public int bridgeMicroId { get; set; }
    public int vibratoId { get; set; }

}

public partial class C_BASE
{
    public  List<C_GUITARE> Get_All_Guitares()
    {
        List<C_GUITARE> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_GUITARE>("select * from GUITARES").ToList();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public C_GUITARE Get_Guitare_By_Id(int P_ID)
    {
        C_GUITARE Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_GUITARE>("select * from GUITARES where IdGuitare=@_ID", new {_ID = P_ID}).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public int Add_Guitare(C_GUITARE P_Guitare)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into GUITARES(mancheBoisId,toucheBoisId,corpBoisId,neckMicroId,centralMicroId,bridgeMicroId,vibratoId) OUTPUT INSERTED.IdGuitare values (@_mancheBoisId,@_toucheBoisId,@_corpBoisId,@_neckMicroId,@_centralMicroId,@_bridgeMicroId,@_vibratoId) "
                    ,new { _mancheBoisId = P_Guitare.mancheBoisId, _toucheBoisId = P_Guitare.toucheBoisId, _corpBoisId = P_Guitare.corpBoisId, _neckMicroId = P_Guitare.neckMicroId, _centralMicroId  = P_Guitare.centralMicroId, _bridgeMicroId = P_Guitare.bridgeMicroId, _vibratoId = P_Guitare.vibratoId});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
}