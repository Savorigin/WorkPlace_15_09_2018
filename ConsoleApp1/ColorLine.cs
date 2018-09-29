using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ColorLine : Line , IColor
    {
        public string Color { get; set; }

        internal ColorLineDecorator ColorLineDecorator
        {
            get => default(ColorLineDecorator);
            set
            {
            }
        }

        public ColorLine(Point begin, Point end, string color) : base(begin, end)
        {
            Color = color;
        }

        public ColorLine(Line line,string color): base(line)
        {
            Color = color;
        }
        public override Line Clone()
        {
            return new ColorLine(base.Clone(), Color);
        }
        public override string ToString()
        {
            return base.ToString()+$"{Color}";
        }
    }
}
