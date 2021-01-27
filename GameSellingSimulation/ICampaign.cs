using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    interface ICampaign
    {
        void NewCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void ListCampaign(List<Campaign> campaigns);
    }
}
