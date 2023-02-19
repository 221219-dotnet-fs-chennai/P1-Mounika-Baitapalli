/*using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Skill_SetController : ControllerBase
    {
        ITrainersLogic _logic;
        IMemoryCache _cache;
        public Skill_SetController(ITrainersLogic logic, IMemoryCache cache)
        {
            _logic = logic;
            _cache = cache;
        }

        [HttpPost("Add")]
        public ActionResult Add([FromBody] Skill_Set ss)
        {
            try
            {
                var skill = _logic.AddSkillSet(ss);
                return CreatedAtAction("Add", skill);
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
        [HttpGet("All")]
        public ActionResult Get()
        {
            try
            {
                var get = new List<Skill_Set>();
                if (!_cache.TryGetValue("rest", out get))
                {
                    get = _logic.GetSkill_Set().ToList();
                    _cache.Set("rest", get, new TimeSpan(0, 0, 60));
                }
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
        [HttpDelete("Delete/{UserId}")]
        public ActionResult Delete(int UserId)
        {
            try
            {

                if (int.Equals(UserId, 0))
                {
                    var rest = _logic.RemoveSkillSetByUserId(UserId);
                    if (rest != null)
                    {
                        return Ok(rest);
                    }
                    else
                        return NotFound();
                }
                else
                    return BadRequest("Please Add a valid Trainer Userid to be deleted");
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
        [HttpPut("modify/{UserId}")]
        public ActionResult Update([FromRoute] int UserId, [FromBody] Skill_Set ss)
        {
            try
            {    if (int.Equals(UserId, 0))
                {
                    _logic.UpdateSkillSet(UserId, ss);
                    return Ok(ss);
                }
                else
                    return BadRequest($"something wrong with {ss.User_Id}input,please try again!"); 
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
        

        











*/