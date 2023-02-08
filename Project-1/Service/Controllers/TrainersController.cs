using BusinessLogic;
using DataFluentApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;
using Models;
using System.Linq.Expressions;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        ITrainersLogic _logic;
        IMemoryCache _cache;
        public TrainersController(ITrainersLogic logic, IMemoryCache cache)
        {
            _logic = logic;
            _cache = cache;
        }

        [HttpPost("Add")]
        public ActionResult Add([FromBody] Trainer_Detail td)

        {
            try
            {
                var addedTrainer_Detail = _logic.AddTrainerDetail(td);
                return CreatedAtAction("Add", addedTrainer_Detail);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("all")]
        public ActionResult Get()
        {
            try
            {
                var get=new List<Trainer_Detail>();
                if(!_cache.TryGetValue("rest",out get))
                {
                    get=_logic.GetTrainer_Details().ToList();
                    _cache.Set("rest", get, new TimeSpan(0, 0, 30));
                }
                return Ok(get);
                   
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

        [HttpDelete("Delete/{name}")]
        public ActionResult Delete(string Name)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    var rest = _logic.RemoveTrainerDetailByName(Name);
                    if (rest != null)
                        return Ok(rest);
                    else
                        return NotFound();
                }
                else
                    return BadRequest("Please Add a valid trainer name to be deleted");
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpPut("modify/{name}")]
        public ActionResult Update([FromRoute] string Name,[FromBody]Trainer_Detail model)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    _logic.UpdateTrainerDetail(Name, model);
                    return Ok(model);
                }
                else
                    return BadRequest($"something wrong with {model.Name}input,please try again!");
            }
            catch(SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex) { 
                return BadRequest(ex.Message);
            }
        }


       
    }


    
}


       
              






















































