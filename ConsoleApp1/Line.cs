using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Line : AbstractFigure, ICloneable
    {
        public Point Begin { get; set; }
        public Point End { get; set; }

        public Line(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }
        public Line(Line line)
        {
            //    Begin = new Point(line.Begin.X, line.Begin.Y); 
            //    End = new Point(line.End.X, line.End.Y); 
            Begin = line.Begin.Clone();
            Begin = line.End.Clone();
        }
       
        public Line(int x1, int y1, int x2, int y2)
        {
            Begin = new Point(x1, y1);
            End = new Point(x2, y2);
        }
        public override string ToString()
        {
            return $"{Begin}, {End}";
        }
        public virtual Line Clone()
        {
            //   return new Line (this);
            //return new Line(new Point(Begin.X, Begin.Y), new Point(End.X, End.Y));
            return new Line(Begin.Clone(), End.Clone());
        }
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
