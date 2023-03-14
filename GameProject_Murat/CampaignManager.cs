using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_Murat
{
    class CampaignManager : ICampaignService

    {
        OrderValidationManager _orderValidationManager;

        public CampaignManager(OrderValidationManager orderValidationManager)
        {
            _orderValidationManager = orderValidationManager;
        }

        public void CampaignAdd(Campaigns campaigns,Gamer gamer)
        {

            if (_orderValidationManager.OrderValidate(gamer,campaigns)==true)
            {

                Console.WriteLine("Campaign was Added..!Successfully..!");

                Console.WriteLine($"Campaign Name={campaigns.CampaignName} And Campaign Rate=%{campaigns.CampaignRate}");
            }
            else
            {
                Console.WriteLine("Campaign Unsuccesfully...! Define Campaign again..! ");

            }


                
          
            
               
            
            
        }


        public void CampaignDeleted(Campaigns campaigns, Gamer gamer)
        {
            Console.WriteLine("Campaign was Updated...Succesfully");
        }

        public void CampaignUpdate(Campaigns campaigns, Gamer gamer)
        {
            Console.WriteLine("Campaign was Deleted..! Succesfully");    
        }
        public void CampaignCalculate(Campaigns campaigns, Gamer gamer)
        {

            if (_orderValidationManager.OrderValidate(gamer, campaigns) == true)
            {
                double discount;
                discount = (1 - (campaigns.CampaignRate / 100)) * campaigns.GamePrice;
                Console.WriteLine($"Campaign Rate %{campaigns.CampaignRate} Game Price Before Discount={campaigns.GamePrice}");

                Console.WriteLine("After Discount= " + discount);

            }
            else
            {
                Console.WriteLine("Wrong Campaign..!");

            }
           
        }

    


    }
}
