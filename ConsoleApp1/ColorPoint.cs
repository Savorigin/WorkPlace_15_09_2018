using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ColorPoint : Point, IColor
    {
        public string Color { get; set; }
        public ColorPoint(int x, int y, string color) : base(x, y)
        {
            Color = color;
        }
        public override string ToString()
        {
            return base.ToString()+$", {Color}";
        }
    }
}
