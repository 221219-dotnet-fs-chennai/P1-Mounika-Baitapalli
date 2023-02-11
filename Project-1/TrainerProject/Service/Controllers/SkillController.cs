using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        ITrainersLogic _logic;
        public SkillController(ITrainersLogic logic)
        {
            _logic = logic;
        }

        [HttpGet("All")]
        public ActionResult Get()
        {
            try
            {
                var get = _logic.GetSkill_Sets().ToList();
                return Ok(get);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
