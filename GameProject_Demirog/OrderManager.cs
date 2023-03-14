using GameProject_Demirog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{
    class OrderManager : IOrderService
    {
        public bool OrderValidate(Campaign campaigns, Gamer gamers)
        {
            if (campaigns.CampaignName=="Teacher Campaign" && campaigns.CampaignRate == 30 && campaigns.GamePrice == 500 && gamers.Id == 1 && gamers.FirstName == "Murat"
                && gamers.LastName == "OZ" && gamers.IdentityNumber == 123456 && gamers.BirthYear == 1995)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
