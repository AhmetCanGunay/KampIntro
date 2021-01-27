using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    interface IGameSellingSystem
    {
        void AddtoBasket(Player player);
        void BuyGame(Player player);
        void BuywithDiscount(Player player, Campaign campaign);
    }
}
