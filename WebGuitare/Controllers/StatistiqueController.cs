using LIB_BDD_Custom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGuitare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatistiqueController : ControllerBase
    {
        C_BASE Ma_base;

        public StatistiqueController(C_BASE P_Base)
        {
            Ma_base = P_Base;
        }
        [HttpGet("GetStatistique", Name = "GetStatistique")]
        public ActionResult<List<C_STATISTIQUE>> Get_Statistique()
        {
            var listeStat = Ma_base.Get_Statistique();
            return Ok(listeStat);
        }

        [HttpGet("GetStatistiqueByDateAnnee", Name = "GetStatistiqueByDateAnnee")]
        public ActionResult<C_STATISTIQUE> Get_Statistique_by_dateAnnee(int P_Date)
        {
            var listeStat = Ma_base.Get_Statistique_by_dateAnnee(P_Date);
            return Ok(listeStat);
        }

        [HttpPost("AddStatistique", Name = "AddStatistique")]
        public ActionResult<int> Add_Statistique([FromBody] C_STATISTIQUE P_STAT)
        {
            int Id = Ma_base.Add_Statistique(P_STAT);
            if (Id > 0) return Ok(Id);
            else return NotFound(Id);
        }

        //--------------------------------------

        [HttpPut("UpdateStatistique", Name = "UpdateStatistique")]
        public ActionResult Update_Statistique(C_STATISTIQUE P_Stat)
        {
            Ma_base.Update_Statistique(P_Stat);
            return NoContent();
        }

        [HttpDelete("DeleteStatistique", Name = "DeleteStatistique")]
        public ActionResult Delete_Statistique(int P_Id)
        {
            Ma_base.Delete_Statistique(P_Id);
            return NoContent();
        }
    }
}
