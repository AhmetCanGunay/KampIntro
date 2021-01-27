using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    class CampaignManager : ICampaign
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("{0} is deleted from the system.",campaign.CampaignName);
        }

        public void ListCampaign(List<Campaign> campaigns)
        {
            foreach (var item in campaigns)
            {
                Console.WriteLine("Name of Campaign:{0}\nAmount:{1}\nDuration:{2}",item.CampaignName,item.DiscountAmount,item.CampaignDuration);
            }
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("{0} is added as a new campaign.",campaign.CampaignName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("{0} is updated.",campaign.CampaignName);
        }
    }
}
