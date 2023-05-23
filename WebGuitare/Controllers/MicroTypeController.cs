using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MicroTypeController : ControllerBase
    {
        C_BASE Ma_base;

        public MicroTypeController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }


        [HttpGet("GetAllMicroTypes", Name = "GetAllMicroTypes")]
        public ActionResult<List<C_MICROTYPES>> Get_All_MicroTypes()
        {
            var listeMicroType = Ma_base.Get_All_MicroTypes();
            return Ok(listeMicroType);
        }
        [HttpGet("GetMicroTypeById", Name = "GetMicroTypeById")]
        public ActionResult<C_MICROTYPES> Get_MicroType_By_Id(int P_Id)
        {
            var unMicroType = Ma_base.Get_MicroType_By_Id(P_Id);
            if (unMicroType != null) return Ok(unMicroType);
            else return NotFound(unMicroType);
        }
        [HttpGet("GetMicroTypeByNom", Name = "GetMicroTypeByNom")]
        public ActionResult<C_MICROTYPES> Get_MicroType_By_Nom(string P_Nom)
        {
            var unMicroType = Ma_base.Get_MicroType_By_Nom(P_Nom);
            if (unMicroType != null) return Ok(unMicroType);
            else return NotFound(unMicroType);
        }
        [HttpPost("AddMicroType", Name = "AddMicroType")]
        public ActionResult<int> Add_MicroType([FromBody] C_MICROTYPES P_MicroType)
        {
            int Id = Ma_base.Add_MicroType(P_MicroType);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
        [HttpPut("UpdateMicroType", Name = "UpdateMicroType")]
        public ActionResult Update_MicroType(C_MICROTYPES P_MicroType)
        {
            Ma_base.Update_MicroType(P_MicroType);
            return NoContent();
        }
        [HttpDelete("DeleteMicroType", Name = "DeleteMicroType")]
        public ActionResult Delete_MicroType(int P_Id)
        {
            Ma_base.Delete_MicroType(P_Id);
            return NoContent();
        }
    }
}
