using System;
using System.Collections.Generic;

namespace GameSellingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player Adding
            Player player1 = new Player(){Id=1,FirstName="Ahmet",LastName="Günay",UserName="Ahmet1338",BirthDate=2000,Password=123};
            
            //Player Managing
            IPlayer pLayerManager = new PLayerManager();
            pLayerManager.AddPLayer(player1);
            pLayerManager.DeletePlayer(player1);
            pLayerManager.UpdatePlayer(player1);

            //E Devlet Verification
            EDevletUserData eDevletUserData = new EDevletUserData() {Id=11,FirstName="Osman",LastName="Çığır",TcNo="1111",BirthDate=2005 };
            IEdevletVerification eDevletVerification = new VerificationManager();
            eDevletVerification.EDevletVerification(eDevletUserData);

            //Campaign Managing
            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "Christmas Campaign", CampaignDuration = "2 Days", DiscountAmount = 10 };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "Summer Campaign", CampaignDuration = "5 Days", DiscountAmount = 20 };

            ICampaign campaignManager = new CampaignManager();
            campaignManager.NewCampaign(campaign1);
            campaignManager.DeleteCampaign(campaign1);
            campaignManager.UpdateCampaign(campaign1);
            List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2 };
            campaignManager.ListCampaign(campaigns);
            

        }
    }
}
