using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class HorizontalLine
    {
        private  List <Point> point = new List<Point>();

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                point.Add(p);
            }
        }
        public void Draw()
        {
            foreach (var p in point)
            {
                p.Draw();
            }
        } 
    }
}
