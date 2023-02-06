using DataFluentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLogic
{
    public interface ITrainersLogic
    {
        Trainer_Detail AddTrainerDetail(Trainer_Detail td);

    }
}
