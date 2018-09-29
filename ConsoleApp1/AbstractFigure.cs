using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   abstract public class AbstractFigure
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
