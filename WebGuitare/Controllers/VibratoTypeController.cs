using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VibratoTypeController : ControllerBase
    {
        C_BASE Ma_base;

        public VibratoTypeController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }

        [HttpGet("GetAllVibratoTypes", Name = "GetAllVibratoTypes")]
        public ActionResult<List<C_VIBRATOTYPES>> Get_All_VibratoTypes()
        {
            var listeVibratoType = Ma_base.Get_All_VibratoTypes();
            return Ok(listeVibratoType);
        }
        [HttpGet("GetVibratoTypeById", Name = "GetVibratoTypeById")]
        public ActionResult<C_VIBRATOTYPES> Get_VibratoType_By_Id(int P_Id)
        {
            var unVibratoType = Ma_base.Get_VibratoType_By_Id(P_Id);
            if (unVibratoType != null) return Ok(unVibratoType);
            else return NotFound(unVibratoType);
        }
        [HttpGet("GetVibratoTypeByNom", Name = "GetVibratoTypeByNom")]
        public ActionResult<C_VIBRATOTYPES> Get_VibratoType_By_Nom(string P_Nom)
        {
            var unVibratoType = Ma_base.Get_VibratoType_By_Nom(P_Nom);
            if (unVibratoType != null) return Ok(unVibratoType);
            else return NotFound(unVibratoType);
        }
        [HttpPost("AddVibratoType", Name = "AddVibratoType")]
        public ActionResult<int> Add_VibratoType([FromBody] C_VIBRATOTYPES P_VibratoType)
        {
            int Id = Ma_base.Add_VibratoType(P_VibratoType);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
        [HttpPut("UpdateVibratoType", Name = "UpdateVibratoType")]
        public ActionResult Update_VibratoType(C_VIBRATOTYPES P_VibratoType)
        {
            Ma_base.Update_VibratoType(P_VibratoType);
            return NoContent();
        }
        [HttpDelete("DeleteVibratoType", Name = "DeleteVibratoType")]
        public ActionResult Delete_VibratoType(int P_Id)
        {
            Ma_base.Delete_VibratoType(P_Id);
            return NoContent();
        }
    }
}
