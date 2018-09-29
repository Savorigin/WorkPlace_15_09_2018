using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AbstractFigure
    {
        private static int count;
        public static int Count { get { return count; } }
        public AbstractFigure()
        {
            count++;
        }
        public void Print() { Console.WriteLine(this); }
    }
}
