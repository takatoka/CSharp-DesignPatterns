using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    abstract class GamePlayer
    {
        public List<string> GameSofts { get; private set; } = new List<string>();
        public List<string> Accessories { get; private set; } = new List<string>();

        public abstract void BuyMachine();
        public abstract void BuyGameSoft(string title);
        public abstract void BuyAccessory(string name);
    }
}
