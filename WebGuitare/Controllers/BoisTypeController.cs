using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoisTypeController : ControllerBase
    {
        C_BASE Ma_base;

        public BoisTypeController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }

        //TYPE BOIS

        [HttpGet("GetAllBoisTypes", Name = "GetAllBoisTypes")]
        public ActionResult<List<C_BOISTYPES>> Get_All_BoisTypes()
        {
            var listeBoisType = Ma_base.Get_All_BoisTypes();
            return Ok(listeBoisType);
        }
        [HttpGet("GetBoisTypeById", Name = "GetBoisTypeById")]
        public ActionResult<C_BOISTYPES> Get_BoisType_By_Id(int P_Id)
        {
            var unBoisType = Ma_base.Get_BoisType_By_Id(P_Id);
            if(unBoisType != null) return Ok(unBoisType);
            else return NotFound(unBoisType);
        }
        [HttpGet("GetBoisTypeByNom", Name = "GetBoisTypeByNom")]
        public ActionResult<C_BOISTYPES> Get_BoisType_By_Nom(string P_Nom)
        {
            var unBoisType = Ma_base.Get_BoisType_By_Nom(P_Nom);
            if (unBoisType != null) return Ok(unBoisType);
            else return NotFound(unBoisType);
        }
        [HttpPost("AddBoisType", Name = "AddBoisType")]
        public ActionResult<int> Add_BoisType([FromBody]C_BOISTYPES P_BoisType)
        {
            int Id = Ma_base.Add_BoisType(P_BoisType);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
        [HttpPut("UpdateBoisType", Name = "UpdateBoisType")]
        public ActionResult Update_BoisType(C_BOISTYPES P_BoisType)
        {
            Ma_base.Update_BoisType(P_BoisType);
            return NoContent();
        }
        [HttpDelete("DeleteBoisType", Name = "DeleteBoisType")]
        public ActionResult Delete_BoisType(int P_Id)
        {
            Ma_base.Delete_BoisType(P_Id);
            return NoContent();
        }


    }
}
