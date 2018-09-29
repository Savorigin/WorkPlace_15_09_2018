using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Point p0 = new Point();
            Point p1 = new Point(1, 1);
            
            ColorPoint cp1 = new ColorPoint(2,2,"Red");
            Line l1 = new Line(p0, p1);
            Line l2 = new Line(3, 3, 4, 4);
            Line l3 = new Line(new Point(5, 5), new Point(6, 6));
            Line l4 = new Line(l2.Begin, l2.End);
            Line l5 = new Line(l3);
            Line l6 = l3.Clone();
            ColorLine cl1 = new ColorLine(p0, p1, "Green");
            Triangle tr1 = new Triangle(new Point(7, 7), p1, p0);
            Triangle ctr1 = new ColorTriangle(p1, p0, cp1, "Blue");

            AbstractFigure[] masFig = new AbstractFigure[5];
            masFig[0] = p1;
            masFig[1] = cp1;
            masFig[2] = l1;
            masFig[3] = cl1;
            masFig[4] = ctr1;
            IColor[] masCPoint = new IColor[10];
            int iCp = -1;
            ArrayList arlistcp = new ArrayList();
            List<IColor> listcp = new List<IColor>();
            foreach (var item in masFig)
            {
                //if(item.GetType().Name=="ColorPoint")
                //if(item is ColorPoint)
                //Console.WriteLine(((ColorPoint)item).Color);
                IColor cp = item as IColor;
                if (cp != null)
                {
                    Console.WriteLine(cp.Color);
                    masCPoint[++iCp] = cp;
                    arlistcp.Add(cp);
                    listcp.Add(cp);
                }
                item.Print();
            }
            Console.WriteLine("**********************8");
            foreach (var item in listcp)
            {
                Console.WriteLine(item.Color);
            }
        }
    }
}
