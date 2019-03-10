using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    class SwitchPlayerFactory : GamePlayerFactory
    {
        protected override GamePlayer CreatePlayer(string[] titles)
        {
            var player = new SwitchPlayer();
            player.BuyMachine();
            foreach (var title in titles)
                player.BuyGameSoft(title);
            player.BuyAccessory("JoyCon-Right Blue");
            player.BuyAccessory("JoyCon-Left Blue");
            player.BuyAccessory("HDMI Cable");
            player.BuyAccessory("Friends");
            return player;
        }
    }
}
