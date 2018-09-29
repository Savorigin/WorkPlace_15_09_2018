using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        AbstractFigure[] masPoint;
        public Form1()
        {
            InitializeComponent();
            masPoint = new AbstractFigure[10];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IFigureFactory figures = new FigureFactory();
            for (int i = 0; i <  masPoint.Length; i++)
            {            
                masPoint[i] = figures.RandFigure();
            }
           // Random r = new Random();

             panel1.CreateGraphics().Clear(Control.DefaultBackColor);
            foreach (var item in masPoint)
            {
                DrawFigure.DrawFigureOnControl(panel1, item);
            }
          
        }
    }
}
