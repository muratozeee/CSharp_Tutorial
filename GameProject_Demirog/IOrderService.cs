using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{
     interface IOrderService
    {
        bool OrderValidate(Campaign campaigns, Gamer gamers);
    }
}
