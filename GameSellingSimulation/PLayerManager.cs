using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingSimulation
{
    class PLayerManager : IPlayer
    {
        public void AddPLayer(Player player)
        {
            Console.WriteLine("New user is successfully added! Welcome {0}",player.UserName);
        }

        public void DeletePlayer(Player player)
        {
            Console.WriteLine("{0} is successfully deleted!",player.UserName);
        }

        public void UpdatePlayer(Player player)
        {
            Console.WriteLine("{0} is successfully updated!",player.UserName);
        }
    }
}
