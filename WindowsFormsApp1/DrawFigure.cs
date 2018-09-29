using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DrawFigure
    {
        public static void DrawFigureOnControl(Control control, AbstractFigure item)
        {
            Graphics gr = control.CreateGraphics();
         //   gr.Clear(Control.DefaultBackColor);
            Pen pen = new Pen(Color.Green, 3);
            ConsoleApp1.Point p = item as ConsoleApp1.Point;
            if (p != null) gr.DrawEllipse(pen, p.X, p.Y, 10, 10);
        }
    }
}
