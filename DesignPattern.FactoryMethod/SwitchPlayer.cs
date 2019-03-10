using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    class SwitchPlayer : GamePlayer
    {
        public override void BuyAccessory(string name)
        {
            Console.WriteLine($"Bought {name} !!!!");
            Accessories.Add(name);
        }

        public override void BuyGameSoft(string title)
        {
            Console.WriteLine($"Bought {title} !!!!");
            GameSofts.Add(title);
        }

        public override void BuyMachine()
        {
            Console.WriteLine("Bought Nintendo Switch !!!!");
        }
    }
}
