using Dapper;
using System.Data.SqlClient;
using static LIB_BDD_Custom.C_BASE;

namespace LIB_BDD_Custom;

public partial class C_BASE
{
    const string Chaine_Connexion = @"Server=tcp:srvtsguitare.database.windows.net,1433;Initial Catalog=BDD_GUITARE;Persist Security Info=False;User ID=thesonz;Password=Reglisse30;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public C_BASE()
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Close();

            }
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }


    

}