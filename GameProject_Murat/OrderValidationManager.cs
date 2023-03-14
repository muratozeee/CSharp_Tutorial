using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
    class OrderValidationManager : IOrderValidation
    {
        public bool OrderValidate(Gamer gamer,Campaigns campaigns)
        {
            if (gamer.Id == 1 && gamer.FirtsName == "Murat" && gamer.LastName == "OZ" && gamer.TcId == 123456789 
                && gamer.DateOfYear == 1995&& campaigns.CampaignName == "Teacher Discount" && campaigns.GamePrice == 500 && campaigns.CampaignRate == 30)
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
