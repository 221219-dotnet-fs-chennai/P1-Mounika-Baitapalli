/*using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteAllController : ControllerBase
    {
        ITrainersLogic _logic;
        public DeleteAllController(ITrainersLogic logic)
        {
            _logic = logic;
        }
        [HttpDelete("Delete/UserId")]

    public ActionResult Delete(int User_Id)
    {
        try
        {
            if (User_Id != null)
            {
                var del = _logic.DeleteAllDetails(User_Id);
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
}
}

*/