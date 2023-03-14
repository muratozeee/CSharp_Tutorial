using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Demirog
{
    class CampaignManager : ICampaignService
    {

        OrderManager _orderManager;

        public CampaignManager(OrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public void CampaignAdd(Campaign campaign, Gamer gamer)
        {
            if (_orderManager.OrderValidate(campaign,gamer)==true)
            {
                Console.WriteLine("Campaign Was Added..! Succesfully..!");
                Console.WriteLine($"Campaign Name={campaign.CampaignName}     --   Campaign Rate={campaign.CampaignRate} --  Game Price={campaign.GamePrice} --" +
                    $" After Discount={((1-(campaign.CampaignRate/100))*campaign.GamePrice)}");

            }
            else
            {
                Console.WriteLine("Campaign was not  Added..! UnSuccesfully..!");
            }

           
        }

        public void CampaignDelete(Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Campaign was Deleted...! Succesfully..!");     
        }

        public void CampaignUpdate(Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Campaign was Updated..! Succesfully..!");
        }
    }
}
