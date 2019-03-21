using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// 具体的な内容を記述するクラス
    /// 処理の順番は意識しない
    /// </summary>
    public class CharDisplay : AbstractDisplay
    {
        private Char _chr;

        public CharDisplay(Char chr)
        {
            _chr = chr;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(_chr);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
