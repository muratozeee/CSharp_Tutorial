namespace GameProject_Demirog
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            GamerManager gamerManager=new GamerManager(new UserValidationManager()); //I used the NewEstateUSerValidation system then it is working property...!
                                                                                     //Why we are using this System?
                                                                                     //Service maybe will change then add something NewEstateValidationManager
                                                                                     //such as New e-Goverment systems
            Gamer gamer1 =new Gamer() { 
            
                Id= 1,
                FirstName="Murat",
                LastName="OZ",
                IdentityNumber=123456,
                BirthYear=1995
            };

            Campaign campaign1 = new Campaign() {
                CampaignName="Teacher Campaign",
                CampaignRate=30,
                GamePrice=500
            };

            CampaignManager campaignManager = new CampaignManager(new OrderManager());

            gamerManager.Add(gamer1);
            campaignManager.CampaignAdd(campaign1, gamer1);
           
        
        }
    }
}