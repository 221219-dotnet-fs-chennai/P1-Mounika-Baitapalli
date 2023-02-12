using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        ITrainersLogic _logic;
        public CompanyController(ITrainersLogic logic)
        {
            _logic = logic;
        }
        [HttpGet("All")]
        public ActionResult Get()
        {
            try
            {
                var get = _logic.GetCompany_Details();
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
        public ActionResult AddCompanyDetails([FromBody] Company_Detail cd)
        {
            try
            {
                var add = _logic.AddCompanyDetail(cd);
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

        [HttpPut("Modify/{User_Id}")]
        public ActionResult Update([FromRoute]int User_Id,[FromBody] Company_Detail cd)
        {

            try
            {
                


                if (User_Id !=null)
                {
                    var M=_logic.UpdateCompanyDetail(User_Id, cd);
                    return Ok(M);
                }

                else
                    return BadRequest($"something wrong with {cd.User_Id} input,please try again");
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
        /*[HttpDelete("Delete/{UserId}")]
        public ActionResult Delete(int User_Id)
        {
            try
            {
                if (int.Equals(User_Id, 0))
                {
                    var del = _logic.DeleteCompanyDetail(User_Id, 0);
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
