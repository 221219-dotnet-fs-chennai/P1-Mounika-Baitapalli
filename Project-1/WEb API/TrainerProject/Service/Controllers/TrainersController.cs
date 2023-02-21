using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using Serilog;
using Microsoft.IdentityModel.Tokens;

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
            Log.Logger.Information("...Adding Trainer's Personal Details......");
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

            Log.Logger.Information("...getting all Trainer's personal details.....");
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


    [HttpDelete("Delete/EmailId")]
    public ActionResult Delete(string EmailId)
    {

            Log.Logger.Information("...Deleting all  Trainer's  Details......");
            try
            {
                if (EmailId != null)
                {
                    if (!string.IsNullOrEmpty(EmailId))
                    {
                        var del = _logic.DeleteTrainerDetail(EmailId);
                        return Ok(del);
                    }
                    return BadRequest("Try again");

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
            Log.Logger.Information("...Modifying all Trainer's personal details......");
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
                Log.Logger.Information("...Sqlexception occurred......");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                Log.Logger.Information("...exception occurred......");
            }
        }

        [HttpGet("Login")]
        public ActionResult Login(string EmailId, string Password)
        {
            try
            {    if(EmailId !=null)
                {
                    if (!string.IsNullOrEmpty(EmailId))
                    {
                        var mm = _logic.Login(EmailId, Password);
                        return Ok(" Logged in Successfully");
                    }
                    else
                    {
                        return BadRequest("enter a valid emailid and password");
                    }
                }
                 else 
                 {
                    return BadRequest("Something wrong with input,try again");
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

        
    }
}




        
    

