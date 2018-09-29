using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ColorTriangle : Triangle, IColor
    {
        public string Color { get; set; }
        public ColorTriangle(Point a, Point b, Point c, string color) : base(a, b, c)
        {
            Color = color;
        }
    }
}
