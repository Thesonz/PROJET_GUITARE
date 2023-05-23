using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        C_BASE Ma_base;

        public ClientController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }

        [HttpGet("GetAllClients", Name = "GetAllClients")]
        public ActionResult<List<C_CLIENT>> Get_All_Clients()
        {
            var listeClients = Ma_base.Get_All_Clients();
            return Ok(listeClients);
        }

        //-------------------------------------

        [HttpGet("GetClientByNom", Name = "GetClientByNom")]
        public ActionResult<C_CLIENT> Get_Client_By_Nom(string P_Nom)
        {
            var unClient = Ma_base.Get_Client_By_Nom(P_Nom);
            if (unClient != null) return Ok(unClient);
            else return NotFound(unClient);
        }
        //---------------------------------------

        [HttpGet("GetClientById", Name = "GetClientById")]
        public ActionResult<C_CLIENT> Get_Client_By_Id(int P_Id)
        {
            var unClient = Ma_base.Get_Client_By_Id(P_Id);
            if (unClient != null) return Ok(unClient);
            else return NotFound(unClient);
        }

        //---------------------------------------

        [HttpGet("GetClientByAuthId", Name = "GetClientByAuthId")]
        public ActionResult<C_CLIENT> Get_Client_By_AuthId(int P_Id)
        {
            var unClient = Ma_base.Get_Client_By_AuthId(P_Id);
            if (unClient != null) return Ok(unClient);
            else return NotFound(unClient);
        }

        //--------------------------------------

        [HttpPost("AddClient", Name = "AddClient")]
        public ActionResult<int> Add_Client([FromBody] C_CLIENT P_Client)
        {
            int Id = Ma_base.Add_Client(P_Client);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }

        //-------------------------------------------

        [HttpPut("UpdateClient", Name = "UpdateClient")]
        public ActionResult Update_Client(C_CLIENT P_Client)
        {
            Ma_base.Update_Client(P_Client);
            return NoContent();
        }

        //------------------------------------------------

        [HttpDelete("DeleteClient", Name = "DeleteClient")]
        public ActionResult Delete_Client(int P_Id)
        {
            Ma_base.Delete_Client(P_Id);
            return NoContent();
        }
    }
}
