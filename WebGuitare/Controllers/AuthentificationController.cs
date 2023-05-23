using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        C_BASE Ma_base;

        public AuthentificationController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }

        [HttpGet("GetAuthentificationByEmail", Name = "GetAuthentificationByEmail")]
        public ActionResult<C_AUTHENTIFICATION> Get_Authentification_By_Email(string P_Email)
        {
            var unAuth = Ma_base.Get_Authentification_By_Email(P_Email);
            if (unAuth != null) return Ok(unAuth);
            else return NotFound(unAuth);
        }
        [HttpGet("GetAllAuthentifications", Name = "GetAllAuthentifications")]
        public ActionResult<List<C_AUTHENTIFICATION>> Get_All_Authentifications()
        {
            var Liste_Auth = Ma_base.Get_All_Authentifications();
            return Ok(Liste_Auth);
        }
        [HttpGet("GetAuthentificationById", Name = "GetAuthentificationById")]
        public ActionResult<C_AUTHENTIFICATION> Get_Authentification_By_Id(int P_Id)
        {
            var unAuth = Ma_base.Get_Authentification_By_Id(P_Id);
            if (unAuth != null) return Ok(unAuth);
            else return NotFound(unAuth);
        }
        [HttpPost("AddAuthentification", Name = "AddAuthentification")]
        public ActionResult<int> Add_Authentification([FromBody] C_AUTHENTIFICATION P_Auth)
        {
            int Id = Ma_base.Add_Authentification(P_Auth);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
        //-----------------------------------------------

        [HttpPost("VerifAuthentification", Name = "VerifAuthentification")]
        public ActionResult<int> Verif_Authentification([FromBody] C_AUTHENTIFICATION P_Auth)
        {
            int Id = Ma_base.Verif_Authentification(P_Auth);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }

        [HttpPost("HashPassword", Name = "HashPassword")]
        public ActionResult<C_HASHMDP> HashPassword([FromBody] string HashPassword)
        {
            var hachage = Ma_base.HashPassword(HashPassword);
            return Ok(hachage);
        }

        //--------------------------------------

        [HttpPut("UpdateAuthentification", Name = "UpdateAuthentification")]
        public ActionResult Update_Authentification(C_AUTHENTIFICATION P_Auth)
        {
            Ma_base.Update_Authentification(P_Auth);
            return NoContent();
        }

        //-----------------------------------------

        [HttpDelete("DeleteAuthentification", Name = "DeleteAuthentification")]
        public ActionResult Delete_Authentification(int P_Id)
        {
            Ma_base.Delete_Authentification(P_Id);
            return NoContent();
        }
    }
}
