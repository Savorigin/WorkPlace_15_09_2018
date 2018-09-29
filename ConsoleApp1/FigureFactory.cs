using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class FigureFactory : IFigureFactory
    {
        private Random r;
        public FigureFactory()
        {
             r = new Random();
        }
        private const int COUNT = 2;
        private const int MAX_RANGE = 100;
        public AbstractFigure RandFigure() {
            
            return GetFigure(r.Next(0,COUNT));
        }
        public AbstractFigure GetFigure(int n) {
            switch (n)
            {
                case 0: return new Point(r.Next(0, MAX_RANGE), r.Next(0, MAX_RANGE));
                case 1: return new Line(2, 2, 3, 3);
                default: return null;
                   
            }
        }
    }
}
