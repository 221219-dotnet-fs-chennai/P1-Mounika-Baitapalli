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
    public class CompanyDetailsController : ControllerBase
    {
        ITrainersLogic _logic;
        IMemoryCache _cache;
        public CompanyDetailsController(ITrainersLogic logic, IMemoryCache cache)
        {
            _logic = logic;
            _cache = cache;
        }

        [HttpPost("Add")]
        public ActionResult Add([FromBody] Company_Detail cd)
        {
            try
            {
                var company = _logic.AddCompanyDetail(cd);
                return CreatedAtAction("Add",company);
            }
            catch (SqlException ex)
            {
                
            return BadRequest(ex.Message);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("All")]
        public ActionResult Get()
        {
            try
            {
                var get=new List<Company_Detail>();
                if(!_cache.TryGetValue("rest",out get))
                {
                    get=_logic.GetCompany_Details().ToList();
                    _cache.Set("rest",get,new TimeSpan(0,0,60));
                }
                return Ok(get);
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
        [HttpDelete("Delete/{UserId}")]
        public ActionResult Delete(int UserId)
        {
            try
            {
                if(int.Equals(UserId, 0))
                {
                    var rest = _logic.RemoveCompanyDetailByUserId(UserId);
                    if (rest != null)
                    {
                        return Ok(rest);
                    }
                    else
                        return NotFound();

                }
                else
                    return BadRequest("please Add a valid  trainer UserId to be deleted ");
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
        [HttpPut("Modify/{UserId}")]
        public ActionResult Update([FromRoute]int UserId,[FromBody]Company_Detail model)
        {
            try
            {
                if (int.Equals(UserId, 0))
                {
                    _logic.UpdateCompanyDetail(UserId, model);
                    return Ok(model);
                }
                else 
                    return BadRequest($"something wrong with {model.User_Id}input,please try again!");
               
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
        
    }
}
*/