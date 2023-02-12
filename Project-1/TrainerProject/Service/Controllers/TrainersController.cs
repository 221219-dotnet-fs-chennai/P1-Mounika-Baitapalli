using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

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
        /*[HttpGet("Retreive/{UserId}")]
        public ActionResult GetAll(int User_Id)
        {
            try
            {
                var get = _logic.GetAllDetails().ToList();
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
        }*/


    [HttpDelete("Delete/UserId")]
    public ActionResult Delete(int User_Id)
    {
        try
        {
            if (User_Id != null)
            {
                var del = _logic.DeleteTrainerDetail(User_Id);
                return Ok(del);
            }
            else
            {
                return BadRequest($"Please enter a valid trainer Userid to be deleted");
            }
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

        [HttpPut("Modify/{User_Id}")]
        public ActionResult Update([FromRoute] int User_Id, [FromBody] Trainer_Detail model)
        {
            try
            {
                if (User_Id !=null)
                {
                    _logic.UpdateTrainerDetail(User_Id, model);
                    return Ok(model);
                }
                else
                    return BadRequest($"something wrong with {model.User_Id} input,please try again!");
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




        
    

