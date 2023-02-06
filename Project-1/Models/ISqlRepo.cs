using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISqlRepo<TrainerDetail>
    {
        //IEnumerable<DataFluentApi.Entities.TrainerDetail> GetGetAllTrainerDetail();
        TrainerDetail AddTrainerDetail(TrainerDetail td);
       

        /* bool Tlogin(string EmailId);
         void TUpdate(string tableName, string columnName, string newValue, int User_Id);

         //void DeleteTrainer(string col, string table, int User_Id);
         //void TDelete(string col, string table, int User_Id);

         void TDelete(string column, string table, int User_Id);*/
        //st<Trainer> GetTrainersList();
    }
}
