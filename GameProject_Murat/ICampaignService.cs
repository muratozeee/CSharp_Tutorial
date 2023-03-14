using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
     interface ICampaignService
    {
        void CampaignAdd(Campaigns campaigns, Gamer gamer);
        void CampaignDeleted(Campaigns campaigns, Gamer gamer);
        void CampaignUpdate(Campaigns campaigns, Gamer gamer);

        void CampaignCalculate(Campaigns campaigns, Gamer gamer);

    }
}
