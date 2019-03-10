using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    abstract class GamePlayerFactory
    {
        public GamePlayer Create(string[] titles)
        {
            return CreatePlayer(titles);
        }

        protected abstract GamePlayer CreatePlayer(string[] titles);
    }
}
