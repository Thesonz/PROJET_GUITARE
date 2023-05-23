using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitareController : ControllerBase
    {
        C_BASE Ma_base;

        public GuitareController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }
        [HttpGet("GetAllGuitares", Name = "GetAllGuitares")]
        public ActionResult<List<C_GUITARE>> Get_All_Guitares()
        {
            var listeGuitares = Ma_base.Get_All_Guitares();
            return Ok(listeGuitares);
        }
        [HttpGet("GetGuitareById", Name = "GetGuitareById")]
        public ActionResult<C_GUITARE> Get_Guitare_By_Id(int P_Id)
        {
            var uneGuitare = Ma_base.Get_Guitare_By_Id(P_Id);
            if (uneGuitare != null) return Ok(uneGuitare);
            else return NotFound(uneGuitare);
        }
        [HttpPost("AddGuitare", Name = "AddGuitare")]
        public ActionResult<int> Add_Guitare([FromBody] C_GUITARE P_Guitare)
        {
            int Id = Ma_base.Add_Guitare(P_Guitare);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }
    }
}
