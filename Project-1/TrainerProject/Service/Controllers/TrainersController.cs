using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.Data.SqlClient;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TrainerController : ControllerBase
    {
        ITrainersLogic _logic;
        // IMemoryCache _cache;
        public TrainerController(ITrainersLogic logic)
        {
            _logic = logic;
            // _cache = cache;
        }


        [HttpPost("Add")]
        public ActionResult AddTrainer([FromBody] Trainer_Detail ttd)
        {
            try
            {
                var a = _logic.AddTrainerDetail(ttd);
                return Created("Add", a);
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
        [HttpGet("all")]
        public ActionResult Get()
        {
            try
            {
                
                var get=_logic.GetAllTrainers().ToList();
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

        [HttpDelete("Delete/{Name}")]
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
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut("modify/{Name}")]
        public ActionResult Update([FromRoute] string Name, [FromBody] Trainer_Detail model)
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




        
    

