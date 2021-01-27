using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    interface IPlayer
    {
        void AddPLayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(Player player);
    }
}
