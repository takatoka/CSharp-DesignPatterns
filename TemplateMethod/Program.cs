using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello");

            Console.WriteLine("CharDisplay");
            d1.Display();

            Console.WriteLine("StringDisplay");
            d2.Display();

            Console.ReadLine();
        }
    }
}
