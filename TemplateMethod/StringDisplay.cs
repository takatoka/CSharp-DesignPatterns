using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 具体的な内容を記述するクラス
    /// 処理の順番は意識しない
    /// </summary>
    public class StringDisplay : AbstractDisplay
    {
        private string _str;
        private int _width;

        public StringDisplay(string str)
        {
            _str = str;
            _width = _str.Length;
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
                Console.Write("-");
            Console.WriteLine("+");
        }
    }
}
