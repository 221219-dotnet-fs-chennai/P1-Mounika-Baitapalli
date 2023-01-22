using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer_Data
{
    internal interface ISqlRepo
    {
        Details Add(Details details);
    }
}
