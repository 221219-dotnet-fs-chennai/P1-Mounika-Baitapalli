using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface ISqlRepo<Trainer>
    {
        Trainer Add(Trainer details);
        Trainer Get(string EmailId);
       /* bool Tlogin(string EmailId);
        void TUpdate(string tableName, string columnName, string newValue, int User_Id);

        //void DeleteTrainer(string col, string table, int User_Id);
        //void TDelete(string col, string table, int User_Id);

        void TDelete(string column, string table, int User_Id);*/
        List<Trainer> GetTrainersList();
    }
}
