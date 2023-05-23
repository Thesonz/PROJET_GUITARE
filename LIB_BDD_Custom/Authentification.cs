using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Dapper;

namespace LIB_BDD_Custom;

public class C_AUTHENTIFICATION
{
    public int IdAuth { get; set; }
    public string adresseMailAuth { get; set; }
    public string passwordAuth { get; set; }
}

public class C_HASHMDP
{
    public int Id { get; set; }
    public string hachage { get; set; }
}
public partial class C_BASE
{
    /*  Fonction Add
        Fonction Update
        Fonction Delete
    */

    public List<C_AUTHENTIFICATION> Get_All_Authentifications()
    {
        List<C_AUTHENTIFICATION> Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_AUTHENTIFICATION>("select * from AUTHENTIFICATIONS").ToList(); ;


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
    //----------------------------

    public C_AUTHENTIFICATION Get_Authentification_By_Email(string P_Email)
    {
        C_AUTHENTIFICATION Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_AUTHENTIFICATION>("select * from AUTHENTIFICATIONS where adresseMailAuth=@_adresseMailAuth", new { _adresseMailAuth = P_Email }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //---------------------------

    public C_AUTHENTIFICATION Get_Authentification_By_Id(int P_Id)
    {
        C_AUTHENTIFICATION Resultat = null;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.Query<C_AUTHENTIFICATION>("select * from AUTHENTIFICATIONS where IdAuth=@_ID", new { _ID = P_Id }).FirstOrDefault();


            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public int Add_Authentification(C_AUTHENTIFICATION P_Auth)
    {
        int Resultat;
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("insert into AUTHENTIFICATIONS(adresseMailAuth,passwordAuth) OUTPUT INSERTED.IdAuth values (@_adresseMailAuth,@_passwordAuth) ", new { _adresseMailAuth = P_Auth.adresseMailAuth, _passwordAuth = P_Auth.passwordAuth});


            }
            return Resultat;

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    //------------------------------------------------------

    public void Update_Authentification(C_AUTHENTIFICATION P_Auth)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                C_AUTHENTIFICATION uneAuth = La_Connexion.Query<C_AUTHENTIFICATION>("Select * from AUTHENTIFICATIONS where IdAuth=@_ID", new { _ID = P_Auth.IdAuth }).FirstOrDefault();
                if (uneAuth != null)
                {
                    La_Connexion.Query("UPDATE AUTHENTIFICATIONS SET adresseMailAuth=@_adresseMailAuth, passwordAuth=@_passwordAuth where IdAuth=@_ID",
                        new { _adresseMailAuth = P_Auth.adresseMailAuth, _passwordAuth = P_Auth.passwordAuth, _ID = P_Auth.IdAuth});
                }
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }
    public void Delete_Authentification(int P_Id)
    {
        try
        {
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                La_Connexion.Query("DELETE FROM AUTHENTIFICATIONS where IdAuth=@_ID", new { _ID = P_Id });
            }

        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public int Verif_Authentification(C_AUTHENTIFICATION P_Auth)
    {
        try
        {
            int Resultat;
            using (SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion))
            {
                La_Connexion.Open();
                Resultat = La_Connexion.QuerySingle<int>("SELECT COUNT(*) FROM AUTHENTIFICATIONS where adresseMailAuth=@_adresseMailAuth and passwordAuth=@_passwordAuth", new { _adresseMailAuth = P_Auth.adresseMailAuth , _passwordAuth = P_Auth.passwordAuth});
            }
            return Resultat;
        }
        catch (Exception P_Erreur)
        {
            throw new Exception(P_Erreur.Message);
        }
    }

    public C_HASHMDP HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            
            // Convertir le mot de passe en tableau de bytes
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convertir le tableau de bytes en une chaîne hexadécimale
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            C_HASHMDP c_HASHMDP = new C_HASHMDP() { hachage = builder.ToString(), Id=1 };
            return c_HASHMDP;
        }
    }

}