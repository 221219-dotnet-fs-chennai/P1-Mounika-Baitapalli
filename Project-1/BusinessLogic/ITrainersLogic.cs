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
       // Trainer_Detail GetTrainerDetailsByUser_Id(int id);

        IEnumerable<Trainer_Detail> GetTrainer_Details();

        Trainer_Detail RemoveTrainerDetailByName(string td);

        Trainer_Detail UpdateTrainerDetail(string Name,Trainer_Detail td);
        Trainer_Detail GetTrainerDetailsByUser_Id(int id);

    }
}
