using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    class GameSellingManager : IGameSellingSystem
    {
        public void AddtoBasket(Player player)
        {
            Console.WriteLine("Dear {0}, your game is added to basket successfully!", player.UserName);
        }

        public void BuyGame(Player player)
        {
            Console.WriteLine("Dear {0}, your game is bought  successfully! Thanks for shopping :)",player.UserName);
        }
        public void BuyGameCampaign(Player player)
        {
            Console.WriteLine("Dear {0}, your fees are listed with the campaign:",player.UserName);
        }

        public void BuywithDiscount(Player player, Campaign campaign)
        {
            Console.WriteLine("Dear {0}, you bought your game with {1}.Thanks for shopping:)",player.FirstName,campaign.CampaignName);
        }
    }
}
