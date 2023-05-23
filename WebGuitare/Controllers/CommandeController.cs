    using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {
        C_BASE Ma_base;

        public CommandeController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }
        [HttpGet("GetGenerateNumero", Name = "GetGenerateNumero")]
        public ActionResult<string> Get_Generate_Numero()
        {
            var Numero = Ma_base.GenerateNumero();
            return Ok(Numero);
        }
        [HttpGet("GetAllCommandes", Name = "GetAllCommandes")]
        public ActionResult<List<C_COMMANDE>> Get_All_Commandes()
        {
            var listeCommandes = Ma_base.Get_All_Commandes();
            return Ok(listeCommandes);
        }
        [HttpGet("GetCommandesByIdClient", Name = "GetCommandesByIdClient")]
        public ActionResult<List<C_COMMANDE>> Get_Commandes_By_IdClient(int P_Id)
        {
            var listeCommandes = Ma_base.Get_Commandes_By_IdClient(P_Id);
            return Ok(listeCommandes);
        }
        [HttpGet("GetCommandeById", Name = "GetCommandeById")]
        public ActionResult<C_COMMANDE> Get_Commande_By_Id(int P_Id)
        {
            var uneCommande = Ma_base.Get_Commande_By_Id(P_Id);
            if (uneCommande != null) return Ok(uneCommande);
            else return NotFound(uneCommande);
        }
        [HttpGet("GetCommandeByNom", Name = "GetCommandeByNom")]
        public ActionResult<C_COMMANDE> Get_Commande_By_Nom(string P_Nom)
        {
            var uneCommande = Ma_base.Get_Commande_By_Nom(P_Nom);
            if (uneCommande != null) return Ok(uneCommande);
            else return NotFound(uneCommande);
        }
        [HttpPost("AddCommande", Name = "AddCommande")]
        public ActionResult<int> Add_Commande([FromBody] C_COMMANDE P_Commande)
        {
            int Id = Ma_base.Add_Commande(P_Commande);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
    }
}
