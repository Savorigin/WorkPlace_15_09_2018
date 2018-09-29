using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ColorLineDecorator
    {   public Line BaseLine { get; set; }
        public string Color { get; set; }
        public ColorLineDecorator(Line baseLine, string color)
        {
            BaseLine = baseLine;
            Color = color;
        }
    }
}
