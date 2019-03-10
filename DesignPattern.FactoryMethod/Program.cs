using System;

namespace DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] swSofts = new[] { "Mario", "Zelda", "Pokemon", "Smash Bros." };

            GamePlayerFactory swFactory = new SwitchPlayerFactory();
            swFactory.Create(swSofts);

            Console.ReadLine();
        }
    }
}
