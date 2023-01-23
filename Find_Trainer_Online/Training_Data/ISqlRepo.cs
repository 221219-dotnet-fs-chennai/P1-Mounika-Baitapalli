using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer_Data
{
    public interface ISqlRepo
    {
        Details Add(Details details);
        //Details GetAllTrainer(string EmailId);
        bool Tlogin(string EmailId);

    }
}
