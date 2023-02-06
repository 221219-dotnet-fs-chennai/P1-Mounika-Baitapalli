﻿using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class TrainersController:ControllerBase
    {
        ITrainersLogic _logic;
        IMemoryCache _cache;
        public TrainersController(ITrainersLogic logic, IMemoryCache cache)
        {
            _logic = logic;
            _cache = cache;
        }

        [HttpPost("Add")]
        public ActionResult Add([FromBody]Trainer_Detail td)

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
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
                

            



        }
    }
}
