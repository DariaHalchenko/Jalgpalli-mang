using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpalli_mäng
{
    public class VerticalLine
    {
        private  List <Point> point = new List<Point>();

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            for (int y = yUp; y <= yDown; y++)
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
