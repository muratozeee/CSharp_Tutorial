using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
     interface IOrderValidation
    {
        bool OrderValidate(Gamer gamer,Campaigns campaigns);
    }
}
