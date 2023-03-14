namespace GameProject_Murat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirtsName = "Murat",
                LastName = "OZ",
                TcId = 123456789,
                DateOfYear = 1995
            };

            Campaigns campaign1 = new Campaigns()
            {
                CampaignName = "Teacher Discount",
                CampaignRate = 30,
                GamePrice = 500


            };
            GamerManager gamerManager = new GamerManager(new ValidationManager());

            gamerManager.Add(gamer1);
         

           CampaignManager campaignManager=new CampaignManager(new OrderValidationManager());

            campaignManager.CampaignAdd(campaign1,gamer1);




            campaignManager.CampaignCalculate(campaign1,gamer1);
           

            


          
        }
    }
}