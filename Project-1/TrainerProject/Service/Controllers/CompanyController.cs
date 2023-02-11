using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

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

    }
}
