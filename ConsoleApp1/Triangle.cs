using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : AbstractFigure
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        private Line sideAB;
        public Line SideAB { get {
                if(sideAB==null) sideAB = new Line(A, B);
                return sideAB;
            }
        }
        public Line SideBC { get;  }
        public Line SideAC { get;  }
        

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        //    SideAB = new Line(A, B);
            SideBC = new Line(B, C);
            SideAC = new Line(A, C);
        }
    }
}
