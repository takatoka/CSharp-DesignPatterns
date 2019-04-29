using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("Taro Tanaka");
            Product card2 = factory.Create("Hanako Yamada");
            Product card3 = factory.Create("Kenji Sato");
            card1.Use();
            card2.Use();
            card3.Use();

            Console.ReadLine();
        }
    }
}
