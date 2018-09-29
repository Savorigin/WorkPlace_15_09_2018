using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Point : AbstractFigure, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        private int id;
        public Point(int x, int y) : base()
        {
            X = x;
            Y = y;
            id = Count;
        }
        public Point(): this(0,0)
        {
           
        }
        public Point Clone() {
            //return new Point(X, Y);
            return (Point)MemberwiseClone();
        }
        object ICloneable.Clone()
        {
            // return this.Clone();
            return MemberwiseClone();
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        
    }
}
