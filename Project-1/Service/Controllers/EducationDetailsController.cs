/*using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Models;
using Microsoft.Data.SqlClient;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationDetailsController : ControllerBase
    {
        ITrainersLogic _logic;
        IMemoryCache _cache;
        public EducationDetailsController(ITrainersLogic logic, IMemoryCache cache)
        {
            _logic = logic;
            _cache = cache;
        }
        [HttpPost("Add")]
        public ActionResult Add([FromBody] Education_Detail ed)
        {
            try
            {
                var education = _logic.AddEducationDetail(ed);
                return CreatedAtAction("Add", education);
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
                var get = new List<Education_Detail>();
                if (!_cache.TryGetValue("rest", out get))
                {
                    get = _logic.GetEducation_Details().ToList();
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

        [HttpPut("Modify/{UserId}")]
        public ActionResult Update([FromRoute]int UserId,[FromBody] Education_Detail education)
        {
            try
            {
                if (int.Equals(UserId, 0))
                {
                    _logic.UpdateEducationDetailByUserId(education);
                    return Ok(education);

                }
                else
                     return BadRequest($"something wrong with {education.User_Id}input,please try again!");

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
                    var rest = _logic.RemoveEducationDetailByUserId(UserId);
                    if (rest != null)
                        return Ok(rest);
                    else
                        return NotFound();
                }
                else
                    return BadRequest("please add a valid trainer UserId to be deleted");

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