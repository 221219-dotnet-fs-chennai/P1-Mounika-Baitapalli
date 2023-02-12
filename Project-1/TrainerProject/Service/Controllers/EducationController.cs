using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        ITrainersLogic _logic;
        public EducationController(ITrainersLogic logic)
        {
            _logic = logic;
        }
        [HttpGet("All")]
        public ActionResult Get()
        {
            try
            {
                var get = _logic.GetEducation_Details().ToList();
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
        public ActionResult AddEducationDetails([FromBody]Education_Detail ed)
        {
            try
            {
                var add=_logic.AddEducationDetail(ed);
                return Ok(add);
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

        [HttpPut("modify/{User_Id}")]
        public ActionResult Update([FromRoute]int User_Id, [FromBody]Education_Detail ed)
        {
            try
            {
                if (User_Id !=null)
                {
                    var edu = _logic.UpdateEducationDetail(User_Id, ed);
                    return Created("Updated", edu);
                }
                else
                    return BadRequest($"something wrong with {ed.User_Id}input,please try again!");
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /*[HttpDelete("Delete/{UserId}")]
        public ActionResult Delete(int User_Id)
        {
            try
            {
                if (int.Equals(User_Id, 0))
                {
                    var del = _logic.DeleteEducationDetail(User_Id, 0);
                    return Ok(del);
                }
                else
                    return BadRequest("Please Add a valid trainer userid to be deleted");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

    }
}
