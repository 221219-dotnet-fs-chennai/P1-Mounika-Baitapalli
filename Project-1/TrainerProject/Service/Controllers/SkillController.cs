using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

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
        [HttpPost("Add")]
        public ActionResult AddSkills([FromBody]Skill_Set s){
            try
            {
                var add = _logic.AddSkillSet(s);
                return Created("added", s);
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex) { 
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("Modify/{User_Id}")]
        public ActionResult Update([FromRoute]int User_Id, [FromBody]Skill_Set s)
        {
            try
            {
                if(User_Id!=null)
                {
                    var ss = _logic.UpdateSkillSet(User_Id, s);
                    return Created("updated", ss);
                }
                else
                    return BadRequest($"something wrong with {s.User_Id}  input,please try again!");
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /*[HttpDelete("Delete")]
        public ActionResult Delete(int User_Id)
        {
            try
            {
                if (int.Equals(User_Id, 0))
                {
                    var del = _logic.DeleteSkillSet(User_Id, 0);
                    return Ok(del);
                }
                else
                    return BadRequest("Please Add a valid trainer userid to be deleted");

            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/
    }
}
