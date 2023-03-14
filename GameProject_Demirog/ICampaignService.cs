using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{
     interface ICampaignService
    {

        void CampaignAdd(Campaign campaign, Gamer gamer);
        void CampaignDelete(Campaign campaign, Gamer gamer);
        void CampaignUpdate(Campaign campaign, Gamer gamer);
    }
}
